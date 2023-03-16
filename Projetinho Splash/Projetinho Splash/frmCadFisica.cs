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
    public partial class frmCadFisica : Form
    {
        public frmCadFisica()
        {
            InitializeComponent();
        }

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

        private void frmCadFisica_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.fisica'. Você pode movê-la ou removê-la conforme necessário.
            this.fisicaTableAdapter.Fill(this.colabDataSet.fisica);
            fisicaBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmCadFisica = new frmMenu();
            this.Hide();
            frmCadFisica.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            fisicaBindingSource.EndEdit();
            fisicaTableAdapter.Update(colabDataSet.fisica);
            this.fisicaTableAdapter.Fill(this.colabDataSet.fisica);
            fisicaBindingSource.MoveLast();

            //chamar um novo registro
            fisicaBindingSource.AddNew();

            //Para o usuário continuar preenchendo
            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pèssoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
