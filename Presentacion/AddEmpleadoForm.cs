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
            InsertarEmpleado();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarEmpleado();
        }

        private void imgNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void imgEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleadoSeleccionado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleadoSeleccionado();
        }

        private void imgActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();
        }

        private void AddEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        // Mostrar todos los empleados en el DataGridView.
        private void MostrarEmpleados()
        {
            try
            {
                dgEmpleados.DataSource = EmpleadoService.GetEmpleados();
                dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados. Compruebe " +
                    "la cadena de conexión a la base de datos: " + ex.Message);
            }
            LimpiarFormulario();
        }

        // Insertar un nuevo empleado.
        private void InsertarEmpleado()
        {
            try
            {
                // Suponemos que el servicio realiza la inserción sin devolver un valor de éxito.
                EmpleadoService.InsertarEmpleado(
                    txtnombre.Text,
                    txtApellido.Text,
                    txtUsuario.Text,
                    txtContrasenya.Text
                );

                MessageBox.Show("Empleado añadido correctamente!", "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error creando empleado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eliminar un empleado seleccionado.
        private void EliminarEmpleadoSeleccionado()
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este empleado?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgEmpleados.SelectedRows[0].Cells["id_empleado"].Value);

                    // No se espera un valor booleano, solo capturamos la excepción si ocurre.
                    EmpleadoService.BorrarEmpleado(id);

                    MessageBox.Show("Empleado eliminado correctamente.");
                    MostrarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error eliminando empleado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Actualizar un empleado seleccionado.
        private void ActualizarEmpleado()
        {
            try
            {
                string id = dgEmpleados.SelectedRows[0].Cells["id_empleado"].Value?.ToString() ?? "";

                // No se espera un valor booleano, solo capturamos la excepción si ocurre.
                EmpleadoService.ActualizarEmpleado(id, txtnombre.Text,
                    txtApellido.Text, txtUsuario.Text, txtContrasenya.Text);

                MessageBox.Show("Empleado actualizado correctamente.", "Actualización Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error actualizando empleado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiar el formulario.
        private void LimpiarFormulario()
        {
            dgEmpleados.CurrentCell = null;
            txtnombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasenya.Clear();
        }

        // Cambiar la selección del DataGridView.

        private void dgEmpleados_SelectionChanged_1(object sender, EventArgs e)
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

        private void imgVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
