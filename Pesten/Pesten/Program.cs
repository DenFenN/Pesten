using Pesten.GameEngine;
using Pesten.GameEngine.SpecialCardCalculators;
using System;
using System.Windows.Forms;

namespace Pesten.App
{
    static class Program
    {
        internal static Engine GameEngine = new Engine(new DutchSpecialCardCalculator());

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
