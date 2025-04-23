using System.Drawing;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace CapaPresentacion
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
            this.components = new System.ComponentModel.Container();
            this.lblReportesMesTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnVerInforme = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbMeses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.imgVolver = new System.Windows.Forms.PictureBox();
            this.picbox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportesMesTitle
            // 
            this.lblReportesMesTitle.AutoSize = false;
            this.lblReportesMesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblReportesMesTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportesMesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.lblReportesMesTitle.Location = new System.Drawing.Point(167, 55);
            this.lblReportesMesTitle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lblReportesMesTitle.Name = "lblReportesMesTitle";
            this.lblReportesMesTitle.Size = new System.Drawing.Size(248, 23);
            this.lblReportesMesTitle.TabIndex = 1;
            this.lblReportesMesTitle.Text = "Reportes Mensuales";
            this.lblReportesMesTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Animated = true;
            this.btnVerInforme.AutoRoundedCorners = true;
            this.btnVerInforme.BorderRadius = 15;
            this.btnVerInforme.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerInforme.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVerInforme.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInforme.ForeColor = System.Drawing.Color.White;
            this.btnVerInforme.Location = new System.Drawing.Point(192, 194);
            this.btnVerInforme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(200, 32);
            this.btnVerInforme.TabIndex = 4;
            this.btnVerInforme.Text = "Ver Informe";
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // cbMeses
            // 
            this.cbMeses.BackColor = System.Drawing.Color.Transparent;
            this.cbMeses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMeses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMeses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMeses.ItemHeight = 30;
            this.cbMeses.Location = new System.Drawing.Point(225, 124);
            this.cbMeses.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(132, 36);
            this.cbMeses.TabIndex = 10;
            // 
            // imgVolver
            // 
            this.imgVolver.Image = global::CapaPresentacion.Properties.Resources.ic_volver;
            this.imgVolver.Location = new System.Drawing.Point(9, 8);
            this.imgVolver.Margin = new System.Windows.Forms.Padding(2);
            this.imgVolver.Name = "imgVolver";
            this.imgVolver.Size = new System.Drawing.Size(35, 25);
            this.imgVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVolver.TabIndex = 14;
            this.imgVolver.TabStop = false;
            this.imgVolver.Click += new System.EventHandler(this.imgVolver_Click);
            // 
            // picbox1
            // 
            this.picbox1.Image = global::CapaPresentacion.Properties.Resources.Richie_2;
            this.picbox1.ImageRotate = 0F;
            this.picbox1.Location = new System.Drawing.Point(58, 8);
            this.picbox1.Margin = new System.Windows.Forms.Padding(2);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(307, 393);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox1.TabIndex = 15;
            this.picbox1.TabStop = false;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 394);
            this.Controls.Add(this.imgVolver);
            this.Controls.Add(this.cbMeses);
            this.Controls.Add(this.btnVerInforme);
            this.Controls.Add(this.lblReportesMesTitle);
            this.Controls.Add(this.picbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 433);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 433);
            this.Name = "ReportesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Mensuales";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);

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