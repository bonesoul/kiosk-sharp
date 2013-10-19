using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace kiosksharp
{
    /// <summary>
    /// General Exception Handler
    /// </summary>
    public static class ExceptionHandler
    {

        /// <summary>
        /// Handle the provided exception using our own Exception form
        /// </summary>
        public static void handle(Exception e)
        {
            frmException f = new frmException(); // new exception gui
            f.set_unhandled_exception(e); // set the exception to shown
            f.ShowDialog(); // show as dialog
        }

        public static void handle(String exception) // overloaded string based method
        {
            Exception e = new Exception(exception);
            frmException f = new frmException();
            f.set_unhandled_exception(e);
            f.ShowDialog();
        }
    }
}
