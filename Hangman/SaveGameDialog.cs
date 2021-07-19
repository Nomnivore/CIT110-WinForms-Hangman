using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HangmanApp
{
    public partial class SaveGameDialog : Form
    {
        private HangmanGame game;

        public bool Saved { get; private set; } = false;

        public SaveGameDialog(HangmanGame game)
        {
            this.game = game;
            InitializeComponent();
            this.FilenameTextBox.Text = game.SaveName;

            // temporarily disable selection mode to prevent first item from being
            //      automatically selected.
            SelectionMode sMode = this.FilesList.SelectionMode;
            this.FilesList.SelectionMode = SelectionMode.None;
            // populate items & re-set the selection mode
            this.FilesList.DataSource = SaveManager.ListAllSaves();
            this.FilesList.SelectionMode = sMode;
        }

        private void FilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FilenameTextBox.Text = this.FilesList.SelectedItem.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.game.SaveName = this.FilenameTextBox.Text;
            SaveManager.SaveGame(this.game, this.game.SaveName);
            this.Saved = true;
            this.Close();
        }
    }
}
