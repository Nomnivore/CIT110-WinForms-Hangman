using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanApp
{
    static class Program
    {
//      ************************************
//      Title: Hangman!
//      Application Type: .NET 5.0, WinForms
//      Description: A fully-functioning WinForms program to play Hangman.
//      Author: Kyle Warner
//      Date Created: July 10th, 2021
//      Last Modified: July 19th, 2021
//      ************************************


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

        }
    }
}
