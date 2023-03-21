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
    public partial class frmPesquisaFisica : Form
    {
        public frmPesquisaFisica()
        {
            InitializeComponent();
        }

        private void frmPesquisaFisica_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.fisica'. Você pode movê-la ou removê-la conforme necessário.
            this.fisicaTableAdapter.Fill(this.colabDataSet.fisica);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmPesquisaFisica = new frmMenu();
            this.Hide();
            frmPesquisaFisica.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fisicaBindingSource.Filter = string.Format("fis_CD={0}",
            textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                fisicaBindingSource.Filter = "";
            }
            else
            {
                fisicaBindingSource.Filter = string.Format("fis_CPF like'%{0}%'", textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            frmAlteraFisica frmMenu = new frmAlteraFisica();
            frmMenu.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
