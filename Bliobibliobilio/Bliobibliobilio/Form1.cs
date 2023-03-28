using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bliobibliobilio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'biblioDataSet.livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.biblioDataSet.livros);
            livrosBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            livrosBindingSource.EndEdit();
            livrosTableAdapter.Update(biblioDataSet.livros);
            this.livrosTableAdapter.Fill(this.biblioDataSet.livros);
            livrosBindingSource.MoveLast();

            //chamar um novo registro
            livrosBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
