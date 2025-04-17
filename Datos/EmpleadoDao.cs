 using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    static public class EmpleadoDao
    {
        private static readonly string cadenaConexion = Environment.GetEnvironmentVariable("DB_CONN_STRING");

        public static DataTable GetEmpleados()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT * FROM empleados";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static void InsertarEmpleado(Empleado empleado)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        INSERT INTO empleados (nombre, apellido, usuario, password)
                        VALUES (@nombre, @apellido, @usuario, @password);
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);
                    cmd.Parameters.AddWithValue("@password", empleado.Password);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido insertar el empleado.");
                    }
                }
            }
        }

        public static void BorrarEmpleado(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM empleados WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido borrar el empleado.");
                    }
                }
            }
        }

        public static void UpdateEmpleado(Empleado empleado)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        UPDATE empleados SET
                            nombre = @nombre,
                            apellido = @apellido,
                            usuario = @usuario,
                            password = @password
                        WHERE id = @id;
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@id", empleado.Id);
                    cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);
                    cmd.Parameters.AddWithValue("@password", empleado.Password);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido actualizar el empleado.");
                    }
                }
            }
        }
    }
}
