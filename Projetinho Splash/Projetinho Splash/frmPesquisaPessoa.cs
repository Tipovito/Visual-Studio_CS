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
    public partial class frmPesquisaPessoa : Form
    {
        public frmPesquisaPessoa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void frmPesquisaPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.Filter = string.Format("pess_CD={0}"
,           textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmPesquisaPessoa = new frmMenu();
            this.Hide();
            frmPesquisaPessoa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                pessoaBindingSource.Filter = "";
            }
            else
            {
                pessoaBindingSource.Filter = string.Format("pess_nm like'%{0}%'", textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pessoaBindingSource.RemoveCurrent();
                pessoaTableAdapter.Update(colabDataSet.pessoa); //salvar
                this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            frmAlteraPessoa frmMenu = new frmAlteraPessoa();
            frmMenu.ShowDialog();
        }
    }
}
