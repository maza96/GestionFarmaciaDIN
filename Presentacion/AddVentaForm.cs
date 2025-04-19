using Negocio;
using Presentacion;
using System;
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

        private void imgAnyadir_Click(object sender, EventArgs e)
        {
            
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
            dgProductosIngresados.CurrentCell = null;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            bool hayFilaSeleccionada = dgProductosIngresados.SelectedRows.Count > 0;

            btnAgregar.Enabled = !hayFilaSeleccionada;
            btnActualizar.Enabled = hayFilaSeleccionada;
            btnSalir.Enabled = hayFilaSeleccionada;

            // Habilitar o deshabilitar imágenes
            imgAgregar.Enabled = !hayFilaSeleccionada;
            imgActualizar.Enabled = hayFilaSeleccionada;
            imgSalir.Enabled = hayFilaSeleccionada;

            if (hayFilaSeleccionada)
            {
                DataGridViewRow fila = dgProductosIngresados.SelectedRows[0];

                txtProducto.Text = fila.Cells["nombre"].Value?.ToString() ?? "";
                //txtApellido.Text = fila.Cells["apellido"].Value?.ToString() ?? "";
                //txtUsuario.Text = fila.Cells["usuario"].Value?.ToString() ?? "";
                //txtContrasenya.Text = fila.Cells["password"].Value?.ToString() ?? "";
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void gbBusqueda_Enter(object sender, EventArgs e)
        {

        }
    }
}
