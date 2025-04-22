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

        public static List<Proveedor> GetProveedoresList()
        {
            List<Proveedor> proveedores = new List<Proveedor> ();
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = "SELECT * FROM proveedores";

                using (var comando = new MySqlCommand(query, conn))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Proveedor proveedor = new Proveedor(
                                reader.GetInt32("id_proveedor"),
                                reader.GetString("nombre"),
                                reader.GetString("telefono"),
                                reader.GetString("direccion")
                        );
                        proveedores.Add(proveedor);
                    }
                }
            }
            return proveedores;
        }

        public static void InsertarProveedor(Proveedor proveedor)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        INSERT INTO proveedores (nombre, telefono, direccion)
                        VALUES (@nombre, @telefono, @direccion);
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
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
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM proveedores WHERE id_proveedor = @id_proveedor", conn))
                {
                    cmd.Parameters.AddWithValue("@id_proveedor", id);
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido borrar el proveedor.");
                    }
                }
            }
        }

        public static void ActualizarProveedor(Proveedor proveedor)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        UPDATE proveedores SET
                            nombre = @nombre,
                            telefono = @telefono,
                            direccion = @direccion
                        WHERE id_proveedor = @id_proveedor;
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@id_proveedor", proveedor.Id);
                    cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
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
