using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProProkat
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists("ConnectFile.txt"))
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new CreateDBForm());
                Application.Run(new MainForm());
            }
        }
    }
}
