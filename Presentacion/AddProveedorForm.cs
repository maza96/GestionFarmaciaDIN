using Negocio;
using Presentacion;
using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class AddProveedorForm : Form
    {
        public AddProveedorForm()
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

        private void AddProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedores();
        }

        private void MostrarProveedores()
        {
            try
            {
                dgProveedores.DataSource = ProveedorService.GetProveedores();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las proveedores. Compruebe " +
                    "la cadena de conexión a la Base de datos " + ex.Message);
            }
            //Limpiamos formulario para que al iniciar no haya un proveedor
            //seleccionada por defecto
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            dgProveedores.CurrentCell = null;
            txtnombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void dgProveedores_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
