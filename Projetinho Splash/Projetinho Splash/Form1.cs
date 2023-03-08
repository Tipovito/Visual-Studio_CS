using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetinho_Splash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
              {
                    progressBar1.Value = progressBar1.Value + 2;
              }
            else
              {
                    timer1.Enabled = false;
                    frmLogin frl = new frmLogin();
                    frl.Show();
                    this.Visible = false;
              }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
