using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace kiosksharp
{
    static class Program
    {
        public static frmMain MainForm; // points to main form
        public static frmDevPassword PasswordForm; // points to developer password form

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Kiosk.init(); // init kiosk mode
            }
            catch (Exception e) // catch any unhandled exceptions in the context
            {
                ExceptionHandler.handle(e);
            }
        }        
    }
}
