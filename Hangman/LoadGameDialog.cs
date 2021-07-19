using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HangmanApp
{
    public partial class LoadGameDialog : Form
    {
        public string SelectedGame { get; private set; }
        public bool ConfirmLoad { get; private set; }
        

        public LoadGameDialog()
        {
            InitializeComponent();
            this.FilesList.DataSource = SaveManager.ListAllSaves();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            ConfirmLoad = true;
            SelectedGame = this.FilesList.SelectedItem.ToString();
            this.Close();
        }
    }
}
