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
    public partial class frmAlteraFisica : Form
    {
        public frmAlteraFisica()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            fisicaBindingSource.EndEdit();
            fisicaTableAdapter.Update(colabDataSet.fisica);
            this.fisicaTableAdapter.Fill(this.colabDataSet.fisica);
            fisicaBindingSource.MoveLast();

            textBox1.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Alteração Concluída", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            frmPesquisaFisica frmMenu = new frmPesquisaFisica();
            this.Hide();
            frmMenu.ShowDialog();

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ")
        }

        private void frmAlteraFisica_Load(object sender, EventArgs e)
        {
            this.fisicaTableAdapter.Fill(this.colabDataSet.fisica);
            if (Class1.codigo == "")
            { fisicaBindingSource.AddNew(); }
            else
            { fisicaBindingSource.Filter = string.Format("fis_CD={0}", Class1.codigo); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesquisaFisica frmMenu = new frmPesquisaFisica();
            this.Hide();
            frmMenu.ShowDialog();

        }
    }
}
