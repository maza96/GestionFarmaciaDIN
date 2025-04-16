using System;

namespace Entidades
{
    public class Proveedor
    {
        private int id;
        private string nombre;
        private string telefono;
        private string direccion;

        public Proveedor(int id, string nombre, string telefono, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
