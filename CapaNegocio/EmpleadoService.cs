using System;
using System.Data;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public static class EmpleadoService
    {
        private static DataTable dataTable;

        static EmpleadoService()
        {
            dataTable = EmpleadoDao.GetEmpleados();
        }

        public static DataTable GetEmpleados()
        {
            return dataTable;
        }

        public static void InsertarEmpleado(string nombre, string apellido, string usuario, string password)
        {
            StringBuilder errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(nombre))
                errores.AppendLine("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(apellido))
                errores.AppendLine("El apellido no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(usuario))
                errores.AppendLine("El nombre de usuario no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(password))
                errores.AppendLine("La contraseña no puede estar vacía.");

            if (errores.Length > 0)
                throw new Exception(errores.ToString());

            try
            {
                Empleado nuevo = new Empleado(0, nombre, apellido, usuario, password);
                EmpleadoDao.InsertarEmpleado(nuevo);
                dataTable = EmpleadoDao.GetEmpleados();
            }
            catch (Exception ex)
            {
                throw new Exception("Error insertando empleado: " + ex.Message);
            }
        }

        public static void BorrarEmpleado(int id)
        {
            try
            {
                EmpleadoDao.BorrarEmpleado(id);
                dataTable = EmpleadoDao.GetEmpleados();
            }
            catch (Exception ex)
            {
                throw new Exception("Error borrando empleado: " + ex.Message);
            }
        }

        public static void ActualizarEmpleado(string idStr, string nombre, string apellido, string usuario, string password)
        {
            StringBuilder errores = new StringBuilder();

            if (!int.TryParse(idStr, out int id) || id <= 0)
                errores.AppendLine("ID del empleado inválido.");

            if (string.IsNullOrWhiteSpace(nombre))
                errores.AppendLine("El nombre del empleado no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(apellido))
                errores.AppendLine("El apellido del empleado no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(usuario))
                errores.AppendLine("El nombre de usuario no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(password))
                errores.AppendLine("La contraseña no puede estar vacía.");

            if (errores.Length > 0)
                throw new Exception(errores.ToString());

            try
            {
                Empleado empleadoActualizado = new Empleado(id, nombre, apellido, usuario, password);
                EmpleadoDao.UpdateEmpleado(empleadoActualizado);
                dataTable = EmpleadoDao.GetEmpleados();
            }
            catch (Exception ex)
            {
                throw new Exception("Error actualizando empleado: " + ex.Message);
            }
        }

        public static Empleado Autenticar(string usuario, string password)
        {
            Empleado empleado = EmpleadoDao.GetEmpleadoPorLogin(usuario, password);
            return empleado ?? null;
        }
    }
}
