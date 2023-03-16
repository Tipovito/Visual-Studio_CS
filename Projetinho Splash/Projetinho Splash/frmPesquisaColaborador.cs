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
    public partial class frmPesquisaColaborador : Form
    {
        public frmPesquisaColaborador()
        {
            InitializeComponent();
        }

        private void frmPesquisaColaborador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colaboradorBindingSource.Filter = string.Format("col_CD={0}",
            textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmPesquisaColaborador = new frmMenu();
            this.Hide();
            frmPesquisaColaborador.ShowDialog();
        }
    }
}
