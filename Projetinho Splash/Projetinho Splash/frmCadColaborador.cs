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
    public partial class frmCadColaborador : Form
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

        public frmCadColaborador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmCadColaborador = new frmMenu();
            this.Hide();
            frmCadColaborador.ShowDialog();
        }

        private void frmCadColaborador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            colaboradorBindingSource.AddNew();
        }

        private void colaboradorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            colaboradorBindingSource.EndEdit();
            colaboradorTableAdapter.Update(colabDataSet.colaborador);
            this.colaboradorTableAdapter.Fill(this.colabDataSet.colaborador);
            colaboradorBindingSource.MoveLast();

            //chamar um novo registro
            colaboradorBindingSource.AddNew();

            //Para o usuário continuar preenchendo
            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pèssoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPesquisaColaborador frmMenu = new frmPesquisaColaborador();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
