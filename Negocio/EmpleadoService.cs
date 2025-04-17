using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    /// <summary>
    /// Clase de lógica de negocio para gestionar empleados.
    /// Encapsula la interacción entre la capa de presentación y la base de datos.
    /// </summary>
    public static class EmpleadoService
    {
        private static DataTable dataTable;

        // Se ejecuta una vez la primera vez que se accede a cualquier miembro estático de la clase
        static EmpleadoService()
        {
            dataTable = EmpleadoDao.GetEmpleados();
            dataTable.PrimaryKey = [dataTable.Columns[0]]; // Asumiendo que la primera columna es el ID
        }

        public static DataTable GetEmpleados()
        {
            return dataTable;
        }

        public static bool InsertarEmpleado(string nombre, string apellido, string usuario, string password)
        {
            bool insertado = false;

            // Validación simple
            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(usuario))
            {
                Empleado nuevo = new Empleado(0, nombre, apellido, usuario, password);

                EmpleadoDao.InsertarEmpleado(nuevo);

                // Crear nueva fila en la DataTable
                DataRow fila = dataTable.NewRow();
                fila["nombre"] = nombre;
                fila["apellido"] = apellido;
                fila["usuario"] = usuario;
                fila["password"] = password;

                dataTable.Rows.Add(fila);
                insertado = true;
            }

            return insertado;
        }

        public static bool BorrarEmpleado(int indiceFilaSeleccionada)
        {
            bool borrado = false;

            int id = (int)dataTable.Rows[indiceFilaSeleccionada]["id_empleado"];

            EmpleadoDao.BorrarEmpleado(id);

            dataTable.Rows.RemoveAt(indiceFilaSeleccionada);
            borrado = true;

            return borrado;
        }
    }
}
