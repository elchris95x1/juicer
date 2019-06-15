using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_FinalProject
{
    static class Program
    {
        /// <summary>
        /// Proggramed by Christian Lara on 8/12/2017
        /// The program will allow the user to choosea juice mixture, the program prints a order recipt to show to the clerk
        /// A manager can edit the items displayed with a manager log in, to register a manager you need the acces key wich is: 123
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
