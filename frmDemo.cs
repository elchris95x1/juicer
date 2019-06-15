using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_FinalProject
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void frmDemo_Load(object sender, EventArgs e)
        { //plays demo video
            try
            {
                wmpDemo.URL = System.IO.Path.GetFullPath(@"..\..\Videos\2017-08-13 00-48-08.mp4"); 
                wmpDemo.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
