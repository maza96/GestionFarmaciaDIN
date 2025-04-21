using System.Windows.Forms;

namespace Farmacia
{
    partial class AddVentaForm
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



        private GroupBox gbBusqueda;
        private TextBox txtTitle;
        private Label lblNombre;
        private TextBox txtProducto;
        private Button imgAgregar;
        private Button btnAgregar;
        private Button btnSalir;
        private Button btnActualizar;
        private Button imgAñadir;
        private Button imgSalir;
        private Button imgActualizar;
        private GroupBox gbEmpleados;
        private DataGridView dgProductosIngresados;

        private void InitializeComponent()
        {
            gbBusqueda = new GroupBox();
            dgProductos = new DataGridView();
            imgAñadir = new Button();
            txtProducto = new TextBox();
            lblNombre = new Label();
            txtTitle = new TextBox();
            btnAgregar = new Button();
            btnSalir = new Button();
            btnActualizar = new Button();
            imgActualizar = new Button();
            imgSalir = new Button();
            imgAgregar = new Button();
            gbEmpleados = new GroupBox();
            dgProductosIngresados = new DataGridView();
            groupBox1 = new GroupBox();
            txtCambio = new TextBox();
            label2 = new Label();
            txtRecibo = new TextBox();
            label3 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            txtCantidad = new TextBox();
            label1 = new Label();
            gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            gbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductosIngresados).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbBusqueda
            // 
            gbBusqueda.Controls.Add(dgProductos);
            gbBusqueda.Controls.Add(imgAñadir);
            gbBusqueda.Controls.Add(txtProducto);
            gbBusqueda.Controls.Add(lblNombre);
            gbBusqueda.Location = new Point(49, 117);
            gbBusqueda.Name = "gbBusqueda";
            gbBusqueda.Size = new Size(634, 330);
            gbBusqueda.TabIndex = 0;
            gbBusqueda.TabStop = false;
            gbBusqueda.Text = "Busqueda";
            gbBusqueda.Enter += gbBusqueda_Enter;
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(6, 80);
            dgProductos.Name = "dgProductos";
            dgProductos.RowHeadersWidth = 51;
            dgProductos.Size = new Size(622, 244);
            dgProductos.TabIndex = 8;
            // 
            // imgAñadir
            // 
            imgAñadir.BackgroundImage = Presentacion.Properties.Resources.ic_guardar;
            imgAñadir.BackgroundImageLayout = ImageLayout.Zoom;
            imgAñadir.FlatStyle = FlatStyle.Flat;
            imgAñadir.ForeColor = Color.SkyBlue;
            imgAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            imgAñadir.Location = new Point(558, 27);
            imgAñadir.Name = "imgAñadir";
            imgAñadir.Size = new Size(33, 36);
            imgAñadir.TabIndex = 7;
            imgAñadir.TextAlign = ContentAlignment.MiddleRight;
            imgAñadir.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgAñadir.UseVisualStyleBackColor = true;
            imgAñadir.Click += imgAnyadir_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(162, 32);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(371, 27);
            txtProducto.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(66, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(90, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Producto:";
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
            txtTitle.Text = "\r\nAgregar Venta";
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(905, 531);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 55);
            btnAgregar.TabIndex = 3;
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(905, 722);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 55);
            btnSalir.TabIndex = 5;
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(905, 626);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(122, 55);
            btnActualizar.TabIndex = 6;
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
            imgActualizar.Location = new Point(947, 637);
            imgActualizar.Name = "imgActualizar";
            imgActualizar.Size = new Size(33, 34);
            imgActualizar.TabIndex = 9;
            imgActualizar.TextAlign = ContentAlignment.MiddleRight;
            imgActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgActualizar.UseVisualStyleBackColor = true;
            imgActualizar.Click += imgActualizar_Click;
            // 
            // imgSalir
            // 
            imgSalir.BackgroundImage = Presentacion.Properties.Resources.ic_cancelar;
            imgSalir.BackgroundImageLayout = ImageLayout.Zoom;
            imgSalir.FlatStyle = FlatStyle.Flat;
            imgSalir.ForeColor = Color.SkyBlue;
            imgSalir.ImageAlign = ContentAlignment.MiddleLeft;
            imgSalir.Location = new Point(946, 732);
            imgSalir.Name = "imgSalir";
            imgSalir.Size = new Size(37, 36);
            imgSalir.TabIndex = 8;
            imgSalir.TextAlign = ContentAlignment.MiddleRight;
            imgSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            imgSalir.UseVisualStyleBackColor = true;
            imgSalir.Click += imgSalir_Click;
            // 
            // imgAgregar
            // 
            imgAgregar.BackgroundImage = Presentacion.Properties.Resources.ic_agregar;
            imgAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            imgAgregar.FlatStyle = FlatStyle.Flat;
            imgAgregar.ForeColor = Color.SkyBlue;
            imgAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            imgAgregar.Location = new Point(948, 542);
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
            gbEmpleados.Controls.Add(dgProductosIngresados);
            gbEmpleados.Location = new Point(59, 514);
            gbEmpleados.Name = "gbEmpleados";
            gbEmpleados.Size = new Size(813, 274);
            gbEmpleados.TabIndex = 11;
            gbEmpleados.TabStop = false;
            gbEmpleados.Text = "Productos Ingresados";
            // 
            // dgProductosIngresados
            // 
            dgProductosIngresados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosIngresados.Dock = DockStyle.Fill;
            dgProductosIngresados.Location = new Point(3, 23);
            dgProductosIngresados.Name = "dgProductosIngresados";
            dgProductosIngresados.ReadOnly = true;
            dgProductosIngresados.RowHeadersWidth = 51;
            dgProductosIngresados.RowTemplate.Height = 24;
            dgProductosIngresados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProductosIngresados.Size = new Size(807, 248);
            dgProductosIngresados.TabIndex = 0;
            dgProductosIngresados.SelectionChanged += dgEmpleados_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCambio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtRecibo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(706, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 250);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(149, 181);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(138, 27);
            txtCambio.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 181);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 6;
            label2.Text = "Cambio:";
            // 
            // txtRecibo
            // 
            txtRecibo.Location = new Point(149, 113);
            txtRecibo.Name = "txtRecibo";
            txtRecibo.Size = new Size(138, 27);
            txtRecibo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Recibo:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(149, 40);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(138, 27);
            txtTotal.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 40);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 2;
            label4.Text = "Total a pagar:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(855, 149);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(138, 27);
            txtCantidad.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(738, 150);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 8;
            label1.Text = "Cantidad:";
            // 
            // AddVentaForm
            // 
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1053, 828);
            Controls.Add(txtCantidad);
            Controls.Add(gbEmpleados);
            Controls.Add(label1);
            Controls.Add(imgActualizar);
            Controls.Add(imgSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(imgAgregar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTitle);
            Controls.Add(groupBox1);
            Controls.Add(gbBusqueda);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddVentaForm";
            Load += AddProductos_Load;
            gbBusqueda.ResumeLayout(false);
            gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            gbEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProductosIngresados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox groupBox1;
        private TextBox txtCambio;
        private Label label2;
        private TextBox txtRecibo;
        private Label label3;
        private TextBox txtTotal;
        private Label label4;
        private TextBox txtCantidad;
        private Label label1;
        private DataGridView dgProductos;
    }
}