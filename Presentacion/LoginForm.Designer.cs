using Microsoft.VisualBasic.Logging;

namespace Presentacion
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            picbox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblLoginTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)picbox1).BeginInit();
            SuspendLayout();
            // 
            // picbox1
            // 
            picbox1.CustomizableEdges = customizableEdges1;
            picbox1.Image = Properties.Resources.Richie_2;
            picbox1.ImageRotate = 0F;
            picbox1.Location = new Point(50, 54);
            picbox1.Margin = new Padding(3, 2, 3, 2);
            picbox1.Name = "picbox1";
            picbox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picbox1.Size = new Size(409, 605);
            picbox1.SizeMode = PictureBoxSizeMode.Zoom;
            picbox1.TabIndex = 0;
            picbox1.TabStop = false;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = false;
            lblLoginTitle.BackColor = Color.Transparent;
            lblLoginTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.ForeColor = Color.FromArgb(62, 62, 62);
            lblLoginTitle.Location = new Point(251, 86);
            lblLoginTitle.Margin = new Padding(3, 2, 3, 2);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(332, 36);
            lblLoginTitle.TabIndex = 1;
            lblLoginTitle.Text = "Bienvenid@ de Nuevo!";
            lblLoginTitle.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Animated = true;
            txtUsuario.AutoRoundedCorners = true;
            txtUsuario.BorderColor = SystemColors.ControlDark;
            txtUsuario.BorderRadius = 35;
            txtUsuario.BorderThickness = 2;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.CustomizableEdges = customizableEdges3;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.IconLeftOffset = new Point(5, 0);
            txtUsuario.Location = new Point(251, 162);
            txtUsuario.Margin = new Padding(8, 9, 8, 9);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderForeColor = SystemColors.ControlDarkDark;
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsuario.Size = new Size(332, 72);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Animated = true;
            txtPassword.AutoRoundedCorners = true;
            txtPassword.BorderColor = SystemColors.ControlDark;
            txtPassword.BorderRadius = 35;
            txtPassword.BorderThickness = 2;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeftOffset = new Point(5, 0);
            txtPassword.Location = new Point(251, 252);
            txtPassword.Margin = new Padding(8, 9, 8, 9);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderForeColor = SystemColors.ControlDarkDark;
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(332, 72);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Animated = true;
            btnLogin.AutoRoundedCorners = true;
            btnLogin.BorderRadius = 35;
            btnLogin.CustomizableEdges = customizableEdges7;
            btnLogin.FillColor = Color.FromArgb(243, 60, 40);
            btnLogin.FillColor2 = Color.FromArgb(255, 188, 44);
            btnLogin.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(322, 382);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnLogin.Size = new Size(191, 72);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(663, 632);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblLoginTitle);
            Controls.Add(picbox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)picbox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picbox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoginTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
    }

}    
