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
        private Button btnEliminar;
        private Button btnActualizar;
        private Button imgNuevo;
        private Button imgEliminar;
        private Button imgActualizar;
        private GroupBox gbMedicamentos;
        private DataGridView dgMedicamentos;

        private void InitializeComponent()
        {
            gbDatosNuevoMedicamento = new GroupBox();
            txtCosto = new TextBox();
            lblCosto = new Label();
            dtVencimiento = new DateTimePicker();
            lblVencimiento = new Label();
            lblControl = new Label();
            rbControl = new RadioButton();
            numCant = new NumericUpDown();
            lblCant = new Label();
            txtDesc = new TextBox();
            lblDesc = new Label();
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
            gbMedicamentos = new GroupBox();
            dgMedicamentos = new DataGridView();
            gbDatosNuevoMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCant).BeginInit();
            gbMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // gbDatosNuevoMedicamento
            // 
            gbDatosNuevoMedicamento.Controls.Add(txtCosto);
            gbDatosNuevoMedicamento.Controls.Add(lblCosto);
            gbDatosNuevoMedicamento.Controls.Add(dtVencimiento);
            gbDatosNuevoMedicamento.Controls.Add(lblVencimiento);
            gbDatosNuevoMedicamento.Controls.Add(lblControl);
            gbDatosNuevoMedicamento.Controls.Add(rbControl);
            gbDatosNuevoMedicamento.Controls.Add(numCant);
            gbDatosNuevoMedicamento.Controls.Add(lblCant);
            gbDatosNuevoMedicamento.Controls.Add(txtDesc);
            gbDatosNuevoMedicamento.Controls.Add(lblDesc);
            gbDatosNuevoMedicamento.Controls.Add(txtnombre);
            gbDatosNuevoMedicamento.Controls.Add(lblNombre);
            gbDatosNuevoMedicamento.Location = new Point(59, 143);
            gbDatosNuevoMedicamento.Name = "gbDatosNuevoMedicamento";
            gbDatosNuevoMedicamento.Size = new Size(729, 330);
            gbDatosNuevoMedicamento.TabIndex = 0;
            gbDatosNuevoMedicamento.TabStop = false;
            gbDatosNuevoMedicamento.Text = "Datos";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(474, 247);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(179, 23);
            txtCosto.TabIndex = 12;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCosto.Location = new Point(408, 247);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(48, 17);
            lblCosto.TabIndex = 11;
            lblCosto.Text = "Costo:";
            // 
            // dtVencimiento
            // 
            dtVencimiento.Format = DateTimePickerFormat.Short;
            dtVencimiento.Location = new Point(247, 247);
            dtVencimiento.MinDate = new DateTime(2025, 4, 17, 0, 0, 0, 0);
            dtVencimiento.Name = "dtVencimiento";
            dtVencimiento.Size = new Size(131, 23);
            dtVencimiento.TabIndex = 10;
            dtVencimiento.Value = new DateTime(2025, 4, 17, 11, 37, 27, 0);
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVencimiento.Location = new Point(25, 250);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(152, 17);
            lblVencimiento.TabIndex = 9;
            lblVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // lblControl
            // 
            lblControl.AutoSize = true;
            lblControl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblControl.Location = new Point(408, 177);
            lblControl.Name = "lblControl";
            lblControl.Size = new Size(57, 17);
            lblControl.TabIndex = 8;
            lblControl.Text = "Control:";
            // 
            // rbControl
            // 
            rbControl.AutoSize = true;
            rbControl.Location = new Point(499, 180);
            rbControl.Name = "rbControl";
            rbControl.Size = new Size(14, 13);
            rbControl.TabIndex = 7;
            rbControl.TabStop = true;
            rbControl.UseVisualStyleBackColor = true;
            // 
            // numCant
            // 
            numCant.Location = new Point(247, 175);
            numCant.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCant.Name = "numCant";
            numCant.Size = new Size(131, 23);
            numCant.TabIndex = 6;
            numCant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCant.Location = new Point(25, 175);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(68, 17);
            lblCant.TabIndex = 4;
            lblCant.Text = "Cantidad:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(247, 108);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(284, 23);
            txtDesc.TabIndex = 3;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(25, 108);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(86, 17);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Descripción:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(247, 49);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(284, 23);
            txtnombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(25, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(173, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Medicamento:";
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
            txtTitle.Text = "\r\nAgregar Medicamento\r\n";
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(837, 143);
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
            imgAgregar.Location = new Point(854, 154);
            imgAgregar.Name = "imgAgregar";
            imgAgregar.Size = new Size(34, 35);
            imgAgregar.TabIndex = 2;
            imgAgregar.TextAlign = ContentAlignment.MiddleRight;
            imgAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgAgregar.UseVisualStyleBackColor = true;
            imgAgregar.Click += imgAgregar_Click;
            // 
            // gbMedicamentos
            // 
            gbMedicamentos.Controls.Add(dgMedicamentos);
            gbMedicamentos.Location = new Point(59, 500);
            gbMedicamentos.Name = "gbMedicamentos";
            gbMedicamentos.Size = new Size(941, 288);
            gbMedicamentos.TabIndex = 11;
            gbMedicamentos.TabStop = false;
            gbMedicamentos.Text = "Medicamentos";
            // 
            // dgMedicamentos
            // 
            dgMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMedicamentos.Dock = DockStyle.Fill;
            dgMedicamentos.Location = new Point(3, 19);
            dgMedicamentos.Name = "dgMedicamentos";
            dgMedicamentos.ReadOnly = true;
            dgMedicamentos.RowHeadersWidth = 51;
            dgMedicamentos.RowTemplate.Height = 24;
            dgMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMedicamentos.Size = new Size(935, 266);
            dgMedicamentos.TabIndex = 0;
            dgMedicamentos.SelectionChanged += dgMedicamentos_SelectionChanged;
            // 
            // AddMedicamentoForm
            // 
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1053, 828);
            Controls.Add(gbMedicamentos);
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
            Name = "AddMedicamentoForm";
            Load += AddMedicamento_Load;
            gbDatosNuevoMedicamento.ResumeLayout(false);
            gbDatosNuevoMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCant).EndInit();
            gbMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}