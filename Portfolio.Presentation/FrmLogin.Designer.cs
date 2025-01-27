﻿namespace Portfolio.Presentation
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lklAbout = new System.Windows.Forms.LinkLabel();
            this.lklExit = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblCallNewUser = new System.Windows.Forms.Label();
            this.lklNewAccount = new System.Windows.Forms.LinkLabel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.lblUsernameGreeting = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.pbxLoad = new System.Windows.Forms.PictureBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = global::Portfolio.Presentation.Properties.Resources.logotipo_do_filme_10250_3708_1_;
            this.pbxLogo.Location = new System.Drawing.Point(838, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(186, 172);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 6;
            this.pbxLogo.TabStop = false;
            // 
            // lklAbout
            // 
            this.lklAbout.AutoSize = true;
            this.lklAbout.BackColor = System.Drawing.Color.Transparent;
            this.lklAbout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lklAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lklAbout.Location = new System.Drawing.Point(815, 622);
            this.lklAbout.Name = "lklAbout";
            this.lklAbout.Size = new System.Drawing.Size(147, 18);
            this.lklAbout.TabIndex = 0;
            this.lklAbout.TabStop = true;
            this.lklAbout.Text = "Sobre o Projeto";
            this.lklAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklAbout_LinkClicked);
            // 
            // lklExit
            // 
            this.lklExit.AutoSize = true;
            this.lklExit.BackColor = System.Drawing.Color.Transparent;
            this.lklExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lklExit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lklExit.Location = new System.Drawing.Point(982, 622);
            this.lklExit.Name = "lklExit";
            this.lklExit.Size = new System.Drawing.Size(42, 18);
            this.lklExit.TabIndex = 1;
            this.lklExit.TabStop = true;
            this.lklExit.Text = "Sair";
            this.lklExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklExit_LinkClicked);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblPassword.Location = new System.Drawing.Point(15, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Senha";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblUsername.Location = new System.Drawing.Point(15, 59);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(147, 18);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nome de usuário";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.txbPassword.Location = new System.Drawing.Point(15, 156);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(400, 24);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnLogin.Location = new System.Drawing.Point(15, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.txbUsername.Location = new System.Drawing.Point(15, 85);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(400, 24);
            this.txbUsername.TabIndex = 0;
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            // 
            // lblCallNewUser
            // 
            this.lblCallNewUser.AutoSize = true;
            this.lblCallNewUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCallNewUser.ForeColor = System.Drawing.Color.Teal;
            this.lblCallNewUser.Location = new System.Drawing.Point(85, 272);
            this.lblCallNewUser.Name = "lblCallNewUser";
            this.lblCallNewUser.Size = new System.Drawing.Size(131, 18);
            this.lblCallNewUser.TabIndex = 5;
            this.lblCallNewUser.Text = "Novo por aqui?";
            // 
            // lklNewAccount
            // 
            this.lklNewAccount.AutoSize = true;
            this.lklNewAccount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lklNewAccount.LinkColor = System.Drawing.Color.Teal;
            this.lklNewAccount.Location = new System.Drawing.Point(212, 272);
            this.lklNewAccount.Name = "lklNewAccount";
            this.lklNewAccount.Size = new System.Drawing.Size(132, 18);
            this.lklNewAccount.TabIndex = 3;
            this.lklNewAccount.TabStop = true;
            this.lklNewAccount.Text = "Crie sua conta!";
            this.lklNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklNewAccount_LinkClicked);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.lklNewAccount);
            this.pnlLogin.Controls.Add(this.lblCallNewUser);
            this.pnlLogin.Controls.Add(this.txbUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txbPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Location = new System.Drawing.Point(594, 190);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(430, 315);
            this.pnlLogin.TabIndex = 0;
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLoad.Controls.Add(this.lblUsernameGreeting);
            this.pnlLoad.Controls.Add(this.lblLoad);
            this.pnlLoad.Controls.Add(this.pbxLoad);
            this.pnlLoad.Controls.Add(this.lblGreeting);
            this.pnlLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(119)))), ((int)(((byte)(122)))));
            this.pnlLoad.Location = new System.Drawing.Point(594, 190);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(430, 315);
            this.pnlLoad.TabIndex = 3;
            this.pnlLoad.Visible = false;
            // 
            // lblUsernameGreeting
            // 
            this.lblUsernameGreeting.AutoSize = true;
            this.lblUsernameGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameGreeting.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsernameGreeting.ForeColor = System.Drawing.Color.Teal;
            this.lblUsernameGreeting.Location = new System.Drawing.Point(24, 42);
            this.lblUsernameGreeting.Name = "lblUsernameGreeting";
            this.lblUsernameGreeting.Size = new System.Drawing.Size(110, 23);
            this.lblUsernameGreeting.TabIndex = 1;
            this.lblUsernameGreeting.Text = "username!";
            this.lblUsernameGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblLoad.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoad.ForeColor = System.Drawing.Color.Teal;
            this.lblLoad.Location = new System.Drawing.Point(24, 73);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(316, 23);
            this.lblLoad.TabIndex = 2;
            this.lblLoad.Text = "Seu portfólio está carregando...";
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxLoad
            // 
            this.pbxLoad.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoad.Image")));
            this.pbxLoad.Location = new System.Drawing.Point(24, 115);
            this.pbxLoad.Name = "pbxLoad";
            this.pbxLoad.Size = new System.Drawing.Size(191, 187);
            this.pbxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLoad.TabIndex = 12;
            this.pbxLoad.TabStop = false;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.ForeColor = System.Drawing.Color.Teal;
            this.lblGreeting.Location = new System.Drawing.Point(24, 19);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(49, 23);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Olá,";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::Portfolio.Presentation.Properties.Resources.loginScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.lklExit);
            this.Controls.Add(this.lklAbout);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pnlLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlLoad.ResumeLayout(false);
            this.pnlLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pbxLogo;
        private LinkLabel lklAbout;
        private LinkLabel lklExit;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txbPassword;
        private Button btnLogin;
        private TextBox txbUsername;
        private Label lblCallNewUser;
        private LinkLabel lklNewAccount;
        private Panel pnlLogin;
        private Panel pnlLoad;
        private Label lblGreeting;
        private Label lblLoad;
        private PictureBox pbxLoad;
        private Label lblUsernameGreeting;
    }
}