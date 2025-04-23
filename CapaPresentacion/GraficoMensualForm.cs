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
    public partial class GraficoMensualForm : Form
    {
        private int mes;
        private int anyo;
        public GraficoMensualForm(int mes, int anyo)
        {
            InitializeComponent();
            this.mes = mes;
            this.anyo = anyo;
        }

        private void GraficoMensualForm_Load(object sender, EventArgs e)
        {
            MostrarInformeDeVentas(anyo, mes);
        }

        private void MostrarInformeDeVentas(int year, int month)
        {
            // Obtener los datos de los medicamentos más vendidos
            DataTable dt = VentaDao.ObtenerMedicamentosMasVendidos(year, month);

            // Ahora pasar el DataSet al ReportViewer
            reportViewer1.LocalReport.ReportPath = "VentasMensual.rdlc"; // Ruta del informe RDLC

            // Limpiar cualquier DataSource previo
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("GraficoDataSet", dt));

            // Refrescar el informe
            reportViewer1.RefreshReport();
        }

    }
}
