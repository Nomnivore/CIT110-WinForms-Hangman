using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            // exit the application
            this.Close();
        }

        private void PlayGameLoop(HangmanGame firstGame)
        {
            // loop while user has selected Play Again
            bool keepPlaying;
            bool isFirstGame = true;
            this.Visible = false;
            GameWindow newGame;
            do
            {
                if (isFirstGame)
                {
                    isFirstGame = false;
                    newGame = new GameWindow(firstGame);
                }
                else
                    newGame = new GameWindow(new HangmanGame());
                    
                newGame.ShowDialog();
                keepPlaying = newGame.PlayAgain;
            } while (keepPlaying);
            this.Visible = true;
        }

        /// <summary>
        /// This button will call methods to create a brand new hangman game, and open the window for it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            PlayGameLoop(new HangmanGame());
        }
        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            LoadGameDialog loadDialog = new LoadGameDialog();
            loadDialog.ShowDialog();
            if (loadDialog.ConfirmLoad)
            {
                if (loadDialog.SelectedGame != null)
                {
                    PlayGameLoop(SaveManager.LoadGame(loadDialog.SelectedGame));
                }
            }
        }

        private void CreditsLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
