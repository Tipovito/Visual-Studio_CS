﻿namespace Projetinho_Splash
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
            this.juridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colabDataSet = new Projetinho_Splash.colabDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jurCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurInsEstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurfundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.juridicaTableAdapter = new Projetinho_Splash.colabDataSetTableAdapters.juridicaTableAdapter();
            this.Deletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.juridicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.juridicaBindingSource, "jur_CD", true));
            this.textBox1.Location = new System.Drawing.Point(146, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // juridicaBindingSource
            // 
            this.juridicaBindingSource.DataMember = "juridica";
            this.juridicaBindingSource.DataSource = this.colabDataSet;
            // 
            // colabDataSet
            // 
            this.colabDataSet.DataSetName = "colabDataSet";
            this.colabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button1.Location = new System.Drawing.Point(307, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 400);
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
            this.dataGridView1.Size = new System.Drawing.Size(442, 135);
            this.dataGridView1.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.juridicaBindingSource, "jur_CNPJ", true));
            this.textBox2.Location = new System.Drawing.Point(146, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // juridicaTableAdapter
            // 
            this.juridicaTableAdapter.ClearBeforeFill = true;
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(215, 400);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 30);
            this.Deletar.TabIndex = 8;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // frmPesquisaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 484);
            this.Controls.Add(this.Deletar);
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
            this.Name = "frmPesquisaJuridica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisaJuridica";
            this.Load += new System.EventHandler(this.frmPesquisaJuridica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.juridicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private colabDataSet colabDataSet;
        private System.Windows.Forms.BindingSource juridicaBindingSource;
        private colabDataSetTableAdapters.juridicaTableAdapter juridicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurInsEstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurfundDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Deletar;
    }
}