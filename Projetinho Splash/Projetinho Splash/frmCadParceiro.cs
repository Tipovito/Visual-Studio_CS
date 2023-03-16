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
    public partial class frmCadParceiro : Form
    {
        private void ClearAllBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {

                    if (control is TextBox || control is ComboBox)
                    {
                        control.ResetText();
                    }
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }

        public frmCadParceiro()
        {
            InitializeComponent();
        }

        private void frmCadParceiro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.parceiro'. Você pode movê-la ou removê-la conforme necessário.
            this.parceiroTableAdapter.Fill(this.colabDataSet.parceiro);
            parceiroBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmCadParceiro = new frmMenu();
            this.Hide();
            frmCadParceiro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            parceiroBindingSource.EndEdit();
            parceiroTableAdapter.Update(colabDataSet.parceiro);
            this.parceiroTableAdapter.Fill(this.colabDataSet.parceiro);
            parceiroBindingSource.MoveLast();

            //chamar um novo registro
            parceiroBindingSource.AddNew();

            //Para o usuário continuar preenchendo
            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pèssoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
