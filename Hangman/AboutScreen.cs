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
    public partial class AboutScreen : Form
    {
        public AboutScreen()
        {
            InitializeComponent();
        }

        private void WordListLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://wordlist.aspell.net/12dicts/");

            } catch (Exception ex)
            {
                MessageBox.Show($"Unable to open link: {ex.Message}", "Error");
            }
        }
    }
}
