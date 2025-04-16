using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    static public class VentaDao
    {
        private static string cadenaConexion = Environment.GetEnvironmentVariable("DB_CONN_STRING");

        public static DataTable GetVentas()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT * FROM ventas";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static void InsertarVenta(Venta venta)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        INSERT INTO ventas (fecha_venta, total)
                        VALUES (@fecha_venta, @total);
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha_venta", venta.Fecha_Venta);
                    cmd.Parameters.AddWithValue("@total", venta.Total);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido insertar la venta.");
                    }
                }
            }
        }

        public static void BorrarVenta(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ventas WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido borrar la venta.");
                    }
                }
            }
        }

        public static void UpdateVenta(Venta venta)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        UPDATE ventas SET
                            fecha_venta = @fecha_venta,
                            total = @total
                        WHERE id = @id;
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@id", venta.Id);
                    cmd.Parameters.AddWithValue("@fecha_venta", venta.Fecha_Venta);
                    cmd.Parameters.AddWithValue("@total", venta.Total);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido actualizar la venta.");
                    }
                }
            }
        }
    }
}
