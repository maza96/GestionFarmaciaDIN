using Negocio;
using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class AddMedicamento : Form
    {
        public AddMedicamento()
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

        private void imgCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void imgActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void AddMedicamento_Load(object sender, EventArgs e)
        {
            MostrarMedicamentos();
        }

        private void MostrarMedicamentos()
        {
            try
            {
                dgMedicamentos.DataSource = MedicamentoService.GetMedicamentos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las películas. Compruebe " +
                    "la cadena de conexión a la Base de datos " + ex.Message);
            }
            //Limpiamos formulario para que al iniciar no haya un Peli
            //seleccionada por defecto
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            dgMedicamentos.CurrentCell = null;
            txtnombre.Clear();
            txtDesc.Clear();
            numCant.Value = 1;
            dtVencimiento.ResetText();
            rbControl.ResetText();
            txtCosto.Clear();
        }
    }
}
