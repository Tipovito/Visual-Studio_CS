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
    public partial class frmAlteraJuridica : Form
    {
        public frmAlteraJuridica()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            juridicaBindingSource.EndEdit();
            juridicaTableAdapter.Update(colabDataSet.juridica);
            this.juridicaTableAdapter.Fill(this.colabDataSet.juridica);
            juridicaBindingSource.MoveLast();

            textBox1.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Alteração Concluída", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            frmPesquisaJuridica frmMenu = new frmPesquisaJuridica();
            this.Hide();
            frmMenu.ShowDialog();

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ")
        }

        private void frmAlteraJuridica_Load(object sender, EventArgs e)
        {
            this.juridicaTableAdapter.Fill(this.colabDataSet.juridica);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesquisaJuridica frmMenu = new frmPesquisaJuridica();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
