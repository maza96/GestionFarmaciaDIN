using Farmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            AddMedicamentoForm medicamentosForm = new AddMedicamentoForm();
            Hide(); //Ocultar formulario
            medicamentosForm.ShowDialog();
            Show(); //Cuando meicamentos form se cierre
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AddProveedorForm proveedoresForm = new AddProveedorForm();
            Hide(); //Ocultar formulario
            proveedoresForm.ShowDialog();
            Show(); //Cuando proveedores form se cierre
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AddEmpleadoForm empleadosForm = new AddEmpleadoForm();
            Hide(); //Ocultar formulario
            empleadosForm.ShowDialog();
            Show(); //Cuando empleados form se cierre
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            AddVentaForm ventaForm = new AddVentaForm();
            Hide(); //Ocultar formulario
            ventaForm.ShowDialog();
            Show(); //Cuando venta form se cierre
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReportesForm reportesForm = new ReportesForm();
            Hide();
            reportesForm.ShowDialog();
            Show();
        }
    }
}
