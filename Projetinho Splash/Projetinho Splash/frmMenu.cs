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

        private void cadFisícaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFisica frmMenu = new frmCadFisica();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void cadJurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadJuridica frmMenu = new frmCadJuridica();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void cadParceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadParceiro frmMenu = new frmCadParceiro();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void pesquisaPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaPessoa frmMenu = new frmPesquisaPessoa();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void pesquisaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaJuridica frmMenu = new frmPesquisaJuridica();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void pesquisaColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaColaborador frmMenu = new frmPesquisaColaborador();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void pesquisaParceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaParceiro frmMenu = new frmPesquisaParceiro();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void pesquisaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaFisica frmMenu = new frmPesquisaFisica();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
