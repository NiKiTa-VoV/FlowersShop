using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowersShop.View;
using LibraryFlowersShop;

namespace FlowersShop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #if DEBUG
                ConsoleCustom.ConsoleStart();
            #endif
            Application.Run( new FormStart());
        }
    }
}
