using System;
using System.Windows.Forms;

namespace Project_Karaoke_3layers_LTQL
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
            Application.Run(new FLogin());
            //Application.Run(new FrmMain());
        }
    }
}
