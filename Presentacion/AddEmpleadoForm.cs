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

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void imgEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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
    }
}
