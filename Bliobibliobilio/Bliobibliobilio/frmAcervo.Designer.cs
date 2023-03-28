namespace Bliobibliobilio
{
    partial class frmAcervo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.biblioDataSet = new Bliobibliobilio.biblioDataSet();
            this.acervoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acervoTableAdapter = new Bliobibliobilio.biblioDataSetTableAdapters.acervoTableAdapter();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new Bliobibliobilio.biblioDataSetTableAdapters.livrosTableAdapter();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresTableAdapter = new Bliobibliobilio.biblioDataSetTableAdapters.autoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acervoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Autor";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acervoBindingSource, "livro_CD", true));
            this.comboBox1.DataSource = this.livrosBindingSource;
            this.comboBox1.DisplayMember = "livros_CD";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(197, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acervoBindingSource, "autor_CD", true));
            this.comboBox2.DataSource = this.autoresBindingSource;
            this.comboBox2.DisplayMember = "autor_CD";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(197, 166);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "livros_NM", true));
            this.textBox1.Location = new System.Drawing.Point(376, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "autor_NM", true));
            this.textBox2.Location = new System.Drawing.Point(376, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // biblioDataSet
            // 
            this.biblioDataSet.DataSetName = "biblioDataSet";
            this.biblioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acervoBindingSource
            // 
            this.acervoBindingSource.DataMember = "acervo";
            this.acervoBindingSource.DataSource = this.biblioDataSet;
            // 
            // acervoTableAdapter
            // 
            this.acervoTableAdapter.ClearBeforeFill = true;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "livros";
            this.livrosBindingSource.DataSource = this.biblioDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "autores";
            this.autoresBindingSource.DataSource = this.biblioDataSet;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 580);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcervo";
            this.Text = "frmAcervo";
            this.Load += new System.EventHandler(this.frmAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acervoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private biblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource acervoBindingSource;
        private biblioDataSetTableAdapters.acervoTableAdapter acervoTableAdapter;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private biblioDataSetTableAdapters.livrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private biblioDataSetTableAdapters.autoresTableAdapter autoresTableAdapter;
    }
}