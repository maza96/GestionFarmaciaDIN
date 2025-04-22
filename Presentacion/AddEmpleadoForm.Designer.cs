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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gbDatosNuevoMedicamento = new GroupBox();
            txtContrasenya = new TextBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtnombre = new TextBox();
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
            gbEmpleados = new GroupBox();
            dgEmpleados = new DataGridView();
            imgVolver = new PictureBox();
            gbDatosNuevoMedicamento.SuspendLayout();
            gbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgVolver).BeginInit();
            SuspendLayout();
            // 
            // gbDatosNuevoMedicamento
            // 
            gbDatosNuevoMedicamento.Controls.Add(txtContrasenya);
            gbDatosNuevoMedicamento.Controls.Add(label1);
            gbDatosNuevoMedicamento.Controls.Add(txtUsuario);
            gbDatosNuevoMedicamento.Controls.Add(lblUsuario);
            gbDatosNuevoMedicamento.Controls.Add(txtApellido);
            gbDatosNuevoMedicamento.Controls.Add(lblApellido);
            gbDatosNuevoMedicamento.Controls.Add(txtnombre);
            gbDatosNuevoMedicamento.Controls.Add(lblNombre);
            gbDatosNuevoMedicamento.Location = new Point(59, 143);
            gbDatosNuevoMedicamento.Name = "gbDatosNuevoMedicamento";
            gbDatosNuevoMedicamento.Size = new Size(729, 330);
            gbDatosNuevoMedicamento.TabIndex = 0;
            gbDatosNuevoMedicamento.TabStop = false;
            gbDatosNuevoMedicamento.Text = "Datos";
            // 
            // txtContrasenya
            // 
            txtContrasenya.Location = new Point(247, 241);
            txtContrasenya.Name = "txtContrasenya";
            txtContrasenya.Size = new Size(284, 27);
            txtContrasenya.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 242);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 6;
            label1.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(247, 174);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(284, 27);
            txtUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(25, 175);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(247, 108);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(284, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(25, 108);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(73, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(247, 49);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(284, 27);
            txtnombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(25, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
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
            txtTitle.Text = "\r\nAgregar Empleado";
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
            btnNuevo.Location = new Point(837, 238);
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
            imgActualizar.BackgroundImage = Presentacion.Properties.Resources.ic_actualizar;
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
            imgEliminar.BackgroundImage = Presentacion.Properties.Resources.ic_cancelar;
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
            imgNuevo.BackgroundImage = Presentacion.Properties.Resources.ic_guardar;
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
            imgAgregar.BackgroundImage = Presentacion.Properties.Resources.ic_agregar;
            imgAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            imgAgregar.FlatStyle = FlatStyle.Flat;
            imgAgregar.ForeColor = Color.SkyBlue;
            imgAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            imgAgregar.Location = new Point(854, 164);
            imgAgregar.Name = "imgAgregar";
            imgAgregar.Size = new Size(34, 35);
            imgAgregar.TabIndex = 2;
            imgAgregar.TextAlign = ContentAlignment.MiddleRight;
            imgAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgAgregar.UseVisualStyleBackColor = true;
            imgAgregar.Click += imgAgregar_Click;
            // 
            // gbEmpleados
            // 
            gbEmpleados.Controls.Add(dgEmpleados);
            gbEmpleados.Location = new Point(59, 514);
            gbEmpleados.Name = "gbEmpleados";
            gbEmpleados.Size = new Size(941, 274);
            gbEmpleados.TabIndex = 11;
            gbEmpleados.TabStop = false;
            gbEmpleados.Text = "Empleados";
            // 
            // dgEmpleados
            // 
            dgEmpleados.AllowUserToAddRows = false;
            dgEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dgEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
            dgEmpleados.Dock = DockStyle.Fill;
            dgEmpleados.Location = new Point(3, 23);
            dgEmpleados.MultiSelect = false;
            dgEmpleados.Name = "dgEmpleados";
            dgEmpleados.ReadOnly = true;
            dgEmpleados.RowHeadersVisible = false;
            dgEmpleados.RowHeadersWidth = 51;
            dgEmpleados.RowTemplate.Height = 24;
            dgEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEmpleados.Size = new Size(935, 248);
            dgEmpleados.TabIndex = 1;
            dgEmpleados.SelectionChanged += dgEmpleados_SelectionChanged_1;
            // 
            // imgVolver
            // 
            imgVolver.Image = Presentacion.Properties.Resources.ic_volver;
            imgVolver.Location = new Point(6, 106);
            imgVolver.Name = "imgVolver";
            imgVolver.Size = new Size(36, 30);
            imgVolver.SizeMode = PictureBoxSizeMode.Zoom;
            imgVolver.TabIndex = 12;
            imgVolver.TabStop = false;
            imgVolver.Click += imgVolver_Click;
            // 
            // AddEmpleadoForm
            // 
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1053, 828);
            Controls.Add(imgVolver);
            Controls.Add(gbEmpleados);
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
            Name = "AddEmpleadoForm";
            Load += AddEmpleados_Load;
            gbDatosNuevoMedicamento.ResumeLayout(false);
            gbDatosNuevoMedicamento.PerformLayout();
            gbEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtUsuario;
        private TextBox txtContrasenya;
        private Label label1;
        private DataGridView dgEmpleados;
        private PictureBox imgVolver;
    }
}