using CapaDatos;
using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FacturaForm : Form
    {
        private int idVenta;
        public FacturaForm(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            MostrarFactura(idVenta);
        }

        public void MostrarFactura(int idVenta)
        {
            // Obtener los datos de la venta directamente desde el DAO (ya que ahora estamos usando la vista combinada)
            DataTable dtFactura = VentaDao.ObtenerFactura(idVenta);

            // Ahora pasar el DataSet al ReportViewer
            reportViewer1.LocalReport.ReportPath = "Factura.rdlc"; // Ruta del informe RDLC

            // Limpiar cualquier DataSource previo
            reportViewer1.LocalReport.DataSources.Clear();

            // Especifica que el origen de datos es el DataTable (con la vista combinada)
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("VentasDataSet", dtFactura));

            // Refrescar el informe
            reportViewer1.RefreshReport();
        }

    }
}
