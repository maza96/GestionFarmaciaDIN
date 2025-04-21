using Negocio;
using Presentacion;
using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class AddEmpleadoForm : Form
    {
        public AddEmpleadoForm()
        {
            InitializeComponent();
        }


        private void imgAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void imgNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            dgEmpleados.ClearSelection();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            dgEmpleados.ClearSelection();
        }

        private void imgEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgEmpleados.CurrentRow != null)
            {
                int indiceFilaSeleccionada = dgEmpleados.CurrentRow.Index;

                if (EmpleadoService.BorrarEmpleado(indiceFilaSeleccionada))
                {
                    MessageBox.Show("Empleado eliminado correctamente.");
                    MostrarEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el empleado.");
                }
            }
        }

        private void imgActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void AddEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            try
            {
                dgEmpleados.DataSource = EmpleadoService.GetEmpleados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las empleados. Compruebe " +
                    "la cadena de conexión a la Base de datos " + ex.Message);
            }
            //Limpiamos formulario para que al iniciar no haya un empleados
            //seleccionada por defecto
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            dgEmpleados.CurrentCell = null;
            txtnombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasenya.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            bool hayFilaSeleccionada = dgEmpleados.SelectedRows.Count > 0;

            btnAgregar.Enabled = !hayFilaSeleccionada;
            btnActualizar.Enabled = hayFilaSeleccionada;
            btnEliminar.Enabled = hayFilaSeleccionada;

            // Habilitar o deshabilitar imágenes
            imgAgregar.Enabled = !hayFilaSeleccionada;
            imgActualizar.Enabled = hayFilaSeleccionada;
            imgEliminar.Enabled = hayFilaSeleccionada;

            if (hayFilaSeleccionada)
            {
                DataGridViewRow fila = dgEmpleados.SelectedRows[0];

                txtnombre.Text = fila.Cells["nombre"].Value?.ToString() ?? "";
                txtApellido.Text = fila.Cells["apellido"].Value?.ToString() ?? "";
                txtUsuario.Text = fila.Cells["usuario"].Value?.ToString() ?? "";
                txtContrasenya.Text = fila.Cells["password"].Value?.ToString() ?? "";
            }
            else
            {
                LimpiarFormulario();
            }
        }

    }
}
