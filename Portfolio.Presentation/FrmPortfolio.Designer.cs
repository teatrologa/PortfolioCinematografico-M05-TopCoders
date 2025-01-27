﻿namespace Portfolio.Presentation
{
    partial class FrmPortfolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPortfolio));
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.pnlMenuPanel = new System.Windows.Forms.Panel();
            this.btnNewSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblPortfolioTitle = new System.Windows.Forms.Label();
            this.pnlPortfolioLV = new System.Windows.Forms.Panel();
            this.lvwPortfolio = new System.Windows.Forms.ListView();
            this.clnMovieTitle = new System.Windows.Forms.ColumnHeader();
            this.clnScore = new System.Windows.Forms.ColumnHeader();
            this.clnComments = new System.Windows.Forms.ColumnHeader();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlSubMenu.SuspendLayout();
            this.pnlMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlPortfolioLV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo.BackgroundImage")));
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Location = new System.Drawing.Point(0, 10);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(135, 35);
            this.btnLogo.TabIndex = 8;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.Location = new System.Drawing.Point(0, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(135, 33);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAbout.Location = new System.Drawing.Point(0, 79);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(135, 33);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "Sobre";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLogOut.Location = new System.Drawing.Point(0, 46);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(135, 33);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Desconectar";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyAccount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyAccount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMyAccount.Location = new System.Drawing.Point(0, 13);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMyAccount.Size = new System.Drawing.Size(135, 33);
            this.btnMyAccount.TabIndex = 10;
            this.btnMyAccount.Text = "Minha Conta";
            this.btnMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyAccount.UseVisualStyleBackColor = true;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlSubMenu.Controls.Add(this.btnExit);
            this.pnlSubMenu.Controls.Add(this.btnAbout);
            this.pnlSubMenu.Controls.Add(this.btnLogOut);
            this.pnlSubMenu.Controls.Add(this.btnMyAccount);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 45);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.pnlSubMenu.Size = new System.Drawing.Size(135, 157);
            this.pnlSubMenu.TabIndex = 9;
            // 
            // pnlMenuPanel
            // 
            this.pnlMenuPanel.AutoScroll = true;
            this.pnlMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuPanel.Controls.Add(this.pnlSubMenu);
            this.pnlMenuPanel.Controls.Add(this.btnLogo);
            this.pnlMenuPanel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMenuPanel.Location = new System.Drawing.Point(917, 3);
            this.pnlMenuPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenuPanel.Name = "pnlMenuPanel";
            this.pnlMenuPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlMenuPanel.Size = new System.Drawing.Size(135, 229);
            this.pnlMenuPanel.TabIndex = 7;
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSearch.FlatAppearance.BorderSize = 0;
            this.btnNewSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.btnNewSearch.Location = new System.Drawing.Point(775, 8);
            this.btnNewSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(132, 45);
            this.btnNewSearch.TabIndex = 6;
            this.btnNewSearch.Text = "Buscar";
            this.btnNewSearch.UseVisualStyleBackColor = false;
            this.btnNewSearch.Click += new System.EventHandler(this.btnNewSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.btnHome.Location = new System.Drawing.Point(636, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(133, 45);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLogo.Image = global::Portfolio.Presentation.Properties.Resources.logotipo_do_filme_10250_3708_1_;
            this.ptbLogo.Location = new System.Drawing.Point(12, 8);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(52, 45);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 8;
            this.ptbLogo.TabStop = false;
            // 
            // lblPortfolioTitle
            // 
            this.lblPortfolioTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPortfolioTitle.Font = new System.Drawing.Font("Georgia", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPortfolioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblPortfolioTitle.Location = new System.Drawing.Point(338, 166);
            this.lblPortfolioTitle.Name = "lblPortfolioTitle";
            this.lblPortfolioTitle.Size = new System.Drawing.Size(388, 39);
            this.lblPortfolioTitle.TabIndex = 8;
            this.lblPortfolioTitle.Text = "Portfólio Cinematográfico";
            this.lblPortfolioTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPortfolioLV
            // 
            this.pnlPortfolioLV.BackColor = System.Drawing.Color.White;
            this.pnlPortfolioLV.Controls.Add(this.lvwPortfolio);
            this.pnlPortfolioLV.Location = new System.Drawing.Point(179, 267);
            this.pnlPortfolioLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPortfolioLV.Name = "pnlPortfolioLV";
            this.pnlPortfolioLV.Size = new System.Drawing.Size(706, 285);
            this.pnlPortfolioLV.TabIndex = 2;
            // 
            // lvwPortfolio
            // 
            this.lvwPortfolio.BackColor = System.Drawing.Color.White;
            this.lvwPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwPortfolio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMovieTitle,
            this.clnScore,
            this.clnComments});
            this.lvwPortfolio.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvwPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.lvwPortfolio.FullRowSelect = true;
            this.lvwPortfolio.GridLines = true;
            this.lvwPortfolio.Location = new System.Drawing.Point(16, 11);
            this.lvwPortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwPortfolio.MultiSelect = false;
            this.lvwPortfolio.Name = "lvwPortfolio";
            this.lvwPortfolio.Size = new System.Drawing.Size(674, 260);
            this.lvwPortfolio.TabIndex = 0;
            this.lvwPortfolio.UseCompatibleStateImageBehavior = false;
            this.lvwPortfolio.View = System.Windows.Forms.View.Details;
            // 
            // clnMovieTitle
            // 
            this.clnMovieTitle.Text = "Título do Filme";
            this.clnMovieTitle.Width = 300;
            // 
            // clnScore
            // 
            this.clnScore.Text = "Nota";
            this.clnScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnScore.Width = 80;
            // 
            // clnComments
            // 
            this.clnComments.Text = "Comentários";
            this.clnComments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnComments.Width = 250;
            // 
            // btnAZ
            // 
            this.btnAZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.btnAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAZ.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAZ.ForeColor = System.Drawing.Color.White;
            this.btnAZ.Location = new System.Drawing.Point(176, 236);
            this.btnAZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(82, 23);
            this.btnAZ.TabIndex = 0;
            this.btnAZ.Text = "A - Z";
            this.btnAZ.UseVisualStyleBackColor = false;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.Location = new System.Drawing.Point(264, 236);
            this.btnScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(204, 23);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Melhores Avaliações";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(754, 563);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Ver | Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(648, 563);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portfolio.Presentation.Properties.Resources._5___Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnAZ);
            this.Controls.Add(this.pnlPortfolioLV);
            this.Controls.Add(this.lblPortfolioTitle);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnNewSearch);
            this.Controls.Add(this.pnlMenuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPortfolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPortfolio";
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlPortfolioLV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLogo;
        private Button btnExit;
        private Button btnAbout;
        private Button btnLogOut;
        private Button btnMyAccount;
        private Panel pnlSubMenu;
        private Panel pnlMenuPanel;
        private Button btnNewSearch;
        private Button btnHome;
        private PictureBox ptbLogo;
        private Label lblPortfolioTitle;
        private Panel pnlPortfolioLV;
        private ListView lvwPortfolio;
        private ColumnHeader clnMovieTitle;
        private ColumnHeader clnScore;
        private ColumnHeader clnComments;
        private Button btnAZ;
        private Button btnScore;
        private Button btnEdit;
        private Button btnDelete;
    }
}