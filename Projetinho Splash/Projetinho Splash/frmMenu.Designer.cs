namespace Projetinho_Splash
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadPessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadFisícaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadJurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadParceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaJurídicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaParceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pesquisaFísicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.pesToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadPessoasToolStripMenuItem,
            this.cadColaboradorToolStripMenuItem,
            this.cadFisícaToolStripMenuItem,
            this.cadJurToolStripMenuItem,
            this.cadParceiroToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadPessoasToolStripMenuItem
            // 
            this.cadPessoasToolStripMenuItem.Name = "cadPessoasToolStripMenuItem";
            this.cadPessoasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadPessoasToolStripMenuItem.Text = "Cad Pessoas";
            this.cadPessoasToolStripMenuItem.Click += new System.EventHandler(this.cadPessoasToolStripMenuItem_Click);
            // 
            // cadColaboradorToolStripMenuItem
            // 
            this.cadColaboradorToolStripMenuItem.Name = "cadColaboradorToolStripMenuItem";
            this.cadColaboradorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadColaboradorToolStripMenuItem.Text = "Cad Colaborador";
            this.cadColaboradorToolStripMenuItem.Click += new System.EventHandler(this.cadColaboradorToolStripMenuItem_Click);
            // 
            // cadFisícaToolStripMenuItem
            // 
            this.cadFisícaToolStripMenuItem.Name = "cadFisícaToolStripMenuItem";
            this.cadFisícaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadFisícaToolStripMenuItem.Text = "Cad Fisíca";
            this.cadFisícaToolStripMenuItem.Click += new System.EventHandler(this.cadFisícaToolStripMenuItem_Click);
            // 
            // cadJurToolStripMenuItem
            // 
            this.cadJurToolStripMenuItem.Name = "cadJurToolStripMenuItem";
            this.cadJurToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadJurToolStripMenuItem.Text = "Cad Jurídiica";
            this.cadJurToolStripMenuItem.Click += new System.EventHandler(this.cadJurToolStripMenuItem_Click);
            // 
            // cadParceiroToolStripMenuItem
            // 
            this.cadParceiroToolStripMenuItem.Name = "cadParceiroToolStripMenuItem";
            this.cadParceiroToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadParceiroToolStripMenuItem.Text = "Cad Parceiro";
            this.cadParceiroToolStripMenuItem.Click += new System.EventHandler(this.cadParceiroToolStripMenuItem_Click);
            // 
            // pesToolStripMenuItem
            // 
            this.pesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisaPessoaToolStripMenuItem,
            this.pesquisaFísicaToolStripMenuItem,
            this.pesquisaJurídicaToolStripMenuItem,
            this.pesquisaParceiroToolStripMenuItem,
            this.pesquisaColaboradorToolStripMenuItem});
            this.pesToolStripMenuItem.Name = "pesToolStripMenuItem";
            this.pesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.pesToolStripMenuItem.Text = "Pesquisas";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pesquisaPessoaToolStripMenuItem
            // 
            this.pesquisaPessoaToolStripMenuItem.Name = "pesquisaPessoaToolStripMenuItem";
            this.pesquisaPessoaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.pesquisaPessoaToolStripMenuItem.Text = "Pesquisa Pessoa";
            this.pesquisaPessoaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaPessoaToolStripMenuItem_Click);
            // 
            // pesquisaJurídicaToolStripMenuItem
            // 
            this.pesquisaJurídicaToolStripMenuItem.Name = "pesquisaJurídicaToolStripMenuItem";
            this.pesquisaJurídicaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.pesquisaJurídicaToolStripMenuItem.Text = "Pesquisa Jurídica";
            this.pesquisaJurídicaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaJurídicaToolStripMenuItem_Click);
            // 
            // pesquisaColaboradorToolStripMenuItem
            // 
            this.pesquisaColaboradorToolStripMenuItem.Name = "pesquisaColaboradorToolStripMenuItem";
            this.pesquisaColaboradorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.pesquisaColaboradorToolStripMenuItem.Text = "Pesquisa Colaborador";
            this.pesquisaColaboradorToolStripMenuItem.Click += new System.EventHandler(this.pesquisaColaboradorToolStripMenuItem_Click);
            // 
            // pesquisaParceiroToolStripMenuItem
            // 
            this.pesquisaParceiroToolStripMenuItem.Name = "pesquisaParceiroToolStripMenuItem";
            this.pesquisaParceiroToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.pesquisaParceiroToolStripMenuItem.Text = "Pesquisa Parceiro";
            this.pesquisaParceiroToolStripMenuItem.Click += new System.EventHandler(this.pesquisaParceiroToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Projetinho_Splash.Properties.Resources.carro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pesquisaFísicaToolStripMenuItem
            // 
            this.pesquisaFísicaToolStripMenuItem.Name = "pesquisaFísicaToolStripMenuItem";
            this.pesquisaFísicaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.pesquisaFísicaToolStripMenuItem.Text = "Pesquisa Física";
            this.pesquisaFísicaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaFísicaToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadPessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadFisícaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadJurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadParceiroToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem pesquisaPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaJurídicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaParceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaFísicaToolStripMenuItem;
    }
}