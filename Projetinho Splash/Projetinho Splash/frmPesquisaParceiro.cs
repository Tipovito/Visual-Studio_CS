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

        private void button3_Click(object sender, EventArgs e)
        {
            parceiroBindingSource.Filter = string.Format("par_tipo_pessoa={0}",
            textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                parceiroBindingSource.RemoveCurrent();
                parceiroTableAdapter.Update(colabDataSet.parceiro); //salvar
                this.parceiroTableAdapter.Fill(this.colabDataSet.parceiro);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            frmAlteraParceiro frmMenu = new frmAlteraParceiro();
            frmMenu.ShowDialog();
        }
    }
}
