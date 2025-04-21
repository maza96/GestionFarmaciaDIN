using Negocio;
using Presentacion;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class AddVentaForm : Form
    {
        public AddVentaForm()
        {
            InitializeComponent();
        }


        private void imgAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void imgAnyadirProductoIngresado_Click(object sender, EventArgs e)
        {
            if (dgProductos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un medicamento.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Obtener datos del producto seleccionado  
            string nombre = dgProductos.CurrentRow.Cells["nombre"].Value.ToString();
            decimal precioUnitario = Convert.ToDecimal(dgProductos.CurrentRow.Cells["costo"].Value);
            int cantidad = (int)numCantidad.Value;
            decimal subtotal = precioUnitario * cantidad;

            // Añadir a la tabla de productos ingresados  
            DataGridViewRow nuevaFila = new DataGridViewRow();
            nuevaFila.CreateCells(dgProductosIngresados);

            nuevaFila.Cells[0].Value = nombre;
            nuevaFila.Cells[1].Value = precioUnitario.ToString("C2"); // Precio con símbolo €  
            nuevaFila.Cells[2].Value = cantidad;
            nuevaFila.Cells[3].Value = subtotal.ToString("C2");

            dgProductosIngresados.Rows.Add(nuevaFila);

            // (Opcional) Resetear la cantidad a 1  
            numCantidad.Value = 1;

            // (Opcional) Recalcular total  
            CalcularTotal();
        }

        private void imgSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void imgActualizar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            dgProductosIngresados.ClearSelection();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            dgProductosIngresados.ClearSelection();
        }

        private void AddProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            try
            {
                dgProductos.DataSource = MedicamentoService.GetMedicamentos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las medicamentos. Compruebe " +
                    "la cadena de conexión a la Base de datos " + ex.Message);
            }
            //Limpiamos formulario para que al iniciar no haya un medicamento
            //seleccionada por defecto
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string filtro = txtProducto.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(filtro))
                {
                    DataView vista = new DataView(MedicamentoService.GetMedicamentos());
                    vista.RowFilter = $"nombre LIKE '%{filtro}%'";
                    dgProductos.DataSource = vista;
                }
                else
                {
                    // Si el campo está vacío, mostramos todos los productos
                    MostrarProductos();
                }

                e.Handled = true;
                e.SuppressKeyPress = true; // Para evitar el beep del Enter
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgProductosIngresados.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    string valorConSimbolo = row.Cells[3].Value.ToString().Replace("€", "").Trim();
                    if (decimal.TryParse(valorConSimbolo, out decimal subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            txtTotal.Text = total.ToString("C2", CultureInfo.CurrentCulture);
        }
    }
}
