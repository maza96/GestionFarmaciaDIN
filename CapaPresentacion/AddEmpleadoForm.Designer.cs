using System.Drawing;
using System.Windows.Forms;

namespace Farmacia
{
    partial class AddEmpleadoForm
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
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtnombre;
        private Label lblUsuario;
        private Button imgAgregar;
        private Button btnAgregar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button imgNuevo;
        private Button imgEliminar;
        private Button imgActualizar;
        private GroupBox gbEmpleados;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDatosNuevoMedicamento = new System.Windows.Forms.GroupBox();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
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
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.imgVolver = new System.Windows.Forms.PictureBox();
            this.gbDatosNuevoMedicamento.SuspendLayout();
            this.gbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosNuevoMedicamento
            // 
            this.gbDatosNuevoMedicamento.Controls.Add(this.txtContrasenya);
            this.gbDatosNuevoMedicamento.Controls.Add(this.label1);
            this.gbDatosNuevoMedicamento.Controls.Add(this.txtUsuario);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblUsuario);
            this.gbDatosNuevoMedicamento.Controls.Add(this.txtApellido);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblApellido);
            this.gbDatosNuevoMedicamento.Controls.Add(this.txtnombre);
            this.gbDatosNuevoMedicamento.Controls.Add(this.lblNombre);
            this.gbDatosNuevoMedicamento.Location = new System.Drawing.Point(59, 143);
            this.gbDatosNuevoMedicamento.Name = "gbDatosNuevoMedicamento";
            this.gbDatosNuevoMedicamento.Size = new System.Drawing.Size(729, 330);
            this.gbDatosNuevoMedicamento.TabIndex = 0;
            this.gbDatosNuevoMedicamento.TabStop = false;
            this.gbDatosNuevoMedicamento.Text = "Datos";
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Location = new System.Drawing.Point(247, 241);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(284, 22);
            this.txtContrasenya.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(247, 174);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(284, 22);
            this.txtUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(25, 175);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(247, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(284, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(25, 108);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
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
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.DarkBlue;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Location = new System.Drawing.Point(-3, 0);
            this.txtTitle.MaximumSize = new System.Drawing.Size(1062, 84);
            this.txtTitle.MinimumSize = new System.Drawing.Size(1062, 84);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(1062, 84);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "\r\nAgregar Empleado";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(837, 154);
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
            this.btnNuevo.Location = new System.Drawing.Point(837, 238);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(163, 55);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(837, 330);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 55);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.imgActualizar.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_actualizar;
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
            this.imgActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // imgEliminar
            // 
            this.imgEliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_cancelar;
            this.imgEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgEliminar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgEliminar.Location = new System.Drawing.Point(854, 340);
            this.imgEliminar.Name = "imgEliminar";
            this.imgEliminar.Size = new System.Drawing.Size(37, 36);
            this.imgEliminar.TabIndex = 8;
            this.imgEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgEliminar.UseVisualStyleBackColor = true;
            this.imgEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // imgNuevo
            // 
            this.imgNuevo.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_guardar;
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
            this.imgNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // imgAgregar
            // 
            this.imgAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_agregar;
            this.imgAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgAgregar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgAgregar.Location = new System.Drawing.Point(854, 164);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(34, 35);
            this.imgAgregar.TabIndex = 2;
            this.imgAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgAgregar.UseVisualStyleBackColor = true;
            this.imgAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.dgEmpleados);
            this.gbEmpleados.Location = new System.Drawing.Point(59, 493);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Size = new System.Drawing.Size(941, 219);
            this.gbEmpleados.TabIndex = 11;
            this.gbEmpleados.TabStop = false;
            this.gbEmpleados.Text = "Empleados";
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.AllowUserToAddRows = false;
            this.dgEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmpleados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmpleados.Location = new System.Drawing.Point(3, 18);
            this.dgEmpleados.MultiSelect = false;
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.ReadOnly = true;
            this.dgEmpleados.RowHeadersVisible = false;
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.RowTemplate.Height = 24;
            this.dgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmpleados.Size = new System.Drawing.Size(935, 198);
            this.dgEmpleados.TabIndex = 1;
            this.dgEmpleados.SelectionChanged += new System.EventHandler(this.dgEmpleados_SelectionChanged);
            // 
            // imgVolver
            // 
            this.imgVolver.Image = global::CapaPresentacion.Properties.Resources.ic_volver;
            this.imgVolver.Location = new System.Drawing.Point(12, 90);
            this.imgVolver.Name = "imgVolver";
            this.imgVolver.Size = new System.Drawing.Size(33, 25);
            this.imgVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVolver.TabIndex = 12;
            this.imgVolver.TabStop = false;
            this.imgVolver.Click += new System.EventHandler(this.imgVolver_Click);
            // 
            // AddEmpleadoForm
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1053, 728);
            this.Controls.Add(this.imgVolver);
            this.Controls.Add(this.gbEmpleados);
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
            this.MaximumSize = new System.Drawing.Size(1071, 775);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1071, 775);
            this.Name = "AddEmpleadoForm";
            this.Load += new System.EventHandler(this.AddEmpleados_Load);
            this.gbDatosNuevoMedicamento.ResumeLayout(false);
            this.gbDatosNuevoMedicamento.PerformLayout();
            this.gbEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtUsuario;
        private TextBox txtContrasenya;
        private Label label1;
        private DataGridView dgEmpleados;
        private PictureBox imgVolver;
    }
}