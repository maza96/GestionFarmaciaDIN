using System;

namespace CapaEntidades
{
    public class Venta
    {
        private int id;
        private DateTime fecha_venta;
        private float total;

        public Venta(int id, DateTime fecha_venta, float total)
        {
            this.id = id;
            this.fecha_venta = fecha_venta;
            this.total = total;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Fecha_Venta
        {
            get { return fecha_venta; }
            set { fecha_venta = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
