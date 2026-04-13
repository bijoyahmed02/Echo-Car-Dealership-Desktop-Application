using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatIng_Web_Application
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Sign_Up_Page());
            //Application.Run(new Admin_Page());
            //Application.Run(new payment());
            Application.Run(new Sign_Up_Page());
            //Application.Run(new Main_Page());
            //Application.Run(new Shop());
            //Application.Run(new Sign_In_Page());
            //Application.Run(new Mail_Verification());
        }
    }
}
