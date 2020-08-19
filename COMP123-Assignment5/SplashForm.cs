using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assignment5
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.startForm.Show();
            Hide();
            splashFormTimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            splashFormTimer.Enabled = true;
        }
    }
}
