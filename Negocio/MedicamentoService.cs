using System.Data;
using Datos;
using Entidades;

namespace Negocio
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
            dataTable.PrimaryKey = [dataTable.Columns[0]];
        }

        public static DataTable GetMedicamentos()
        {
            return dataTable;
        }

        public static bool InsertarMedicamento(string nombre, string descripcion, int cantidad,
            bool control, DateTime fechaVencimiento, decimal costo, int idProveedor)
        {
            bool insertado = false;

            // Validación simple
            if (!string.IsNullOrWhiteSpace(nombre) && cantidad > 0 && costo > 0)
            {
                Medicamento nuevo = new Medicamento(0, nombre, descripcion, cantidad,
                    control, fechaVencimiento, costo, idProveedor);

                MedicamentoDao.InsertarMedicamento(nuevo);

                // Crear nueva fila en la DataTable
                DataRow fila = dataTable.NewRow();
                fila["nombre"] = nombre;
                fila["descripcion"] = descripcion;
                fila["cantidad"] = cantidad;
                fila["control"] = control;
                fila["fecha_vencimiento"] = fechaVencimiento;
                fila["costo"] = costo;
                fila["id_proveedor"] = idProveedor;

                dataTable.Rows.Add(fila);
                insertado = true;
            }

            return insertado;
        }

        public static bool BorrarMedicamento(int indiceFilaSeleccionada)
        {
            bool borrado = false;

            int id = (int)dataTable.Rows[indiceFilaSeleccionada]["id_medicamento"];

            MedicamentoDao.BorrarMedicamento(id);

            dataTable.Rows.RemoveAt(indiceFilaSeleccionada);
            borrado = true;

            return borrado;
        }
    }
}
