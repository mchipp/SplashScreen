using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;

            // lines 26-27 can be uncommented when SplashScreenForm.cs is
            // added to a project with a form to proceed to
            //StartForm startForm = new StartForm();
            //startForm.Show();
            this.Hide();
        }
    }
}
