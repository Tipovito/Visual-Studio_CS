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
    public partial class frmAlteraColaborador : Form
    {
        public frmAlteraColaborador()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            colaboradorBindingSource.EndEdit();
            colaboradorTableAdapter.Update(colabDataSet.colaborador);
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            colaboradorBindingSource.MoveLast();

            textBox1.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Alteração Conluída", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            frmPesquisaColaborador frmMenu = new frmPesquisaColaborador();
            this.Hide();
            frmMenu.ShowDialog();

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void frmAlteraColaborador_Load(object sender, EventArgs e)
        {
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            if (Class1.codigo == "")
            { colaboradorBindingSource.AddNew(); }
            else
            { colaboradorBindingSource.Filter = string.Format("col_CD={0}", Class1.codigo); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesquisaColaborador frmMenu = new frmPesquisaColaborador();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
