using System;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        private int idVenta;
        private int idMedicamento;
        private string nombreMedicamento;
        private int cantidad;
        private float precioUnitario;
        private float subtotal => Cantidad * PrecioUnitario;

        public DetalleVenta(int idVenta, int idMedicamento, int cantidad,
            float precioUnitario)
        {
            this.idVenta = idVenta;
            this.idMedicamento = idMedicamento;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
        }
        public DetalleVenta(int idVenta, int idMedicamento, string nombreMedicamento, int cantidad,
            float precioUnitario)
        {
            this.idVenta = idVenta;
            this.idMedicamento = idMedicamento;
            this.nombreMedicamento = nombreMedicamento;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
        }


        public DetalleVenta(int idMedicamento, int cantidad,
            float precioUnitario)
        {
            this.idMedicamento = idMedicamento;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
        }

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public int IdMedicamento
        {
            get { return idMedicamento; }
            set { idMedicamento = value; }
        }

        public string NombreMedicamento
        {
            get { return nombreMedicamento; }
            set { nombreMedicamento = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public float PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
        }
    }
}
