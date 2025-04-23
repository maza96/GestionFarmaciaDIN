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
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            string[] meses = new[] {
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"};
            cbMeses.Items.AddRange(meses);
            cbMeses.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void imgVolver_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            try
            {
                int mes = cbMeses.SelectedIndex + 1;
                int anyo = 2025;
                GraficoMensualForm graficoMensualForm = new GraficoMensualForm(mes, anyo);
                Hide();
                graficoMensualForm.ShowDialog();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al mostrar el informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
