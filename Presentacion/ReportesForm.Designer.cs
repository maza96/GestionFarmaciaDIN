using System.Drawing;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace Presentacion
{
    partial class ReportesForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblReportesMesTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnVerInforme = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            cbMeses = new Guna.UI2.WinForms.Guna2ComboBox();
            imgVolver = new PictureBox();
            picbox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox1).BeginInit();
            SuspendLayout();
            // 
            // lblReportesMesTitle
            // 
            lblReportesMesTitle.AutoSize = false;
            lblReportesMesTitle.BackColor = Color.Transparent;
            lblReportesMesTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportesMesTitle.ForeColor = Color.FromArgb(62, 62, 62);
            lblReportesMesTitle.Location = new Point(223, 85);
            lblReportesMesTitle.Margin = new Padding(3, 2, 3, 2);
            lblReportesMesTitle.Name = "lblReportesMesTitle";
            lblReportesMesTitle.Size = new Size(331, 36);
            lblReportesMesTitle.TabIndex = 1;
            lblReportesMesTitle.Text = "Reportes Mensuales";
            lblReportesMesTitle.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnVerInforme
            // 
            btnVerInforme.Animated = true;
            btnVerInforme.AutoRoundedCorners = true;
            btnVerInforme.BorderRadius = 23;
            btnVerInforme.CustomizableEdges = customizableEdges1;
            btnVerInforme.FillColor = Color.FromArgb(255, 128, 0);
            btnVerInforme.FillColor2 = Color.FromArgb(128, 64, 0);
            btnVerInforme.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerInforme.ForeColor = Color.White;
            btnVerInforme.Location = new Point(256, 298);
            btnVerInforme.Margin = new Padding(5);
            btnVerInforme.Name = "btnVerInforme";
            btnVerInforme.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnVerInforme.Size = new Size(267, 49);
            btnVerInforme.TabIndex = 4;
            btnVerInforme.Text = "Ver Informe";
            // 
            // cbMeses
            // 
            cbMeses.BackColor = Color.Transparent;
            cbMeses.CustomizableEdges = customizableEdges3;
            cbMeses.DrawMode = DrawMode.OwnerDrawFixed;
            cbMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMeses.FocusedColor = Color.FromArgb(94, 148, 255);
            cbMeses.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbMeses.Font = new Font("Segoe UI", 10F);
            cbMeses.ForeColor = Color.FromArgb(68, 88, 112);
            cbMeses.ItemHeight = 30;
            cbMeses.Location = new Point(300, 191);
            cbMeses.Margin = new Padding(3, 2, 3, 2);
            cbMeses.Name = "cbMeses";
            cbMeses.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbMeses.Size = new Size(175, 36);
            cbMeses.TabIndex = 10;
            // 
            // imgVolver
            // 
            imgVolver.Image = Properties.Resources.ic_volver;
            imgVolver.Location = new Point(12, 12);
            imgVolver.Name = "imgVolver";
            imgVolver.Size = new Size(47, 39);
            imgVolver.SizeMode = PictureBoxSizeMode.Zoom;
            imgVolver.TabIndex = 14;
            imgVolver.TabStop = false;
            imgVolver.Click += imgVolver_Click;
            // 
            // picbox1
            // 
            picbox1.CustomizableEdges = customizableEdges5;
            picbox1.Image = Properties.Resources.Richie_2;
            picbox1.ImageRotate = 0F;
            picbox1.Location = new Point(77, 12);
            picbox1.Name = "picbox1";
            picbox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            picbox1.Size = new Size(409, 605);
            picbox1.SizeMode = PictureBoxSizeMode.Zoom;
            picbox1.TabIndex = 15;
            picbox1.TabStop = false;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(583, 598);
            Controls.Add(imgVolver);
            Controls.Add(cbMeses);
            Controls.Add(btnVerInforme);
            Controls.Add(lblReportesMesTitle);
            Controls.Add(picbox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(601, 645);
            MinimizeBox = false;
            MinimumSize = new Size(601, 645);
            Name = "ReportesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes Mensuales";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)imgVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReportesMesTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnVerInforme;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cbMeses;
        private PictureBox imgVolver;
        private Guna.UI2.WinForms.Guna2PictureBox picbox1;
    }
}