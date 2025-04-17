using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    /// <summary>
    /// Clase de lógica de negocio para gestionar proveedores.
    /// Encapsula la interacción entre la capa de presentación y la base de datos.
    /// </summary>
    public static class ProveedorService
    {
        private static DataTable dataTable;

        // Se ejecuta una vez, la primera vez que se accede a cualquier miembro
        // estático de la clase (Inizialize)
        static ProveedorService()
        {
            dataTable = ProveedorDao.GetProveedores();
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["id_proveedor"] };
        }

        public static DataTable GetProveedores()
        {
            return dataTable;
        }

        public static bool InsertarProveedor(string nombreProveedor, string telefono, string direccion)
        {
            bool insertado = false;

            // Validación simple
            if (!string.IsNullOrWhiteSpace(nombreProveedor) && !string.IsNullOrWhiteSpace(telefono))
            {
                Proveedor nuevo = new Proveedor(0, nombreProveedor, telefono, direccion);

                ProveedorDao.InsertarProveedor(nuevo);

                // Crear nueva fila en la DataTable
                DataRow fila = dataTable.NewRow();
                fila["nombre_proveedor"] = nombreProveedor;
                fila["telefono"] = telefono;
                fila["direccion"] = direccion;

                dataTable.Rows.Add(fila);
                insertado = true;
            }

            return insertado;
        }

        public static bool BorrarProveedor(int indiceFilaSeleccionada)
        {
            bool borrado = false;

            int id = (int)dataTable.Rows[indiceFilaSeleccionada]["id_proveedor"];

            ProveedorDao.BorrarProveedor(id);

            dataTable.Rows.RemoveAt(indiceFilaSeleccionada);
            borrado = true;

            return borrado;
        }
    }
}
