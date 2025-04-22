using System;
using System.Data;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    /// <summary>
    /// Clase de lógica de negocio para gestionar medicamentos.
    /// Encapsula la interacción entre la capa de presentación y la base de datos.
    /// </summary>
    public static class MedicamentoService
    {
        private static DataTable dataTable;

        // Sejecuta una vez, la primera vez que se accede a cualquier miembro
        // estático de la clase (Inizialize)
        static MedicamentoService()
        {
            dataTable = MedicamentoDao.GetMedicamentos();
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[0] }; // Usamos `new DataColumn[]`
        }

        public static DataTable GetMedicamentos()
        {
            return dataTable;
        }

        public static void InsertarMedicamento(string nombre, string descripcion, int cantidad,
            bool control, DateTime fechaVencimiento, string costoStr, string proveedorIdStr)
        {
            StringBuilder errores = new StringBuilder();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(nombre))
                errores.AppendLine("El nombre del medicamento no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(descripcion))
                errores.AppendLine("La descripción del medicamento no puede estar vacía.");

            // Parseo con validación
           
            if (cantidad <= 0)
                errores.AppendLine("La cantidad debe ser un número entero mayor que 0.");

            if (!float.TryParse(costoStr, out float costo) || costo <= 0)
                errores.AppendLine("El costo debe ser un número mayor que 0.");

            if (!int.TryParse(proveedorIdStr, out int idProveedor) || idProveedor <= 0)
                errores.AppendLine("Debe seleccionar un proveedor válido.");

            if (fechaVencimiento <= DateTime.Now)
                errores.AppendLine("La fecha de vencimiento debe ser posterior a hoy.");

            if (errores.Length > 0)
                throw new Exception(errores.ToString());

            try
            {
                Medicamento medicamento = new Medicamento(0, nombre, descripcion, cantidad, control, fechaVencimiento, costo, idProveedor);
                MedicamentoDao.InsertarMedicamento(medicamento);

                dataTable = MedicamentoDao.GetMedicamentos();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void ActualizarMedicamento(string idStr, string nombre, string descripcion, string cantidadStr,
            bool control, DateTime fechaVencimiento, string costoStr, string proveedorIdStr)
        {
            StringBuilder errores = new StringBuilder();

            if (!int.TryParse(idStr, out int id) || id <= 0)
                errores.AppendLine("ID del medicamento inválido.");

            if (string.IsNullOrWhiteSpace(nombre))
                errores.AppendLine("El nombre del medicamento no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(descripcion))
                errores.AppendLine("La descripción del medicamento no puede estar vacía.");

            if (!int.TryParse(cantidadStr, out int cantidad) || cantidad <= 0)
                errores.AppendLine("La cantidad debe ser un número entero mayor que 0.");

            if (!float.TryParse(costoStr, out float costo) || costo <= 0)
                errores.AppendLine("El costo debe ser un número mayor que 0.");

            if (!int.TryParse(proveedorIdStr, out int idProveedor) || idProveedor <= 0)
                errores.AppendLine("Debe seleccionar un proveedor válido.");

            if (fechaVencimiento <= DateTime.Now)
                errores.AppendLine("La fecha de vencimiento debe ser posterior a hoy.");

            if (errores.Length > 0)
                throw new Exception(errores.ToString());

            try
            {
                Medicamento medicamento = new Medicamento(id, nombre, descripcion, cantidad, control, fechaVencimiento, costo, idProveedor);
                MedicamentoDao.ModificarMedicamento(medicamento);
                dataTable = MedicamentoDao.GetMedicamentos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void BorrarMedicamento(int id)
        {
            try
            {
                // Realizar la eliminación en la base de datos usando el DAO
                MedicamentoDao.BorrarMedicamento(id);
                dataTable = MedicamentoDao.GetMedicamentos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
