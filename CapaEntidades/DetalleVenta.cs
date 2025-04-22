using System;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        private int idVenta;
        private int idMedicamento;
        private int cantidad;
        private float precioUnitario;
        private float subtotal;

        public DetalleVenta(int idVenta, int idMedicamento, int cantidad,
            float precioUnitario, float subtotal)
        {
            this.idVenta = idVenta;
            this.idMedicamento = idMedicamento;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            this.subtotal = subtotal;
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
            set { subtotal = value; }
        }
    }
}
