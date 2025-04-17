using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    static public class ProveedorDao
    {
        private static readonly string cadenaConexion = Environment.GetEnvironmentVariable("DB_CONN_STRING");

        public static DataTable GetProveedores()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT * FROM proveedores";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static void InsertarProveedor(Proveedor proveedor)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        INSERT INTO proveedores (nombre_proveedor, telefono, direccion)
                        VALUES (@nombre_proveedor, @telefono, @direccion);
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre_proveedor", proveedor.Nombre);
                    cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", proveedor.Direccion);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido insertar el proveedor.");
                    }
                }
            }
        }

        public static void BorrarProveedor(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM proveedores WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido borrar el proveedor.");
                    }
                }
            }
        }

        public static void UpdateProveedor(Proveedor proveedor)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        UPDATE proveedores SET
                            nombre_proveedor = @nombre_proveedor,
                            telefono = @telefono,
                            direccion = @direccion
                        WHERE id = @id;
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@id", proveedor.Id);
                    cmd.Parameters.AddWithValue("@nombre_proveedor", proveedor.Nombre);
                    cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", proveedor.Direccion);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido actualizar el proveedor.");
                    }
                }
            }
        }
    }
}
