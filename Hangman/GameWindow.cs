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
        public HangmanGame game { get; set; }

        public bool PlayAgain { get; private set; } = false;

        public GameWindow(HangmanGame game)
        {
            this.game = game;
            InitializeComponent();
            this.Text = this.Text + this.game.SaveName;
            UpdateWindow();
        }

        #region WINDOW UPDATING

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

                // disable keyboard & save buttons
                foreach (Button key in KeyboardPanel.Controls)
                {
                    key.Enabled = false;
                }
                this.HintButton.Enabled = false;
                this.SaveQuitButton.Enabled = false;
            }
        }

        private void UpdateDrawing()
        {
            if (game.TriesLeft <= 0)
                DrawingLabel.Text = game.HangmanPics[game.HangmanPics.Count - 1];
            else
                DrawingLabel.Text = game.HangmanPics[game.TotalTries - game.TriesLeft];
        }

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

        private void UpdateWord()
        {
            WordLabel.Text = game.DisplayWord.ToUpper();
        }

        private void UpdateTriesLeft()
        {
            TriesNumLabel.Text = game.TriesLeft.ToString();
        }

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
