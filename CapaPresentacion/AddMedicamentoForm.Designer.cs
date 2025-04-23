using System;
using System.Drawing;
using System.Windows.Forms;

namespace Farmacia
{
    partial class AddMedicamentoForm
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



        private GroupBox gbDatosNuevoMedicamento;
        private TextBox txtTitle;
        private Label lblNombre;
        private TextBox txtDesc;
        private Label lblDesc;
        private TextBox txtNombre;
        private NumericUpDown numCant;
        private Label lblCant;
        private Label lblCosto;
        private DateTimePicker dtVencimiento;
        private Label lblVencimiento;
        private Label lblControl;
        private RadioButton rbControl;
        private TextBox txtCosto;
        private Button imgAgregar;
        private Button btnAgregar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button imgNuevo;
        private Button imgEliminar;
        private Button imgActualizar;
        private GroupBox gbMedicamentos;
        private DataGridView dgMedicamentos;

        private void InitializeComponent()
        {
            this.gbDatosNuevoMedicamento = new System.Windows.Forms.GroupBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.dtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            this.rbControl = new System.Windows.Forms.RadioButton();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.imgActualizar = new System.Windows.Forms.Button();
            this.imgEliminar = new System.Windows.Forms.Button();
            this.imgNuevo = new System.Windows.Forms.Button();
            this.imgAgregar = new System.Windows.Forms.Button();
            this.gbMedicamentos = new System.Windows.Forms.GroupBox();
            this.dgMedicamentos = new System.Windows.Forms.DataGridView();
            this.imgVolver = new System.Windows.Forms.PictureBox();
            this.gbDatosNuevoMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            this.gbMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosNuevoMedicamento
            // 
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblProveedor);
            this.gbDatosNuevoMedicamento.Controls.Add(this.cbProveedores);
            this.gbDatosNuevoMedicamento.Controls.Add(this.txtCosto);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblCosto);
            this.gbDatosNuevoMedicamento.Controls.Add(this.dtVencimiento);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblVencimiento);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblControl);
            this.gbDatosNuevoMedicamento.Controls.Add(this.rbControl);
            this.gbDatosNuevoMedicamento.Controls.Add(this.numCant);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblCant);
            this.gbDatosNuevoMedicamento.Controls.Add(this.txtDesc);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblDesc);
            this.gbDatosNuevoMedicamento.Controls.Add(this.txtNombre);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblNombre);
            this.gbDatosNuevoMedicamento.Location = new System.Drawing.Point(59, 143);
            this.gbDatosNuevoMedicamento.Name = "gbDatosNuevoMedicamento";
            this.gbDatosNuevoMedicamento.Size = new System.Drawing.Size(729, 366);
            this.gbDatosNuevoMedicamento.TabIndex = 0;
            this.gbDatosNuevoMedicamento.TabStop = false;
            this.gbDatosNuevoMedicamento.Text = "Datos";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(25, 321);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(78, 17);
            this.lblProveedor.TabIndex = 13;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cbProveedores
            // 
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.Location = new System.Drawing.Point(247, 311);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(229, 21);
            this.cbProveedores.TabIndex = 1;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(474, 247);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(179, 20);
            this.txtCosto.TabIndex = 12;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(408, 247);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(48, 17);
            this.lblCosto.TabIndex = 11;
            this.lblCosto.Text = "Costo:";
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimiento.Location = new System.Drawing.Point(247, 247);
            this.dtVencimiento.MinDate = new System.DateTime(2025, 4, 17, 0, 0, 0, 0);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(131, 20);
            this.dtVencimiento.TabIndex = 10;
            this.dtVencimiento.Value = new System.DateTime(2025, 4, 17, 11, 37, 27, 0);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(25, 250);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(152, 17);
            this.lblVencimiento.TabIndex = 9;
            this.lblVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Location = new System.Drawing.Point(408, 177);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(57, 17);
            this.lblControl.TabIndex = 8;
            this.lblControl.Text = "Control:";
            // 
            // rbControl
            // 
            this.rbControl.AutoCheck = false;
            this.rbControl.AutoSize = true;
            this.rbControl.Location = new System.Drawing.Point(499, 180);
            this.rbControl.Name = "rbControl";
            this.rbControl.Size = new System.Drawing.Size(14, 13);
            this.rbControl.TabIndex = 7;
            this.rbControl.TabStop = true;
            this.rbControl.UseVisualStyleBackColor = true;
            // 
            // numCant
            // 
            this.numCant.Location = new System.Drawing.Point(247, 175);
            this.numCant.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(131, 20);
            this.numCant.TabIndex = 6;
            this.numCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(25, 175);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(68, 17);
            this.lblCant.TabIndex = 4;
            this.lblCant.Text = "Cantidad:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(247, 108);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(284, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(25, 108);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(86, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(247, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(173, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Medicamento:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.DarkBlue;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Location = new System.Drawing.Point(-3, 0);
            this.txtTitle.MaximumSize = new System.Drawing.Size(1062, 100);
            this.txtTitle.MinimumSize = new System.Drawing.Size(1062, 100);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(1062, 100);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "\r\nAgregar Medicamento\r\n";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(820, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 55);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(820, 251);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(163, 55);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(820, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 55);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(820, 454);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(163, 55);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // imgActualizar
            // 
            this.imgActualizar.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_actualizar;
            this.imgActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgActualizar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgActualizar.Location = new System.Drawing.Point(837, 464);
            this.imgActualizar.Name = "imgActualizar";
            this.imgActualizar.Size = new System.Drawing.Size(33, 34);
            this.imgActualizar.TabIndex = 9;
            this.imgActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgActualizar.UseVisualStyleBackColor = true;
            // 
            // imgEliminar
            // 
            this.imgEliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_cancelar;
            this.imgEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgEliminar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgEliminar.Location = new System.Drawing.Point(836, 364);
            this.imgEliminar.Name = "imgEliminar";
            this.imgEliminar.Size = new System.Drawing.Size(37, 36);
            this.imgEliminar.TabIndex = 8;
            this.imgEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgEliminar.UseVisualStyleBackColor = true;
            // 
            // imgNuevo
            // 
            this.imgNuevo.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_guardar;
            this.imgNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgNuevo.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgNuevo.Location = new System.Drawing.Point(833, 260);
            this.imgNuevo.Name = "imgNuevo";
            this.imgNuevo.Size = new System.Drawing.Size(37, 36);
            this.imgNuevo.TabIndex = 7;
            this.imgNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgNuevo.UseVisualStyleBackColor = true;
            // 
            // imgAgregar
            // 
            this.imgAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_agregar;
            this.imgAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgAgregar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgAgregar.Location = new System.Drawing.Point(836, 164);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(34, 35);
            this.imgAgregar.TabIndex = 2;
            this.imgAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgAgregar.UseVisualStyleBackColor = true;
            // 
            // gbMedicamentos
            // 
            this.gbMedicamentos.Controls.Add(this.dgMedicamentos);
            this.gbMedicamentos.Location = new System.Drawing.Point(59, 528);
            this.gbMedicamentos.Name = "gbMedicamentos";
            this.gbMedicamentos.Size = new System.Drawing.Size(941, 288);
            this.gbMedicamentos.TabIndex = 11;
            this.gbMedicamentos.TabStop = false;
            this.gbMedicamentos.Text = "Medicamentos";
            // 
            // dgMedicamentos
            // 
            this.dgMedicamentos.AllowUserToAddRows = false;
            this.dgMedicamentos.AllowUserToDeleteRows = false;
            this.dgMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMedicamentos.Location = new System.Drawing.Point(3, 16);
            this.dgMedicamentos.Name = "dgMedicamentos";
            this.dgMedicamentos.ReadOnly = true;
            this.dgMedicamentos.RowHeadersVisible = false;
            this.dgMedicamentos.RowHeadersWidth = 51;
            this.dgMedicamentos.RowTemplate.Height = 24;
            this.dgMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMedicamentos.Size = new System.Drawing.Size(935, 269);
            this.dgMedicamentos.TabIndex = 0;
            // 
            // imgVolver
            // 
            this.imgVolver.Image = global::CapaPresentacion.Properties.Resources.ic_volver;
            this.imgVolver.Location = new System.Drawing.Point(6, 106);
            this.imgVolver.Name = "imgVolver";
            this.imgVolver.Size = new System.Drawing.Size(47, 39);
            this.imgVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVolver.TabIndex = 13;
            this.imgVolver.TabStop = false;
            this.imgVolver.Click += new System.EventHandler(this.imgVolver_Click);
            // 
            // AddMedicamentoForm
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1053, 828);
            this.Controls.Add(this.imgVolver);
            this.Controls.Add(this.gbMedicamentos);
            this.Controls.Add(this.imgActualizar);
            this.Controls.Add(this.imgEliminar);
            this.Controls.Add(this.imgNuevo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.imgAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.gbDatosNuevoMedicamento);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1071, 875);
            this.MinimizeBox = false;
            this.Name = "AddMedicamentoForm";
            this.gbDatosNuevoMedicamento.ResumeLayout(false);
            this.gbDatosNuevoMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            this.gbMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ComboBox cbProveedores;
        private Label lblProveedor;
        private PictureBox imgVolver;
    }
}