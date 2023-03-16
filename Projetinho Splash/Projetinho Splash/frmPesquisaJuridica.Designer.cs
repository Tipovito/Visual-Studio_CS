namespace Projetinho_Splash
{
    partial class frmPesquisaJuridica
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colabDataSet = new Projetinho_Splash.colabDataSet();
            this.juridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juridicaTableAdapter = new Projetinho_Splash.colabDataSetTableAdapters.juridicaTableAdapter();
            this.jurCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurInsEstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurfundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa de Código";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jurCDDataGridViewTextBoxColumn,
            this.jurCNPJDataGridViewTextBoxColumn,
            this.jurInsEstDataGridViewTextBoxColumn,
            this.jurfundDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.juridicaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(446, 135);
            this.dataGridView1.TabIndex = 3;
            // 
            // colabDataSet
            // 
            this.colabDataSet.DataSetName = "colabDataSet";
            this.colabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juridicaBindingSource
            // 
            this.juridicaBindingSource.DataMember = "juridica";
            this.juridicaBindingSource.DataSource = this.colabDataSet;
            // 
            // juridicaTableAdapter
            // 
            this.juridicaTableAdapter.ClearBeforeFill = true;
            // 
            // jurCDDataGridViewTextBoxColumn
            // 
            this.jurCDDataGridViewTextBoxColumn.DataPropertyName = "jur_CD";
            this.jurCDDataGridViewTextBoxColumn.HeaderText = "jur_CD";
            this.jurCDDataGridViewTextBoxColumn.Name = "jurCDDataGridViewTextBoxColumn";
            // 
            // jurCNPJDataGridViewTextBoxColumn
            // 
            this.jurCNPJDataGridViewTextBoxColumn.DataPropertyName = "jur_CNPJ";
            this.jurCNPJDataGridViewTextBoxColumn.HeaderText = "jur_CNPJ";
            this.jurCNPJDataGridViewTextBoxColumn.Name = "jurCNPJDataGridViewTextBoxColumn";
            // 
            // jurInsEstDataGridViewTextBoxColumn
            // 
            this.jurInsEstDataGridViewTextBoxColumn.DataPropertyName = "jur_Ins_Est";
            this.jurInsEstDataGridViewTextBoxColumn.HeaderText = "jur_Ins_Est";
            this.jurInsEstDataGridViewTextBoxColumn.Name = "jurInsEstDataGridViewTextBoxColumn";
            // 
            // jurfundDataGridViewTextBoxColumn
            // 
            this.jurfundDataGridViewTextBoxColumn.DataPropertyName = "jur_fund";
            this.jurfundDataGridViewTextBoxColumn.HeaderText = "jur_fund";
            this.jurfundDataGridViewTextBoxColumn.Name = "jurfundDataGridViewTextBoxColumn";
            // 
            // frmPesquisaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaJuridica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisaJuridica";
            this.Load += new System.EventHandler(this.frmPesquisaJuridica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private colabDataSet colabDataSet;
        private System.Windows.Forms.BindingSource juridicaBindingSource;
        private colabDataSetTableAdapters.juridicaTableAdapter juridicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurInsEstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurfundDataGridViewTextBoxColumn;
    }
}