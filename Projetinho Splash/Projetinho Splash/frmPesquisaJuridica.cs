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
    }
}
