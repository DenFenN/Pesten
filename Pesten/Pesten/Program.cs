using Pesten.GameEngine;
using System;
using System.Windows.Forms;

namespace Pesten
{
    static class Program
    {
        internal static Engine GaneEngine = new Engine();


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
