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
    public partial class frmAcervo : Form
    {
        public frmAcervo()
        {
            InitializeComponent();
        }

        private void frmAcervo_Load(object sender, EventArgs e)
        {   
            this.livrosTableAdapter.Fill(this.biblioDataSet.livros);
            // TODO: esta linha de código carrega dados na tabela 'biblioDataSet.autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.biblioDataSet.autores);
            // TODO: esta linha de código carrega dados na tabela 'biblioDataSet.acervo'. Você pode movê-la ou removê-la conforme necessário.
            this.acervoTableAdapter.Fill(this.biblioDataSet.acervo);
            acervoBindingSource.AddNew();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            acervoBindingSource.EndEdit();
            acervoTableAdapter.Update(biblioDataSet.acervo);
            this.acervoTableAdapter.Fill(this.biblioDataSet.acervo);
            acervoBindingSource.MoveLast();

            //chamar um novo registro
            acervoBindingSource.AddNew();

   
              textBox1.Text = "";
              textBox2.Text = (" ");

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
