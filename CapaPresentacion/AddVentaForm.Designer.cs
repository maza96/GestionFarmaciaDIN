using System.Drawing;
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
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.imgAñadir = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.imgActualizar = new System.Windows.Forms.Button();
            this.imgSalir = new System.Windows.Forms.Button();
            this.imgAgregar = new System.Windows.Forms.Button();
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.dgProductosIngresados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.imgVolver = new System.Windows.Forms.PictureBox();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.gbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosIngresados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.dgProductos);
            this.gbBusqueda.Controls.Add(this.imgAñadir);
            this.gbBusqueda.Controls.Add(this.txtProducto);
            this.gbBusqueda.Controls.Add(this.lblNombre);
            this.gbBusqueda.Location = new System.Drawing.Point(49, 117);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(634, 330);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(6, 80);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(622, 244);
            this.dgProductos.TabIndex = 8;
            // 
            // imgAñadir
            // 
            this.imgAñadir.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_guardar;
            this.imgAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgAñadir.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgAñadir.Location = new System.Drawing.Point(558, 27);
            this.imgAñadir.Name = "imgAñadir";
            this.imgAñadir.Size = new System.Drawing.Size(33, 36);
            this.imgAñadir.TabIndex = 7;
            this.imgAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgAñadir.UseVisualStyleBackColor = true;
            this.imgAñadir.Click += new System.EventHandler(this.imgAñadir_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(162, 32);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(371, 20);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(66, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Producto:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.DarkBlue;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Location = new System.Drawing.Point(-3, 0);
            this.txtTitle.MaximumSize = new System.Drawing.Size(1062, 85);
            this.txtTitle.MinimumSize = new System.Drawing.Size(1062, 85);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(1062, 85);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "\r\nAgregar Venta";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(901, 489);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 55);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(901, 680);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 55);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(901, 584);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(122, 55);
            this.btnActualizar.TabIndex = 6;
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
            this.imgActualizar.Location = new System.Drawing.Point(943, 595);
            this.imgActualizar.Name = "imgActualizar";
            this.imgActualizar.Size = new System.Drawing.Size(33, 34);
            this.imgActualizar.TabIndex = 9;
            this.imgActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgActualizar.UseVisualStyleBackColor = true;
            this.imgActualizar.Click += new System.EventHandler(this.imgActualizar_Click);
            // 
            // imgSalir
            // 
            this.imgSalir.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_cancelar;
            this.imgSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgSalir.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgSalir.Location = new System.Drawing.Point(942, 690);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(37, 36);
            this.imgSalir.TabIndex = 8;
            this.imgSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgSalir.UseVisualStyleBackColor = true;
            this.imgSalir.Click += new System.EventHandler(this.imgEliminar_Click);
            // 
            // imgAgregar
            // 
            this.imgAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.ic_agregar;
            this.imgAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgAgregar.ForeColor = System.Drawing.Color.SkyBlue;
            this.imgAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgAgregar.Location = new System.Drawing.Point(944, 500);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(34, 35);
            this.imgAgregar.TabIndex = 2;
            this.imgAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgAgregar.UseVisualStyleBackColor = true;
            this.imgAgregar.Click += new System.EventHandler(this.imgAgregar_Click);
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.dgProductosIngresados);
            this.gbEmpleados.Location = new System.Drawing.Point(55, 472);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Size = new System.Drawing.Size(813, 274);
            this.gbEmpleados.TabIndex = 11;
            this.gbEmpleados.TabStop = false;
            this.gbEmpleados.Text = "Productos Ingresados";
            // 
            // dgProductosIngresados
            // 
            this.dgProductosIngresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductosIngresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosIngresados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PrecioUnitario,
            this.Cantidad,
            this.Subtotal,
            this.id_medicamento});
            this.dgProductosIngresados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductosIngresados.Location = new System.Drawing.Point(3, 16);
            this.dgProductosIngresados.Name = "dgProductosIngresados";
            this.dgProductosIngresados.ReadOnly = true;
            this.dgProductosIngresados.RowHeadersWidth = 51;
            this.dgProductosIngresados.RowTemplate.Height = 24;
            this.dgProductosIngresados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductosIngresados.Size = new System.Drawing.Size(807, 255);
            this.dgProductosIngresados.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // id_medicamento
            // 
            this.id_medicamento.HeaderText = "id";
            this.id_medicamento.Name = "id_medicamento";
            this.id_medicamento.ReadOnly = true;
            this.id_medicamento.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCambio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRecibo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(706, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 250);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cobro";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(149, 181);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(138, 20);
            this.txtCambio.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cambio:";
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(149, 113);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(138, 20);
            this.txtRecibo.TabIndex = 5;
            this.txtRecibo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecibo_KeyDown);
            this.txtRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recibe:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(149, 40);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(138, 20);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total a pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(738, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(855, 150);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(138, 20);
            this.numCantidad.TabIndex = 13;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // imgVolver
            // 
            this.imgVolver.Image = global::CapaPresentacion.Properties.Resources.ic_volver;
            this.imgVolver.Location = new System.Drawing.Point(6, 107);
            this.imgVolver.Name = "imgVolver";
            this.imgVolver.Size = new System.Drawing.Size(33, 32);
            this.imgVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVolver.TabIndex = 14;
            this.imgVolver.TabStop = false;
            // 
            // AddVentaForm
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1053, 752);
            this.Controls.Add(this.imgVolver);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.gbEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgActualizar);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.imgAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBusqueda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVentaForm";
            this.Load += new System.EventHandler(this.AddVentaForm_Load);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.gbEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosIngresados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private GroupBox groupBox1;
        private TextBox txtCambio;
        private Label label2;
        private TextBox txtRecibo;
        private Label label3;
        private Label label4;
        private Label label1;
        private DataGridView dgProductos;
        private NumericUpDown numCantidad;
        private TextBox txtTotal;
        private PictureBox imgVolver;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn id_medicamento;
    }
}