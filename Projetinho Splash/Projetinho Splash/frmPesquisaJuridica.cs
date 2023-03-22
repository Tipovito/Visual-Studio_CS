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
    public partial class frmPesquisaJuridica : Form
    {
        public frmPesquisaJuridica()
        {
            InitializeComponent();
        }

        private void frmPesquisaJuridica_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.juridica'. Você pode movê-la ou removê-la conforme necessário.
            this.juridicaTableAdapter.Fill(this.colabDataSet.juridica);
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.juridica'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            juridicaBindingSource.Filter = string.Format("jur_CD={0}",
            textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmPesquisaJuridica = new frmMenu();
            this.Hide();
            frmPesquisaJuridica.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            juridicaBindingSource.Filter = string.Format("jur_CNPJ={0}",
            textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frmAlteraJuridica frmMenu = new frmAlteraJuridica();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                juridicaBindingSource.RemoveCurrent();
                juridicaTableAdapter.Update(colabDataSet.juridica); //salvar
                this.juridicaTableAdapter.Fill(this.colabDataSet.juridica);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }
    }
}
