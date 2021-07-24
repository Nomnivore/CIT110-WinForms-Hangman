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
    public partial class GameWindow : Form
    {
        /// <summary>
        /// Reference to the Hangmangame object model
        /// </summary>
        public HangmanGame game { get; set; }

        /// <summary>
        /// User's choice to play a new game without returning to menu
        /// </summary>
        public bool PlayAgain { get; private set; } = false;

        public GameWindow(HangmanGame game)
        {
            this.game = game;
            InitializeComponent();
            this.Text = this.Text + this.game.SaveName;
            UpdateWindow();

            if (this.WordLabel.Text.Length >= 34)
            {
                this.WordLabel.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            } else
            {
                this.WordLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }
        }

        #region WINDOW UPDATING

        /// <summary>
        /// Calls other Update methods to change various label and button properties based on game state
        /// </summary>
        private void UpdateWindow()
        {
            UpdateDrawing();
            UpdateKeys();
            UpdateWord();
            UpdateTriesLeft();
            UpdateHints();

            if (game.GameOver == true)
            {
                // show the game over side-panel

                if (game.TriesLeft >= 1)
                {
                    this.GameOverLabel.Text = "You win!";
                    this.GameOverLabel.ForeColor = Color.MediumSeaGreen;
                } else
                {
                    this.GameOverLabel.Text = "You lose!";
                    this.GameOverLabel.ForeColor = Color.Brown; // Firebrick is also nice
                }

                this.GameOverWordLabel.Text = game.Word;
                this.GameOverPanel.Visible = true;
                this.AcceptButton = this.PlayAgainButton;

                // disable keyboard & save buttons
                foreach (Button key in KeyboardPanel.Controls)
                {
                    key.Enabled = false;
                }
                this.HintButton.Enabled = false;
                this.SaveQuitButton.Enabled = false;
            }
        }

        /// <summary>
        /// Sets the hangman stick figure to the correct state
        /// </summary>
        private void UpdateDrawing()
        {
            if (game.TriesLeft <= 0)
                DrawingLabel.Text = game.HangmanPics[game.HangmanPics.Count - 1];
            else
                DrawingLabel.Text = game.HangmanPics[game.TotalTries - game.TriesLeft];
        }

        /// <summary>
        /// Disables and recolors keyboard buttons if guessed
        /// </summary>
        private void UpdateKeys()
        {
            foreach (Button key in KeyboardPanel.Controls)
            {
                string letter = key.Text.ToLower();
                if (game.BadGuesses.Contains(letter))
                {
                    // letter was guessed incorrectly
                    key.Enabled = false;
                    key.BackColor = Color.FromArgb(255, 128, 128);
                } else if (game.GoodGuesses.Contains(letter))
                {
                    // letter was guessed correctly
                    key.Enabled = false;
                    key.BackColor = Color.FromArgb(128, 255, 128);
                }
            }
        }

        /// <summary>
        /// Updates the underscore'd word to display guessed letters
        /// </summary>
        private void UpdateWord()
        {
            WordLabel.Text = game.DisplayWord.ToUpper();
        }

        /// <summary>
        /// Update the Tries Left counter to show how many incorrect guesses remain
        /// </summary>
        private void UpdateTriesLeft()
        {
            TriesNumLabel.Text = game.TriesLeft.ToString();
        }

        /// <summary>
        /// Update the Hints left counter to show how many hint uses remain
        /// </summary>
        private void UpdateHints()
        {
            if (game.HintsRemaining <= 0)
                this.HintButton.Enabled = false;

            this.HintsNumLabel.Text = game.HintsRemaining.ToString();
        }

        #endregion

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnScreenKeyboardButton_Click(object sender, EventArgs e)
        {
            Button keyPressed = (Button)sender;
            string guess = keyPressed.Text.ToLower();
            game.ProcessGuess(guess);

            UpdateWindow();
        }

        private void SaveQuitButton_Click(object sender, EventArgs e)
        {
            SaveGameDialog saveDialog = new SaveGameDialog(game);
            saveDialog.ShowDialog();

            // only close if game was saved (window not cancelled or X'd)
            if (saveDialog.Saved)
                this.Close();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            PlayAgain = true;
            this.Close();
        }

        private void GameWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            // keyboard shortcuts for letter buttons
            string keyPressed = e.KeyChar.ToString().ToUpper();

            foreach (Button key in KeyboardPanel.Controls)
            {
                if (key.Text == keyPressed)
                    key.PerformClick();
            }
        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveManager.DeleteIfGameOver(game);
        }

        private void HintButton_Click(object sender, EventArgs e)
        {
            this.game.ProcessHint();
            UpdateWindow();
        }
    }
}
