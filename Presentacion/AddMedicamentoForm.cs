using Datos;
using Entidades;
using Negocio;
using System.Data;

namespace Farmacia
{
    public partial class AddMedicamentoForm : Form
    {
        private List<Proveedor> proveedores = ProveedorDao.GetProveedoresList();

        // Inicializa el formulario y configura el combo de proveedores.
        public AddMedicamentoForm()
        {
            InitializeComponent();
            cbProveedores.DataSource = proveedores;
            cbProveedores.DisplayMember = "Nombre";
            cbProveedores.ValueMember = "Id";
        }
        //            ----------- MOSTRAR TODOS -----------

        // Evento que se dispara cuando se carga el formulario y llama a MostrarMedicamentos.
        private void AddMedicamento_Load(object sender, EventArgs e)
        {
            MostrarMedicamentos();
        }

        //                 ----------- AÑADIR -----------
        private void imgAgregar_Click(object sender, EventArgs e)
        {
            InsertarMedicamento();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarMedicamento();
        }

        //                  ----------- LIMPIAR -----------
        private void imgNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        //                  ----------- ELIMINAR -----------
        private void imgEliminar_Click(object sender, EventArgs e)
        {
            EliminarMedicamentoSeleccionado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMedicamentoSeleccionado();
        }

        //               ----------- ACTUALIZAR -----------
        private void imgActualizar_Click(object sender, EventArgs e)
        {
            ActualizarMedicamento();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarMedicamento();
        }

        // Muestra los medicamentos en el DataGridView.
        private void MostrarMedicamentos()
        {
            try
            {
                dgMedicamentos.DataSource = MedicamentoService.GetMedicamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las medicamentos. Compruebe " +
                    "la cadena de conexión a la Base de datos " + ex.Message);
            }
            LimpiarFormulario();
        }

        // Inserta un medicamento en la base de datos con los datos del formulario.
        private void InsertarMedicamento()
        {
            try
            {
                MedicamentoService.InsertarMedicamento(
                    txtNombre.Text,
                    txtDesc.Text,
                    (int)numCant.Value,
                    rbControl.Checked,
                    dtVencimiento.Value,
                    txtCosto.Text,
                    cbProveedores.SelectedValue?.ToString()
                );

                MessageBox.Show("Medicamento añadido correctamente!", "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarMedicamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error creando medicamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actualiza el medicamento seleccionado en la base de datos.
        private void ActualizarMedicamento()
        {
            try
            {
                string id = dgMedicamentos.SelectedRows[0].Cells["id_medicamento"].Value?.ToString() ?? "";

                MedicamentoService.ActualizarMedicamento(
                    id,
                    txtNombre.Text,
                    txtDesc.Text,
                    numCant.Value.ToString(),
                    rbControl.Checked,
                    dtVencimiento.Value,
                    txtCosto.Text,
                    cbProveedores.SelectedValue?.ToString()
                );

                MessageBox.Show("Medicamento actualizado correctamente.", "Actualización Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarMedicamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error actualizando medicamento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Elimina el medicamento seleccionado de la base de datos después de confirmación.
        private void EliminarMedicamentoSeleccionado()
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este medicamento?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgMedicamentos.SelectedRows[0].Cells["id_medicamento"].Value);
                    MedicamentoService.BorrarMedicamento(id);
                    MostrarMedicamentos(); // Refresh
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error eliminando Medicamento!");
                }
            }
        }



        // Limpia todos los campos del formulario y restablece los controles.
        private void LimpiarFormulario()
        {
            dgMedicamentos.CurrentCell = null;
            txtNombre.Clear();
            txtDesc.Clear();
            numCant.Value = 1;
            dtVencimiento.ResetText();
            rbControl.Checked = false;
            rbControl.ResetText();
            txtCosto.Clear();
            cbProveedores.SelectedIndex = -1;
        }

        //                ----------- CAMBIAR ITEM SELECCIONADO -----------

        // Maneja el cambio de selección en el DataGridView de medicamentos, habilitando o deshabilitando botones.
        private void dgMedicamentos_SelectionChanged(object sender, EventArgs e)
        {
            bool hayFilaSeleccionada = dgMedicamentos.SelectedRows.Count > 0;

            btnAgregar.Enabled = !hayFilaSeleccionada;
            btnActualizar.Enabled = hayFilaSeleccionada;
            btnEliminar.Enabled = hayFilaSeleccionada;

            imgAgregar.Enabled = !hayFilaSeleccionada;
            imgActualizar.Enabled = hayFilaSeleccionada;
            imgEliminar.Enabled = hayFilaSeleccionada;

            if (hayFilaSeleccionada)
            {
                DataGridViewRow fila = dgMedicamentos.SelectedRows[0];

                txtNombre.Text = fila.Cells["nombre"].Value?.ToString() ?? "";
                txtDesc.Text = fila.Cells["descripcion"].Value?.ToString() ?? "";
                txtCosto.Text = fila.Cells["costo"].Value?.ToString() ?? "";
                numCant.Value = Convert.ToDecimal(fila.Cells["cantidad"].Value);
                dtVencimiento.Value = Convert.ToDateTime(fila.Cells["fecha_vencimiento"].Value);
                rbControl.Checked = Convert.ToBoolean(fila.Cells["control"].Value);

                var proveedorId = Convert.ToInt32(fila.Cells["id_proveedor"].Value);
                cbProveedores.SelectedValue = proveedorId;
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void rbControl_Click(object sender, EventArgs e)
        {
            rbControl.Checked = !rbControl.Checked;
        }

        private void imgVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
