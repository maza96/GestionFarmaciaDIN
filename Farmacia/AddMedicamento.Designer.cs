using Org.BouncyCastle.Crmf;
using System.Windows.Forms;

namespace Farmacia
{
    partial class AddMedicamento
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
        private TextBox txtnombre;
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
        private Button btnCancelar;
        private Button btnActualizar;
        private Button imgNuevo;
        private Button imgCancelar;
        private Button imgActualizar;
        private GroupBox gbMedicamentos;
        private DataGridView dgMedicamentos;

        private void InitializeComponent()
        {

            this.gbDatosNuevoMedicamento = new System.Windows.Forms.GroupBox();
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.imgActualizar = new System.Windows.Forms.Button();
            this.imgCancelar = new System.Windows.Forms.Button();
            this.imgNuevo = new System.Windows.Forms.Button();
            this.imgAgregar = new System.Windows.Forms.Button();
            this.gbMedicamentos = new System.Windows.Forms.GroupBox();
            this.dgMedicamentos = new System.Windows.Forms.DataGridView();
            this.gbDatosNuevoMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            this.gbMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosNuevoMedicamento
            // 
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
            this.gbDatosNuevoMedicamento.Controls.Add(this.txtnombre);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblNombre);
            this.gbDatosNuevoMedicamento.Location = new System.Drawing.Point(59, 143);
            this.gbDatosNuevoMedicamento.Name = "gbDatosNuevoMedicamento";
            this.gbDatosNuevoMedicamento.Size = new System.Drawing.Size(729, 330);
            this.gbDatosNuevoMedicamento.TabIndex = 0;
            this.gbDatosNuevoMedicamento.TabStop = false;
            this.gbDatosNuevoMedicamento.Text = "Datos";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(474, 247);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(179, 22);
            this.txtCosto.TabIndex = 12;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(408, 247);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(58, 20);
            this.lblCosto.TabIndex = 11;
            this.lblCosto.Text = "Costo:";
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimiento.Location = new System.Drawing.Point(247, 247);
            this.dtVencimiento.MinDate = new System.DateTime(2025, 4, 17, 0, 0, 0, 0);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(131, 22);
            this.dtVencimiento.TabIndex = 10;
            this.dtVencimiento.Value = new System.DateTime(2025, 4, 17, 11, 37, 27, 0);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(25, 250);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(180, 20);
            this.lblVencimiento.TabIndex = 9;
            this.lblVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Location = new System.Drawing.Point(408, 177);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(68, 20);
            this.lblControl.TabIndex = 8;
            this.lblControl.Text = "Control:";
            // 
            // rbControl
            // 
            this.rbControl.AutoSize = true;
            this.rbControl.Location = new System.Drawing.Point(499, 180);
            this.rbControl.Name = "rbControl";
            this.rbControl.Size = new System.Drawing.Size(17, 16);
            this.rbControl.TabIndex = 7;
            this.rbControl.TabStop = true;
            this.rbControl.UseVisualStyleBackColor = true;
            // 
            // numCant
            // 
            this.numCant.Location = new System.Drawing.Point(247, 175);
            this.numCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(131, 22);
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
            this.lblCant.Size = new System.Drawing.Size(80, 20);
            this.lblCant.TabIndex = 4;
            this.lblCant.Text = "Cantidad:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(247, 108);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(284, 22);
            this.txtDesc.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(25, 108);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(104, 20);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(247, 49);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(284, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(205, 20);
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
            this.btnAgregar.Location = new System.Drawing.Point(837, 143);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 55);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(837, 237);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(163, 55);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(837, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 55);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(837, 418);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(163, 55);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // imgActualizar
            // 
            this.imgActualizar.BackgroundImage = global::Farmacia.Properties.Resources.ic_actualizar;
            this.imgActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgActualizar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgActualizar.Location = new System.Drawing.Point(854, 429);
            this.imgActualizar.Name = "imgActualizar";
            this.imgActualizar.Size = new System.Drawing.Size(33, 34);
            this.imgActualizar.TabIndex = 9;
            this.imgActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgActualizar.UseVisualStyleBackColor = true;
            this.imgActualizar.Click += new System.EventHandler(this.imgActualizar_Click);
            // 
            // imgCancelar
            // 
            this.imgCancelar.BackgroundImage = global::Farmacia.Properties.Resources.ic_cancelar;
            this.imgCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgCancelar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgCancelar.Location = new System.Drawing.Point(854, 340);
            this.imgCancelar.Name = "imgCancelar";
            this.imgCancelar.Size = new System.Drawing.Size(37, 36);
            this.imgCancelar.TabIndex = 8;
            this.imgCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgCancelar.UseVisualStyleBackColor = true;
            this.imgCancelar.Click += new System.EventHandler(this.imgCancelar_Click);
            // 
            // imgNuevo
            // 
            this.imgNuevo.BackgroundImage = global::Farmacia.Properties.Resources.ic_guardar;
            this.imgNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgNuevo.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgNuevo.Location = new System.Drawing.Point(854, 247);
            this.imgNuevo.Name = "imgNuevo";
            this.imgNuevo.Size = new System.Drawing.Size(37, 36);
            this.imgNuevo.TabIndex = 7;
            this.imgNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgNuevo.UseVisualStyleBackColor = true;
            this.imgNuevo.Click += new System.EventHandler(this.imgNuevo_Click);
            // 
            // imgAgregar
            // 
            this.imgAgregar.BackgroundImage = global::Farmacia.Properties.Resources.ic_agregar;
            this.imgAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgAgregar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgAgregar.Location = new System.Drawing.Point(854, 154);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(34, 35);
            this.imgAgregar.TabIndex = 2;
            this.imgAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgAgregar.UseVisualStyleBackColor = true;
            this.imgAgregar.Click += new System.EventHandler(this.imgAgregar_Click);
            // 
            // gbMedicamentos
            // 
            this.gbMedicamentos.Controls.Add(this.dgMedicamentos);
            this.gbMedicamentos.Location = new System.Drawing.Point(59, 500);
            this.gbMedicamentos.Name = "gbMedicamentos";
            this.gbMedicamentos.Size = new System.Drawing.Size(941, 288);
            this.gbMedicamentos.TabIndex = 11;
            this.gbMedicamentos.TabStop = false;
            this.gbMedicamentos.Text = "Medicamentos";
            // 
            // dgMedicamentos
            // 
            this.dgMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMedicamentos.Location = new System.Drawing.Point(3, 18);
            this.dgMedicamentos.Name = "dgMedicamentos";
            this.dgMedicamentos.RowHeadersWidth = 51;
            this.dgMedicamentos.RowTemplate.Height = 24;
            this.dgMedicamentos.Size = new System.Drawing.Size(935, 267);
            this.dgMedicamentos.TabIndex = 0;
            // 
            // AddMedicamento
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1053, 828);
            this.Controls.Add(this.gbMedicamentos);
            this.Controls.Add(this.imgActualizar);
            this.Controls.Add(this.imgCancelar);
            this.Controls.Add(this.imgNuevo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.imgAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.gbDatosNuevoMedicamento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMedicamento";
            this.Load += new System.EventHandler(this.AddMedicamento_Load);
            this.gbDatosNuevoMedicamento.ResumeLayout(false);
            this.gbDatosNuevoMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            this.gbMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}