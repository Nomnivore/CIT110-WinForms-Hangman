using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace HangmanApp
{
    public static class SaveManager
    {
        /// <summary>
        /// The folder to save/load games to/from
        /// </summary>
        public static string SaveDir { get; } = "Saves";

        private static string GameToJsonString(HangmanGame game)
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(game, options);
            return jsonString;
        }

        private static byte[] GameToJsonBytes(HangmanGame game)
        {
            return JsonSerializer.SerializeToUtf8Bytes(game);
        }

        private static HangmanGame JsonBytesToGame(byte[] bytes)
        {
            Utf8JsonReader utf8Reader = new Utf8JsonReader(bytes);
            HangmanGame loadedGame;
            //try
            //{
            //    loadedGame = JsonSerializer.Deserialize<HangmanGame>(ref utf8Reader);

            //} catch (JsonException e)
            //{
            //    loadedGame = null;
            //}
            loadedGame = JsonSerializer.Deserialize<HangmanGame>(ref utf8Reader);
            return loadedGame;
        }

        /// <summary>
        /// Obfuscates and saves game data to a file in the Saves directory
        /// </summary>
        /// <param name="game">The game to save</param>
        /// <param name="filename">Name of the file, without extension</param>
        public static void SaveGame(HangmanGame game, string filename)
        {
            // create directory if it doesn't exist
            System.IO.Directory.CreateDirectory(SaveDir);

            // sanitize filenames to exclude characters not accepted by filesystem
            foreach (char ch in Path.GetInvalidFileNameChars())
            {
                filename = filename.Replace(ch.ToString(), "");
            }
            // string version
            //File.WriteAllText(Path.Combine(SaveDir, $"{filename}.txt"), GameToJsonString(game));

            // bytes version
            string obfuscatedData = Convert.ToBase64String(GameToJsonBytes(game));
            File.WriteAllText(Path.Combine(SaveDir, $"{filename}.txt"), obfuscatedData);
        }

        /// <summary>
        /// Loads a game from the Saves directory, or a new game if that file cannot be read.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>Loaded game from file</returns>
        public static HangmanGame LoadGame(string filename)
        {
            FileInfo file = new FileInfo(Path.Combine(SaveDir, $"{filename}.txt"));
            if (file.Exists)
            {
                string obfuscatedData = File.ReadAllText(file.FullName);
                byte[] gameData = Convert.FromBase64String(obfuscatedData);
                string gameString = Encoding.UTF8.GetString(gameData);
                HangmanGame loadedGame = JsonBytesToGame(gameData);
                if (loadedGame != null)
                    return loadedGame;
            }

            // upon any load error, send a brand new game instead
            return new HangmanGame();
        }

        /// <summary>
        /// Deletes saved file from Saves folder if it exists and if the game is won or lost.
        /// </summary>
        /// <param name="game"></param>
        public static void DeleteIfGameOver(HangmanGame game)
        {
            if (game.GameOver)
            {
                FileInfo file = new FileInfo(Path.Combine(SaveDir, $"{game.SaveName}.txt"));
                file.Delete();
            }
        }

        /// <summary>
        /// Get a list of all saved game names
        /// </summary>
        /// <returns></returns>
        public static List<string> ListAllSaves()
        {
            DirectoryInfo dir = new DirectoryInfo(SaveDir);
            dir.Create();
            FileInfo[] files = dir.GetFiles("*.txt");

            List<string> allFiles = new List<string>();

            foreach (FileInfo file in files)
            {
                allFiles.Add(Path.GetFileNameWithoutExtension(file.Name));
            }

            return allFiles;
        }
    }
}
