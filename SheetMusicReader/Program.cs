using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheetMusicReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ///Initializes the form
            if (!System.IO.File.Exists("recentFiles.ini"))
            {
                using (System.IO.StreamWriter fs = new System.IO.StreamWriter("recentFiles.ini"))
                {
                }
            }
            if (!System.IO.File.Exists("userPref.ini"))
            {
                using (System.IO.FileStream fs = System.IO.File.Create("userPref.ini"))
                { }
                using (System.IO.StreamWriter fs =
new System.IO.StreamWriter("userPref.ini"))
                {
                    fs.WriteLine("[Background Colour]");
                    fs.WriteLine("-8355712");
                }
            }
            Application.Run(new StartupForm());

        }
    }
}
