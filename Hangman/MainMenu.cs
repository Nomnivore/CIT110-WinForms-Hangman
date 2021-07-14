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

        /// <summary>
        /// This button will call methods to create a brand new hangman game, and open the window for it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            // stuff to generate blank slate game
            GameWindow newGame = new GameWindow(new HangmanGame());
            this.Visible = false;
            newGame.ShowDialog();
            this.Visible = true;
        }

        private void CreditsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
