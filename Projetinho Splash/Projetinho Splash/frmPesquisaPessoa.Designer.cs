namespace Projetinho_Splash
{
    partial class frmPesquisaPessoa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pessCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessnmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessnmfantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessenderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessnumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesscomplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessbairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesscepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesscidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesssenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesscargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colabDataSet = new Projetinho_Splash.colabDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.pessoaTableAdapter = new Projetinho_Splash.colabDataSetTableAdapters.pessoaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pessCDDataGridViewTextBoxColumn,
            this.pessnmDataGridViewTextBoxColumn,
            this.pessnmfantasiaDataGridViewTextBoxColumn,
            this.pessenderecoDataGridViewTextBoxColumn,
            this.pessnumeroDataGridViewTextBoxColumn,
            this.pesscomplDataGridViewTextBoxColumn,
            this.pessbairroDataGridViewTextBoxColumn,
            this.pesscepDataGridViewTextBoxColumn,
            this.pesscidadeDataGridViewTextBoxColumn,
            this.pessufDataGridViewTextBoxColumn,
            this.pessloginDataGridViewTextBoxColumn,
            this.pesssenhaDataGridViewTextBoxColumn,
            this.pesscargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(446, 135);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pessCDDataGridViewTextBoxColumn
            // 
            this.pessCDDataGridViewTextBoxColumn.DataPropertyName = "pess_CD";
            this.pessCDDataGridViewTextBoxColumn.HeaderText = "pess_CD";
            this.pessCDDataGridViewTextBoxColumn.Name = "pessCDDataGridViewTextBoxColumn";
            this.pessCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pessnmDataGridViewTextBoxColumn
            // 
            this.pessnmDataGridViewTextBoxColumn.DataPropertyName = "pess_nm";
            this.pessnmDataGridViewTextBoxColumn.HeaderText = "pess_nm";
            this.pessnmDataGridViewTextBoxColumn.Name = "pessnmDataGridViewTextBoxColumn";
            // 
            // pessnmfantasiaDataGridViewTextBoxColumn
            // 
            this.pessnmfantasiaDataGridViewTextBoxColumn.DataPropertyName = "pess_nm_fantasia";
            this.pessnmfantasiaDataGridViewTextBoxColumn.HeaderText = "pess_nm_fantasia";
            this.pessnmfantasiaDataGridViewTextBoxColumn.Name = "pessnmfantasiaDataGridViewTextBoxColumn";
            // 
            // pessenderecoDataGridViewTextBoxColumn
            // 
            this.pessenderecoDataGridViewTextBoxColumn.DataPropertyName = "pess_endereco";
            this.pessenderecoDataGridViewTextBoxColumn.HeaderText = "pess_endereco";
            this.pessenderecoDataGridViewTextBoxColumn.Name = "pessenderecoDataGridViewTextBoxColumn";
            // 
            // pessnumeroDataGridViewTextBoxColumn
            // 
            this.pessnumeroDataGridViewTextBoxColumn.DataPropertyName = "pess_numero";
            this.pessnumeroDataGridViewTextBoxColumn.HeaderText = "pess_numero";
            this.pessnumeroDataGridViewTextBoxColumn.Name = "pessnumeroDataGridViewTextBoxColumn";
            // 
            // pesscomplDataGridViewTextBoxColumn
            // 
            this.pesscomplDataGridViewTextBoxColumn.DataPropertyName = "pess_compl";
            this.pesscomplDataGridViewTextBoxColumn.HeaderText = "pess_compl";
            this.pesscomplDataGridViewTextBoxColumn.Name = "pesscomplDataGridViewTextBoxColumn";
            // 
            // pessbairroDataGridViewTextBoxColumn
            // 
            this.pessbairroDataGridViewTextBoxColumn.DataPropertyName = "pess_bairro";
            this.pessbairroDataGridViewTextBoxColumn.HeaderText = "pess_bairro";
            this.pessbairroDataGridViewTextBoxColumn.Name = "pessbairroDataGridViewTextBoxColumn";
            // 
            // pesscepDataGridViewTextBoxColumn
            // 
            this.pesscepDataGridViewTextBoxColumn.DataPropertyName = "pess_cep";
            this.pesscepDataGridViewTextBoxColumn.HeaderText = "pess_cep";
            this.pesscepDataGridViewTextBoxColumn.Name = "pesscepDataGridViewTextBoxColumn";
            // 
            // pesscidadeDataGridViewTextBoxColumn
            // 
            this.pesscidadeDataGridViewTextBoxColumn.DataPropertyName = "pess_cidade";
            this.pesscidadeDataGridViewTextBoxColumn.HeaderText = "pess_cidade";
            this.pesscidadeDataGridViewTextBoxColumn.Name = "pesscidadeDataGridViewTextBoxColumn";
            // 
            // pessufDataGridViewTextBoxColumn
            // 
            this.pessufDataGridViewTextBoxColumn.DataPropertyName = "pess_uf";
            this.pessufDataGridViewTextBoxColumn.HeaderText = "pess_uf";
            this.pessufDataGridViewTextBoxColumn.Name = "pessufDataGridViewTextBoxColumn";
            // 
            // pessloginDataGridViewTextBoxColumn
            // 
            this.pessloginDataGridViewTextBoxColumn.DataPropertyName = "pess_login";
            this.pessloginDataGridViewTextBoxColumn.HeaderText = "pess_login";
            this.pessloginDataGridViewTextBoxColumn.Name = "pessloginDataGridViewTextBoxColumn";
            // 
            // pesssenhaDataGridViewTextBoxColumn
            // 
            this.pesssenhaDataGridViewTextBoxColumn.DataPropertyName = "pess_senha";
            this.pesssenhaDataGridViewTextBoxColumn.HeaderText = "pess_senha";
            this.pesssenhaDataGridViewTextBoxColumn.Name = "pesssenhaDataGridViewTextBoxColumn";
            // 
            // pesscargoDataGridViewTextBoxColumn
            // 
            this.pesscargoDataGridViewTextBoxColumn.DataPropertyName = "pess_cargo";
            this.pesscargoDataGridViewTextBoxColumn.HeaderText = "pess_cargo";
            this.pesscargoDataGridViewTextBoxColumn.Name = "pesscargoDataGridViewTextBoxColumn";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.colabDataSet;
            // 
            // colabDataSet
            // 
            this.colabDataSet.DataSetName = "colabDataSet";
            this.colabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmPesquisaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 484);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisaPessoa";
            this.Load += new System.EventHandler(this.frmPesquisaPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private colabDataSet colabDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private colabDataSetTableAdapters.pessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessnmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessnmfantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessenderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessnumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesscomplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessbairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesscepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesscidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesssenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesscargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}