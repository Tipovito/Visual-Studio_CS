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
    public partial class frmPesquisaParceiro : Form
    {
        public frmPesquisaParceiro()
        {
            InitializeComponent();
        }

        private void frmPesquisaParceiro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.parceiro'. Você pode movê-la ou removê-la conforme necessário.
            this.parceiroTableAdapter.Fill(this.colabDataSet.parceiro);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parceiroBindingSource.Filter = string.Format("par_CD={0}",     
            textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmPesquisaParceiro = new frmMenu();
            this.Hide();
            frmPesquisaParceiro.ShowDialog();
        }
    }
}
