namespace Projetinho_Splash
{
    partial class frmPesquisaParceiro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colabDataSet = new Projetinho_Splash.colabDataSet();
            this.parceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parceiroTableAdapter = new Projetinho_Splash.colabDataSetTableAdapters.parceiroTableAdapter();
            this.parCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partipopessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pardesenpenhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parceiroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa de Código";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parCDDataGridViewTextBoxColumn,
            this.partipopessoaDataGridViewTextBoxColumn,
            this.pardesenpenhoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parceiroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 135);
            this.dataGridView1.TabIndex = 4;
            // 
            // colabDataSet
            // 
            this.colabDataSet.DataSetName = "colabDataSet";
            this.colabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parceiroBindingSource
            // 
            this.parceiroBindingSource.DataMember = "parceiro";
            this.parceiroBindingSource.DataSource = this.colabDataSet;
            // 
            // parceiroTableAdapter
            // 
            this.parceiroTableAdapter.ClearBeforeFill = true;
            // 
            // parCDDataGridViewTextBoxColumn
            // 
            this.parCDDataGridViewTextBoxColumn.DataPropertyName = "par_CD";
            this.parCDDataGridViewTextBoxColumn.HeaderText = "par_CD";
            this.parCDDataGridViewTextBoxColumn.Name = "parCDDataGridViewTextBoxColumn";
            // 
            // partipopessoaDataGridViewTextBoxColumn
            // 
            this.partipopessoaDataGridViewTextBoxColumn.DataPropertyName = "par_tipo_pessoa";
            this.partipopessoaDataGridViewTextBoxColumn.HeaderText = "par_tipo_pessoa";
            this.partipopessoaDataGridViewTextBoxColumn.Name = "partipopessoaDataGridViewTextBoxColumn";
            // 
            // pardesenpenhoDataGridViewTextBoxColumn
            // 
            this.pardesenpenhoDataGridViewTextBoxColumn.DataPropertyName = "par_desenpenho";
            this.pardesenpenhoDataGridViewTextBoxColumn.HeaderText = "par_desenpenho";
            this.pardesenpenhoDataGridViewTextBoxColumn.Name = "pardesenpenhoDataGridViewTextBoxColumn";
            // 
            // frmPesquisaParceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaParceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisaParceiro";
            this.Load += new System.EventHandler(this.frmPesquisaParceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parceiroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private colabDataSet colabDataSet;
        private System.Windows.Forms.BindingSource parceiroBindingSource;
        private colabDataSetTableAdapters.parceiroTableAdapter parceiroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partipopessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pardesenpenhoDataGridViewTextBoxColumn;
    }
}