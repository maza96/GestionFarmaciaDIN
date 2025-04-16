using System;

namespace Entidades
{
    public class Medicamento
    {
        private int idMedicamento;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private bool control;
        private DateTime fechaVencimiento;
        private decimal costo;
        private int idProveedor;

        public Medicamento(int idMedicamento, string nombre, string descripcion,
            int cantidad, bool control, DateTime fechaVencimiento,
            decimal costo, int idProveedor)
        {
            this.idMedicamento = idMedicamento;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.control = control;
            this.fechaVencimiento = fechaVencimiento;
            this.costo = costo;
            this.idProveedor = idProveedor;
        }

        public int Id
        {
            get { return idMedicamento; }
            set { idMedicamento = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public bool Control
        {
            get { return control; }
            set { control = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
    }
}
