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

        public GameWindow(HangmanGame game)
        {
            this.game = game;
            InitializeComponent();
            UpdateWindow();
        }

        #region WINDOW UPDATING

        private void UpdateWindow()
        {
            UpdateDrawing();
            UpdateKeys();
            UpdateWord();
            UpdateTriesLeft();

            if (game.GameOver == true)
            {
                string message;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                if (game.TriesLeft >= 1)
                    message = $"You win! The word was '{game.Word}'.";
                else
                    message = $"You lose! The word was '{game.Word}'.";
                MessageBox.Show(message, "Game over!", buttons);
                this.Close();
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

    }
}
