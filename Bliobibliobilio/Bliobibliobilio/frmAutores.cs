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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void frmAutores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'biblioDataSet.autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.biblioDataSet.autores);
            autoresBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            autoresBindingSource.EndEdit();
            autoresTableAdapter.Update(biblioDataSet.autores);
            this.autoresTableAdapter.Fill(this.biblioDataSet.autores);
            autoresBindingSource.MoveLast();

            //chamar um novo registro
            autoresBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
