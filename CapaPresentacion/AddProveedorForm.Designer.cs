using System.Drawing;
using System.Windows.Forms;

namespace Farmacia
{
    partial class AddProveedorForm
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
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Button imgAgregar;
        private Button btnAgregar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button imgNuevo;
        private Button imgEliminar;
        private Button imgActualizar;
        private GroupBox gbProveedores;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gbDatosNuevoMedicamento = new GroupBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtTitle = new TextBox();
            btnAgregar = new Button();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            imgActualizar = new Button();
            imgEliminar = new Button();
            imgNuevo = new Button();
            imgAgregar = new Button();
            gbProveedores = new GroupBox();
            dgProveedores = new DataGridView();
            imgVolver = new PictureBox();
            gbDatosNuevoMedicamento.SuspendLayout();
            gbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgVolver).BeginInit();
            SuspendLayout();
            // 
            // gbDatosNuevoMedicamento
            // 
            gbDatosNuevoMedicamento.Controls.Add(txtTelefono);
            gbDatosNuevoMedicamento.Controls.Add(lblTelefono);
            gbDatosNuevoMedicamento.Controls.Add(txtDireccion);
            gbDatosNuevoMedicamento.Controls.Add(lblDireccion);
            gbDatosNuevoMedicamento.Controls.Add(txtNombre);
            gbDatosNuevoMedicamento.Controls.Add(lblNombre);
            gbDatosNuevoMedicamento.Location = new Point(59, 143);
            gbDatosNuevoMedicamento.Name = "gbDatosNuevoMedicamento";
            gbDatosNuevoMedicamento.Size = new Size(729, 330);
            gbDatosNuevoMedicamento.TabIndex = 0;
            gbDatosNuevoMedicamento.TabStop = false;
            gbDatosNuevoMedicamento.Text = "Datos";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(247, 174);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(284, 27);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(25, 175);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(247, 108);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(284, 27);
            txtDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(25, 108);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(91, 20);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Dirección: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(247, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(25, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(181, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Proveedor:";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.DarkBlue;
            txtTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = SystemColors.Window;
            txtTitle.Location = new Point(-3, 0);
            txtTitle.MaximumSize = new Size(1062, 100);
            txtTitle.MinimumSize = new Size(1062, 100);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.RightToLeft = RightToLeft.Yes;
            txtTitle.Size = new Size(1062, 100);
            txtTitle.TabIndex = 1;
            txtTitle.Text = "\r\nAgregar Proveedor";
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(837, 154);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 55);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(837, 237);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(163, 55);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(837, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 55);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(837, 418);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(163, 55);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // imgActualizar
            // 
            imgActualizar.BackgroundImage = CapaPresentacion.Properties.Resources.ic_actualizar;
            imgActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            imgActualizar.FlatStyle = FlatStyle.Flat;
            imgActualizar.ForeColor = Color.SkyBlue;
            imgActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            imgActualizar.Location = new Point(854, 429);
            imgActualizar.Name = "imgActualizar";
            imgActualizar.Size = new Size(33, 34);
            imgActualizar.TabIndex = 9;
            imgActualizar.TextAlign = ContentAlignment.MiddleRight;
            imgActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgActualizar.UseVisualStyleBackColor = true;
            imgActualizar.Click += imgActualizar_Click;
            // 
            // imgEliminar
            // 
            imgEliminar.BackgroundImage = CapaPresentacion.Properties.Resources.ic_cancelar;
            imgEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            imgEliminar.FlatStyle = FlatStyle.Flat;
            imgEliminar.ForeColor = Color.SkyBlue;
            imgEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            imgEliminar.Location = new Point(854, 340);
            imgEliminar.Name = "imgEliminar";
            imgEliminar.Size = new Size(37, 36);
            imgEliminar.TabIndex = 8;
            imgEliminar.TextAlign = ContentAlignment.MiddleRight;
            imgEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgEliminar.UseVisualStyleBackColor = true;
            imgEliminar.Click += imgEliminar_Click;
            // 
            // imgNuevo
            // 
            imgNuevo.BackgroundImage = CapaPresentacion.Properties.Resources.ic_guardar;
            imgNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            imgNuevo.FlatStyle = FlatStyle.Flat;
            imgNuevo.ForeColor = Color.SkyBlue;
            imgNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            imgNuevo.Location = new Point(854, 247);
            imgNuevo.Name = "imgNuevo";
            imgNuevo.Size = new Size(37, 36);
            imgNuevo.TabIndex = 7;
            imgNuevo.TextAlign = ContentAlignment.MiddleRight;
            imgNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgNuevo.UseVisualStyleBackColor = true;
            imgNuevo.Click += imgNuevo_Click;
            // 
            // imgAgregar
            // 
            imgAgregar.BackgroundImage = CapaPresentacion.Properties.Resources.ic_agregar;
            imgAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            imgAgregar.FlatStyle = FlatStyle.Flat;
            imgAgregar.ForeColor = Color.SkyBlue;
            imgAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            imgAgregar.Location = new Point(853, 164);
            imgAgregar.Name = "imgAgregar";
            imgAgregar.Size = new Size(34, 35);
            imgAgregar.TabIndex = 2;
            imgAgregar.TextAlign = ContentAlignment.MiddleRight;
            imgAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgAgregar.UseVisualStyleBackColor = true;
            imgAgregar.Click += imgAgregar_Click;
            // 
            // gbProveedores
            // 
            gbProveedores.Controls.Add(dgProveedores);
            gbProveedores.Location = new Point(59, 502);
            gbProveedores.Name = "gbProveedores";
            gbProveedores.Size = new Size(941, 286);
            gbProveedores.TabIndex = 11;
            gbProveedores.TabStop = false;
            gbProveedores.Text = "Proveedores";
            // 
            // dgProveedores
            // 
            dgProveedores.AllowUserToAddRows = false;
            dgProveedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dgProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            dgProveedores.Dock = DockStyle.Fill;
            dgProveedores.Location = new Point(3, 23);
            dgProveedores.MultiSelect = false;
            dgProveedores.Name = "dgProveedores";
            dgProveedores.ReadOnly = true;
            dgProveedores.RowHeadersVisible = false;
            dgProveedores.RowHeadersWidth = 51;
            dgProveedores.RowTemplate.Height = 24;
            dgProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProveedores.Size = new Size(935, 260);
            dgProveedores.TabIndex = 2;
            dgProveedores.SelectionChanged += dgProveedores_SelectionChanged;
            // 
            // imgVolver
            // 
            imgVolver.Image = CapaPresentacion.Properties.Resources.ic_volver;
            imgVolver.Location = new Point(6, 106);
            imgVolver.Name = "imgVolver";
            imgVolver.Size = new Size(47, 39);
            imgVolver.SizeMode = PictureBoxSizeMode.Zoom;
            imgVolver.TabIndex = 13;
            imgVolver.TabStop = false;
            imgVolver.Click += imgVolver_Click;
            // 
            // AddProveedorForm
            // 
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1053, 828);
            Controls.Add(imgVolver);
            Controls.Add(gbProveedores);
            Controls.Add(imgActualizar);
            Controls.Add(imgEliminar);
            Controls.Add(imgNuevo);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(imgAgregar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTitle);
            Controls.Add(gbDatosNuevoMedicamento);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProveedorForm";
            Load += AddProveedores_Load;
            gbDatosNuevoMedicamento.ResumeLayout(false);
            gbDatosNuevoMedicamento.PerformLayout();
            gbProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtTelefono;
        private DataGridView dgProveedores;
        private PictureBox imgVolver;
    }
}