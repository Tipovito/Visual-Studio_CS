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
    public partial class frmAlteraParceiro : Form
    {
        public frmAlteraParceiro()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            parceiroBindingSource.EndEdit();
            parceiroTableAdapter.Update(colabDataSet.parceiro);
            this.parceiroTableAdapter.Fill(this.colabDataSet.parceiro);
            parceiroBindingSource.MoveLast();

            textBox1.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Alteração Conluída", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            frmPesquisaParceiro frmMenu = new frmPesquisaParceiro();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void frmAlteraParceiro_Load(object sender, EventArgs e)
        {
            this.parceiroTableAdapter.Fill(this.colabDataSet.parceiro);
        }
    }
}
