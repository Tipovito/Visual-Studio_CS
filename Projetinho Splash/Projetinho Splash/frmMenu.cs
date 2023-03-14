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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoa frmMenu = new frmCadPessoa();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmMenu = new frmLogin();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void cadColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadColaborador frmMenu = new frmCadColaborador();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
