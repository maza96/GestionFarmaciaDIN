using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class MenuForm
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
            this.picbox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblLoginTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnReportes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnVenta = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMedicamentos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnProveedores = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEmpleados = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox1
            // 
            this.picbox1.Image = global::CapaPresentacion.Properties.Resources.Richie_2;
            this.picbox1.ImageRotate = 0F;
            this.picbox1.Location = new System.Drawing.Point(50, 42);
            this.picbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(409, 484);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = false;
            this.lblLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(99, 42);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(483, 55);
            this.lblLoginTitle.TabIndex = 1;
            this.lblLoginTitle.Text = "Menú Principal";
            this.lblLoginTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReportes
            // 
            this.btnReportes.Animated = true;
            this.btnReportes.AutoRoundedCorners = true;
            this.btnReportes.BorderRadius = 18;
            this.btnReportes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReportes.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(295, 119);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(267, 39);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Animated = true;
            this.btnVenta.AutoRoundedCorners = true;
            this.btnVenta.BorderRadius = 18;
            this.btnVenta.FillColor = System.Drawing.Color.Green;
            this.btnVenta.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Location = new System.Drawing.Point(295, 177);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(267, 39);
            this.btnVenta.TabIndex = 5;
            this.btnVenta.Text = "Venta";
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.Animated = true;
            this.btnMedicamentos.AutoRoundedCorners = true;
            this.btnMedicamentos.BorderRadius = 18;
            this.btnMedicamentos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMedicamentos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMedicamentos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamentos.ForeColor = System.Drawing.Color.White;
            this.btnMedicamentos.Location = new System.Drawing.Point(295, 239);
            this.btnMedicamentos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(267, 39);
            this.btnMedicamentos.TabIndex = 6;
            this.btnMedicamentos.Text = "Medicamentos";
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Animated = true;
            this.btnProveedores.AutoRoundedCorners = true;
            this.btnProveedores.BorderRadius = 18;
            this.btnProveedores.FillColor = System.Drawing.Color.Blue;
            this.btnProveedores.FillColor2 = System.Drawing.Color.Navy;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(295, 298);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(267, 39);
            this.btnProveedores.TabIndex = 7;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Animated = true;
            this.btnEmpleados.AutoRoundedCorners = true;
            this.btnEmpleados.BorderRadius = 18;
            this.btnEmpleados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmpleados.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(295, 358);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(267, 39);
            this.btnEmpleados.TabIndex = 8;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(617, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(34, 28);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 506);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnMedicamentos);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.picbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(681, 553);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(681, 553);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picbox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoginTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnReportes;
        private Guna.UI2.WinForms.Guna2GradientButton btnVenta;
        private Guna.UI2.WinForms.Guna2GradientButton btnMedicamentos;
        private Guna.UI2.WinForms.Guna2GradientButton btnProveedores;
        private Guna.UI2.WinForms.Guna2GradientButton btnEmpleados;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Button btnLogout;
    }
}