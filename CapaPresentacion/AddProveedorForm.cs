using CapaNegocio;
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
            InsertarProveedor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarProveedor();
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
            EliminarProveedorSeleccionado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedorSeleccionado();
        }

        private void imgActualizar_Click(object sender, EventArgs e)
        {
            ActualizarProveedor();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarProveedor();
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
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            dgProveedores.CurrentCell = null;
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void InsertarProveedor()
        {
            try
            {
                ProveedorService.InsertarProveedor(txtNombre.Text, txtTelefono.Text, txtDireccion.Text);

                MessageBox.Show("Proveedor añadido correctamente!", "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error creando proveedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarProveedor()
        {
            try
            {
                string id = dgProveedores.SelectedRows[0].Cells["id_proveedor"].Value?.ToString() ?? "";

                ProveedorService.ActualizarProveedor(id, txtNombre.Text, txtTelefono.Text, txtDireccion.Text);

                MessageBox.Show("Proveedor actualizado correctamente!", "Actualización Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error actualizando proveedor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarProveedorSeleccionado()
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este proveedor?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgProveedores.SelectedRows[0].Cells["id_proveedor"].Value);
                    ProveedorService.BorrarProveedor(id);
                    MostrarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error eliminando Proveedor!");
                }
            }
        }

        private void dgProveedores_SelectionChanged(object sender, EventArgs e)
        {
            bool hayFilaSeleccionada = dgProveedores.SelectedRows.Count > 0;

            btnAgregar.Enabled = !hayFilaSeleccionada;
            btnActualizar.Enabled = hayFilaSeleccionada;
            btnEliminar.Enabled = hayFilaSeleccionada;

            imgAgregar.Enabled = !hayFilaSeleccionada;
            imgActualizar.Enabled = hayFilaSeleccionada;
            imgEliminar.Enabled = hayFilaSeleccionada;

            if (hayFilaSeleccionada)
            {
                DataGridViewRow fila = dgProveedores.SelectedRows[0];

                txtNombre.Text = fila.Cells["nombre"].Value?.ToString() ?? "";
                txtDireccion.Text = fila.Cells["direccion"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["telefono"].Value?.ToString() ?? "";
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
