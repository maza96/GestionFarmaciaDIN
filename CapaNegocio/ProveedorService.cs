using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
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
            //dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["id_proveedor"] };
        }

        public static DataTable GetProveedores()
        {
            return dataTable;
        }

        public static void InsertarProveedor(string nombre, string telefono, string direccion)
        {
            StringBuilder errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(nombre))
                errores.AppendLine("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(telefono) || !Regex.IsMatch(telefono, @"^\d{9}$"))
                errores.AppendLine("El teléfono debe contener 9 dígitos.");
            if (string.IsNullOrWhiteSpace(direccion))
                errores.AppendLine("La direccion no puede estar vacía.");

            if (errores.Length > 0)
                throw new Exception(errores.ToString());

            try
            {
                Proveedor nuevo = new Proveedor(0, nombre, telefono, direccion);
                ProveedorDao.InsertarProveedor(nuevo);
                dataTable = ProveedorDao.GetProveedores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error insertando proveedor: " + ex.Message);
            }
        }

        public static void ActualizarProveedor(string idStr, string nombre, string telefono, string direccion)
        {
            StringBuilder errores = new StringBuilder();

            if (!int.TryParse(idStr, out int id) || id <= 0)
                errores.AppendLine("ID del proveedor inválido.");
            if (string.IsNullOrWhiteSpace(nombre))
                errores.AppendLine("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(telefono) || !Regex.IsMatch(telefono, @"^\d{9}$"))
                errores.AppendLine("El teléfono debe contener 9 dígitos.");
            if (string.IsNullOrWhiteSpace(direccion))
                errores.AppendLine("La direccion no puede estar vacía.");

            if (errores.Length > 0)
                throw new Exception(errores.ToString());

            try
            {
                Proveedor nuevo = new Proveedor(id, nombre, telefono, direccion);
                ProveedorDao.ActualizarProveedor(nuevo);
                dataTable = ProveedorDao.GetProveedores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error actualizando proveedor: " + ex.Message);
            }
        }

        public static void BorrarProveedor(int id)
        {
            try
            {
                ProveedorDao.BorrarProveedor(id);
                dataTable = ProveedorDao.GetProveedores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error borrando proveedor: " + ex.Message);
            }
        }
    }
}
