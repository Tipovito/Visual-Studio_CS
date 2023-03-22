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
    public partial class frmAlteraPessoa : Form
    {
        public frmAlteraPessoa()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            pessoaBindingSource.EndEdit();
            pessoaTableAdapter.Update(colabDataSet.pessoa);
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            pessoaBindingSource.MoveLast();
        
            textBox1.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Alteração Conluída", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            frmPesquisaPessoa frmMenu = new frmPesquisaPessoa();
            this.Hide();
            frmMenu.ShowDialog();

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");

        }

        private void frmAlteraPessoa_Load(object sender, EventArgs e)
        {
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            if (Class1.codigo == "")
            { pessoaBindingSource.AddNew(); }
            else
            { pessoaBindingSource.Filter = string.Format("pess_CD={0}", Class1.codigo); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesquisaPessoa frmMenu = new frmPesquisaPessoa();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
