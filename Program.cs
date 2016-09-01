using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lccCtcLinkRolePicker
{
    static class lccCtcLinkRolePickerClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] lccParamALArgs)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lccForm1(lccParamALArgs));
        }
    }
}
