using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using CapaPresentacion;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class AddVentaForm : Form
    {
        private DataView vistaMedicamentos;
        public AddVentaForm()
        {
            InitializeComponent();
        }

        private void imgAgregar_Click(object sender, EventArgs e)
        {
            InsertarVenta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarVenta();
        }

        private void imgAñadir_Click(object sender, EventArgs e)
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
            int idMedicamento = Convert.ToInt32(dgProductos.CurrentRow.Cells["id_medicamento"].Value);
            string nombre = dgProductos.CurrentRow.Cells["nombre"].Value.ToString();
            decimal precioUnitario = Convert.ToDecimal(dgProductos.CurrentRow.Cells["costo"].Value);
            int stockDisponible = Convert.ToInt32(dgProductos.CurrentRow.Cells["cantidad"].Value);
            int cantidadDeseada = (int)numCantidad.Value;

            if (cantidadDeseada > stockDisponible)
            {
                MessageBox.Show($"Stock insuficiente. Solo hay {stockDisponible} unidades disponibles.");
                return;
            }

            bool encontrado = false;

            foreach (DataGridViewRow fila in dgProductosIngresados.Rows)
            {
                if (fila.Cells[0].Value?.ToString() == nombre)
                {
                    // Si ya existe, actualizar cantidad y subtotal
                    fila.Cells[2].Value = cantidadDeseada;
                    fila.Cells[3].Value = (cantidadDeseada * precioUnitario).ToString("F2");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                // Si no existe, agregar como nuevo
                DataGridViewRow nuevaFila = new DataGridViewRow();
                nuevaFila.CreateCells(dgProductosIngresados);

                nuevaFila.Cells[0].Value = nombre;
                nuevaFila.Cells[1].Value = precioUnitario.ToString("F2");
                nuevaFila.Cells[2].Value = cantidadDeseada;
                nuevaFila.Cells[3].Value = (cantidadDeseada * precioUnitario).ToString("F2");
                nuevaFila.Cells[4].Value = idMedicamento;

                dgProductosIngresados.Rows.Add(nuevaFila);
            }

            // (Opcional) Resetear la cantidad a 1  
            numCantidad.Value = 1;

            // (Opcional) Recalcular total  
            CalcularTotal();
        }

        private void imgEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void imgActualizar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void AddVentaForm_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            try
            {
                // Carga completa con filtro de cantidad > 0
                DataTable medicamentos = MedicamentoService.GetMedicamentos();
                vistaMedicamentos = new DataView(medicamentos);
                vistaMedicamentos.RowFilter = "cantidad > 0";

                dgProductos.DataSource = vistaMedicamentos;

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
            // Limpiar selección en ambos DataGridView    
            dgProductos.CurrentCell = null;
            dgProductosIngresados.CurrentCell = null;

            // Limpiar todas las filas añadidas al DataGridView de productos ingresados    
            dgProductosIngresados.Rows.Clear();

            // Limpiar todos los campos de texto    
            txtProducto.Clear();
            txtRecibo.Clear();
            txtCambio.Text = "0";
            txtTotal.Text = "0";

            // Resetear el valor del control numérico    
            numCantidad.Value = 1;
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string filtro = txtProducto.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(filtro))
                {
                    vistaMedicamentos.RowFilter = $"cantidad > 0 AND nombre LIKE '%{filtro}%'";
                }
                else
                {
                    // Si el campo está vacío, mostramos todos los productos
                    vistaMedicamentos.RowFilter = "cantidad > 0";
                }

                e.Handled = true;
                e.SuppressKeyPress = true; // Para evitar el beep del Enter
            }
        }


        private void txtRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir teclas de control (como Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            char decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            // Reemplazar punto por coma o viceversa según la cultura
            if (e.KeyChar == '.' && decimalSeparator == ',')
                e.KeyChar = ',';
            else if (e.KeyChar == ',' && decimalSeparator == '.')
                e.KeyChar = '.';

            // Permitir números
            if (char.IsDigit(e.KeyChar))
            {
                // Verificar si ya hay decimales
                int indexDecimal = txt.Text.IndexOf(decimalSeparator);
                if (indexDecimal >= 0 && txt.SelectionStart > indexDecimal)
                {
                    string decimales = txt.Text.Substring(indexDecimal + 1);
                    if (decimales.Length >= 2 && txt.SelectionLength == 0)
                    {
                        e.Handled = true; // Más de 2 decimales
                        return;
                    }
                }
                return;
            }

            // Permitir solo un separador decimal
            if (e.KeyChar == decimalSeparator)
            {
                if (txt.Text.Contains(decimalSeparator))
                {
                    e.Handled = true;
                }
                return;
            }

            // Bloquear cualquier otra tecla
            e.Handled = true;
        }

        private void txtRecibo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                ActualizarCambio();
            }
        }

        private void ActualizarCambio()
        {
            // Intentar parsear el valor del recibo como decimal
            if (decimal.TryParse(txtRecibo.Text, out decimal recibo) && decimal.TryParse(txtTotal.Text, out decimal total))
            {             
                decimal cambio = recibo - total;
                txtCambio.Text = cambio.ToString("F2");  // Muestra el cambio con dos decimales               

            }
            else
            {            
                txtRecibo.Focus();
            }
        }

        private void InsertarVenta()
        {
            try
            {
                List<DetalleVenta> detalleVentas = ObtenerDetallesVenta(); // esta función la puedes tener hecha
                ActualizarCambio();

                int idVenta = VentaService.InsertarVenta(DateTime.Now, float.Parse(txtTotal.Text), detalleVentas, float.Parse(txtCambio.Text));

                FacturaForm facturaForm = new FacturaForm(idVenta);
                Hide();
                facturaForm.ShowDialog();
                Show();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al guardar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<DetalleVenta> ObtenerDetallesVenta()
        {
            List<DetalleVenta> detalles = new List<DetalleVenta>();

            // Comprobar si el DataGridView tiene filas
            if (dgProductosIngresados.Rows.Count == 0 || dgProductosIngresados.Rows[0].IsNewRow)
            {
                // Si no hay productos, devolvemos la lista vacía.
                return detalles;
            }

            // Si hay productos, los añadimos a la lista
            foreach (DataGridViewRow row in dgProductosIngresados.Rows)
            {
                if (row.IsNewRow) continue;

                DetalleVenta detalle = new DetalleVenta
                (
                    Convert.ToInt32(row.Cells["id_medicamento"].Value),
                    Convert.ToInt32(row.Cells["cantidad"].Value),
                    float.Parse(row.Cells["precioUnitario"].Value.ToString())
                );

                detalles.Add(detalle);
            }

            return detalles;
        }



        private void EliminarProducto()
        {
            // Verificar si se ha seleccionado alguna fila en el DataGridView
            if (dgProductosIngresados.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFilaSeleccionada = dgProductosIngresados.SelectedRows[0].Index;

                dgProductosIngresados.Rows.RemoveAt(indiceFilaSeleccionada);

                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgProductosIngresados.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    if (decimal.TryParse(row.Cells[3].Value.ToString(), out decimal subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            txtTotal.Text = total.ToString("F2", CultureInfo.CurrentCulture);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecibo.Text))
            {
                txtCambio.Text = "0";
            }
            else
            {
                // Actualizar el cambio al cambiar el total
                ActualizarCambio();
            }
        }
        private void imgVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
