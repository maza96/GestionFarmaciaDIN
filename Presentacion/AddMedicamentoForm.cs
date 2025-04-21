using Datos;
using Entidades;
using Negocio;
using Presentacion;
using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class AddMedicamentoForm : Form
    {
        private List<Proveedor> proveedores = ProveedorDao.GetProveedoresList();
        public AddMedicamentoForm()
        {
            InitializeComponent();
        }


        private void imgAgregar_Click(object sender, EventArgs e)
        {
            InsertarMedicamento();
        }

        private void InsertarMedicamento()
        {
            try
            {
                /*MedicamentoService.InsertarMedicamento(txtNombre.Text, 
                    txtDesc.Text, numCant.Value, rbControl.Checked, 
                    dtVencimiento.Value, txtCosto.Text, );*/
                /*private int idMedicamento;
                private string nombre;
                private string descripcion;
                private int cantidad;
                private bool control;
                private DateTime fechaVencimiento;
                private decimal costo;
                private int idProveedor;*/


    }catch (Exception ex)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarMedicamento();
        }

        private void imgNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void imgCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
                MessageBox.Show("Error al cargar las medicamentos. Compruebe " +
                    "la cadena de conexión a la Base de datos " + ex.Message);
            }
            //Limpiamos formulario para que al iniciar no haya un Peli
            //seleccionada por defecto
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            dgMedicamentos.CurrentCell = null;
            txtNombre.Clear();
            txtDesc.Clear();
            numCant.Value = 1;
            dtVencimiento.ResetText();
            rbControl.ResetText();
            txtCosto.Clear();
        }
    }
}
