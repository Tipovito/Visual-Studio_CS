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
    public partial class frmCadPessoa : Form
    {
        public frmCadPessoa()
        {
            InitializeComponent();
        }

        private void frmCadPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            pessoaBindingSource.AddNew();

            foreach(Control controle in this.Controls)
    {
        if(controle is TextBox)
        {
            TextBox textBox = (TextBox)controle;
            textBox.Text = string.Empty;
        }
    }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmCadPessoa = new frmMenu();
            this.Hide();
            frmCadPessoa.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            pessoaBindingSource.EndEdit();
            pessoaTableAdapter.Update(colabDataSet.pessoa);
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            pessoaBindingSource.MoveLast();

            //chamar um novo registro
            pessoaBindingSource.AddNew();

            //Para o usuário continuar preenchendo
            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pèssoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
