using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HangmanApp
{
    /// <summary>
    /// Class for storing and operating on a hangman game
    /// </summary>
    public class HangmanGame
    {
        #region PROPERTIES

        private string _word;
        /// <summary>
        /// The word the user is guessing for
        /// </summary>
        public string Word
        {
            get
            {
                return _word;
            }
            set
            {
                _word = value.ToLower();
            }
        }

        /// <summary>
        /// Letters guessed incorrectly
        /// </summary>
        public List<string> BadGuesses { get; set; } = new List<string>();

        /// <summary>
        /// Letters guessed correctly
        /// </summary>
        public List<string> GoodGuesses { get; set; } = new List<string>();

        /// <summary>
        /// Total number of incorrect tries allocated to the game.
        /// </summary>
        public int TotalTries { get; set; }

        /// <summary>
        /// Number of incorrect tries before the game is over
        /// </summary>
        public int TriesLeft { get; set; }

        public bool GameOver
        {
            get
            {
                // guard clause for lost games (no tries left)
                if (this.TriesLeft <= 0)
                    return true;

                bool victory = true; // will quickly check if it is not
                foreach (char ch in this.Word.ToCharArray())
                {
                    if (!this.GoodGuesses.Contains(ch.ToString()))
                        victory = false;
                }

                return victory;
            }
        }

        private List<string> _hangmanPics = new List<string>
        {
            @"  +---+
      |
      |
      |
      |
      |
=========)", @"  +---+
  |   |
      |
      |
      |
      |
=========)", @"  +---+
  |   |
  O   |
      |
      |
      |
=========)", @"  +---+
  |   |
  O   |
  |   |
      |
      |
=========)", @"  +---+
  |   |
  O   |
 /|   |
      |
      |
=========)", @"  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========)", @"  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========)", @"  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
=========)", @"  +---+
  ^   |
  O   |
 /|\  |
 / \  |
      |
=========)"
        };
        /// <summary>
        /// Multiline strings used for display in the game window
        /// </summary>
        public List<string> HangmanPics
        {
            get
            {
                return _hangmanPics;
            }
        }

        /// <summary>
        /// Pre-compiled regex for checking if letters are not special characters
        /// </summary>
        private Regex _alphaNumeric = new Regex(@"[a-z]");

        /// <summary>
        /// Display version of the Word, eg. " h _ l l _ - w _ r l _ "
        /// </summary>
        public string DisplayWord
        {
            get
            {
                List<string> word = new List<string>();

                foreach (char ch in Word.ToCharArray())
                {
                    string let = ch.ToString();
                    if (_alphaNumeric.IsMatch(let))
                    {
                        // is a letter
                        if (GoodGuesses.Contains(let))
                        {
                            // has been properly guessed before, so we'll show it
                            word.Add(let);
                        } else
                        {
                            // has not been guessed (yet)
                            word.Add("_"); // placeholder for unguessed letters
                        }
                    } else
                    {
                        // is a special character, so we'll show it
                        word.Add(let);
                    }
                }

                return String.Join(" ", word.ToArray());
            }
        }


        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Default constructor for brand new game
        /// </summary>
        public HangmanGame()
        {
            this.TotalTries = this.HangmanPics.Count-1;
            this.TriesLeft = this.TotalTries;

            // for now, just a basic way to get a word from 2of12.txt
            string[] wordsList = File.ReadAllLines(@"Lists\2of12.txt");
            Random rnd = new Random();
            int lineNum = rnd.Next(0, wordsList.Length - 1);
            this.Word = wordsList[lineNum];
            //this.Word = "hello-world";
            Console.WriteLine(wordsList[lineNum]);
        }

        #endregion

        #region METHODS

        public void ProcessGuess(string let)
        {
            let = let.ToLower(); // just in case it isn't lowercased already

            if (let.Length > 1)
            {
                // method was triggered by the Solve button and sent more than 1 character
                ProcessCompleteGuess(let);
                return;
            }

            // guard clause to make sure it hasn't been guessed already (keys should not allow this)
            if (GoodGuesses.Contains(let) || BadGuesses.Contains(let))
                return;

            if (Word.Contains(let))
            {
                // correct guess
                GoodGuesses.Add(let);
            } else
            {
                // incorrect guess
                BadGuesses.Add(let);
                TriesLeft = TriesLeft - 1;
            }
        }

        public void ProcessCompleteGuess(string guess)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
