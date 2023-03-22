namespace Projetinho_Splash
{
    partial class frmPesquisaColaborador
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
            this.colCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colctpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltiteleitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreservistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colestcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumdepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsetorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsalarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemailPesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemailcorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colabDataSet = new Projetinho_Splash.colabDataSet();
            this.colaboradorTableAdapter = new Projetinho_Splash.colabDataSetTableAdapters.colaboradorTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
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
            this.colCDDataGridViewTextBoxColumn,
            this.colctpsDataGridViewTextBoxColumn,
            this.colpisDataGridViewTextBoxColumn,
            this.coltiteleitorDataGridViewTextBoxColumn,
            this.colreservistaDataGridViewTextBoxColumn,
            this.colestcivilDataGridViewTextBoxColumn,
            this.colnumdepDataGridViewTextBoxColumn,
            this.colativoDataGridViewTextBoxColumn,
            this.colsetorDataGridViewTextBoxColumn,
            this.colcargoDataGridViewTextBoxColumn,
            this.colsalarioDataGridViewTextBoxColumn,
            this.colfone1DataGridViewTextBoxColumn,
            this.colfone2DataGridViewTextBoxColumn,
            this.colemailPesDataGridViewTextBoxColumn,
            this.colemailcorpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colaboradorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(446, 135);
            this.dataGridView1.TabIndex = 3;
            // 
            // colCDDataGridViewTextBoxColumn
            // 
            this.colCDDataGridViewTextBoxColumn.DataPropertyName = "col_CD";
            this.colCDDataGridViewTextBoxColumn.HeaderText = "col_CD";
            this.colCDDataGridViewTextBoxColumn.Name = "colCDDataGridViewTextBoxColumn";
            // 
            // colctpsDataGridViewTextBoxColumn
            // 
            this.colctpsDataGridViewTextBoxColumn.DataPropertyName = "col_ctps";
            this.colctpsDataGridViewTextBoxColumn.HeaderText = "col_ctps";
            this.colctpsDataGridViewTextBoxColumn.Name = "colctpsDataGridViewTextBoxColumn";
            // 
            // colpisDataGridViewTextBoxColumn
            // 
            this.colpisDataGridViewTextBoxColumn.DataPropertyName = "col_pis";
            this.colpisDataGridViewTextBoxColumn.HeaderText = "col_pis";
            this.colpisDataGridViewTextBoxColumn.Name = "colpisDataGridViewTextBoxColumn";
            // 
            // coltiteleitorDataGridViewTextBoxColumn
            // 
            this.coltiteleitorDataGridViewTextBoxColumn.DataPropertyName = "col_tit_eleitor";
            this.coltiteleitorDataGridViewTextBoxColumn.HeaderText = "col_tit_eleitor";
            this.coltiteleitorDataGridViewTextBoxColumn.Name = "coltiteleitorDataGridViewTextBoxColumn";
            // 
            // colreservistaDataGridViewTextBoxColumn
            // 
            this.colreservistaDataGridViewTextBoxColumn.DataPropertyName = "col_reservista";
            this.colreservistaDataGridViewTextBoxColumn.HeaderText = "col_reservista";
            this.colreservistaDataGridViewTextBoxColumn.Name = "colreservistaDataGridViewTextBoxColumn";
            // 
            // colestcivilDataGridViewTextBoxColumn
            // 
            this.colestcivilDataGridViewTextBoxColumn.DataPropertyName = "col_est_civil";
            this.colestcivilDataGridViewTextBoxColumn.HeaderText = "col_est_civil";
            this.colestcivilDataGridViewTextBoxColumn.Name = "colestcivilDataGridViewTextBoxColumn";
            // 
            // colnumdepDataGridViewTextBoxColumn
            // 
            this.colnumdepDataGridViewTextBoxColumn.DataPropertyName = "col_num_dep";
            this.colnumdepDataGridViewTextBoxColumn.HeaderText = "col_num_dep";
            this.colnumdepDataGridViewTextBoxColumn.Name = "colnumdepDataGridViewTextBoxColumn";
            // 
            // colativoDataGridViewTextBoxColumn
            // 
            this.colativoDataGridViewTextBoxColumn.DataPropertyName = "col_ativo";
            this.colativoDataGridViewTextBoxColumn.HeaderText = "col_ativo";
            this.colativoDataGridViewTextBoxColumn.Name = "colativoDataGridViewTextBoxColumn";
            // 
            // colsetorDataGridViewTextBoxColumn
            // 
            this.colsetorDataGridViewTextBoxColumn.DataPropertyName = "col_setor";
            this.colsetorDataGridViewTextBoxColumn.HeaderText = "col_setor";
            this.colsetorDataGridViewTextBoxColumn.Name = "colsetorDataGridViewTextBoxColumn";
            // 
            // colcargoDataGridViewTextBoxColumn
            // 
            this.colcargoDataGridViewTextBoxColumn.DataPropertyName = "col_cargo";
            this.colcargoDataGridViewTextBoxColumn.HeaderText = "col_cargo";
            this.colcargoDataGridViewTextBoxColumn.Name = "colcargoDataGridViewTextBoxColumn";
            // 
            // colsalarioDataGridViewTextBoxColumn
            // 
            this.colsalarioDataGridViewTextBoxColumn.DataPropertyName = "col_salario";
            this.colsalarioDataGridViewTextBoxColumn.HeaderText = "col_salario";
            this.colsalarioDataGridViewTextBoxColumn.Name = "colsalarioDataGridViewTextBoxColumn";
            // 
            // colfone1DataGridViewTextBoxColumn
            // 
            this.colfone1DataGridViewTextBoxColumn.DataPropertyName = "col_fone1";
            this.colfone1DataGridViewTextBoxColumn.HeaderText = "col_fone1";
            this.colfone1DataGridViewTextBoxColumn.Name = "colfone1DataGridViewTextBoxColumn";
            // 
            // colfone2DataGridViewTextBoxColumn
            // 
            this.colfone2DataGridViewTextBoxColumn.DataPropertyName = "col_fone2";
            this.colfone2DataGridViewTextBoxColumn.HeaderText = "col_fone2";
            this.colfone2DataGridViewTextBoxColumn.Name = "colfone2DataGridViewTextBoxColumn";
            // 
            // colemailPesDataGridViewTextBoxColumn
            // 
            this.colemailPesDataGridViewTextBoxColumn.DataPropertyName = "col_email_Pes";
            this.colemailPesDataGridViewTextBoxColumn.HeaderText = "col_email_Pes";
            this.colemailPesDataGridViewTextBoxColumn.Name = "colemailPesDataGridViewTextBoxColumn";
            // 
            // colemailcorpDataGridViewTextBoxColumn
            // 
            this.colemailcorpDataGridViewTextBoxColumn.DataPropertyName = "col_email_corp";
            this.colemailcorpDataGridViewTextBoxColumn.HeaderText = "col_email_corp";
            this.colemailcorpDataGridViewTextBoxColumn.Name = "colemailcorpDataGridViewTextBoxColumn";
            // 
            // colaboradorBindingSource
            // 
            this.colaboradorBindingSource.DataMember = "colaborador";
            this.colaboradorBindingSource.DataSource = this.colabDataSet;
            // 
            // colabDataSet
            // 
            this.colabDataSet.DataSetName = "colabDataSet";
            this.colabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradorTableAdapter
            // 
            this.colaboradorTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CTPS";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(111, 416);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 31);
            this.button5.TabIndex = 8;
            this.button5.Text = "Alterar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmPesquisaColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 484);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisaColaborador";
            this.Load += new System.EventHandler(this.frmPesquisaColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private colabDataSetTableAdapters.colaboradorTableAdapter colaboradorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colctpsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltiteleitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colreservistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colestcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumdepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsetorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsalarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemailPesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemailcorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}