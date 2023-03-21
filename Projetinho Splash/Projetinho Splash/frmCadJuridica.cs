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
    public partial class frmCadJuridica : Form
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

        public frmCadJuridica()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmCadJuridica = new frmMenu();
            this.Hide();
            frmCadJuridica.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void frmCadJuridica_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.juridica'. Você pode movê-la ou removê-la conforme necessário.
            this.juridicaTableAdapter.Fill(this.colabDataSet.juridica);
            juridicaBindingSource.AddNew();
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            juridicaBindingSource.EndEdit();
            juridicaTableAdapter.Update(colabDataSet.juridica);
            this.juridicaTableAdapter.Fill(this.colabDataSet.juridica);
            juridicaBindingSource.MoveLast();

            //chamar um novo registro
            juridicaBindingSource.AddNew();

            //Para o usuário continuar preenchendo
            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pèssoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPesquisaJuridica frmMenu = new frmPesquisaJuridica();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
