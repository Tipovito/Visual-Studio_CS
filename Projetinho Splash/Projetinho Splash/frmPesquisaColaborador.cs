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

        private void button3_Click(object sender, EventArgs e)
        {
            colaboradorBindingSource.Filter = string.Format("col_ctps={0}",
            textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            frmAlteraColaborador frmMenu = new frmAlteraColaborador();
            frmMenu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                colaboradorBindingSource.RemoveCurrent();
                colaboradorTableAdapter.Update(colabDataSet.colaborador); //salvar
                this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }
    }
}
