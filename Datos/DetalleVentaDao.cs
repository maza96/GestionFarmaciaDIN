using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    static public class DetalleVentaDao
    {
        private static readonly string cadenaConexion = Environment.GetEnvironmentVariable("DB_CONN_STRING");

        public static DataTable GetDetallesVenta()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT * FROM detalle_venta";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static void InsertarDetalleVenta(DetalleVenta detalle)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        INSERT INTO detalle_venta (id_venta, id_medicamento, cantidad, precio_unitario, subtotal)
                        VALUES (@id_venta, @id_medicamento, @cantidad, @precio_unitario, @subtotal);
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@id_venta", detalle.IdVenta);
                    cmd.Parameters.AddWithValue("@id_medicamento", detalle.IdMedicamento);
                    cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@precio_unitario", detalle.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@subtotal", detalle.Subtotal);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido insertar el detalle de venta.");
                    }
                }
            }
        }

        public static void BorrarDetalleVenta(int idVenta, int idMedicamento)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        DELETE FROM detalle_venta 
                        WHERE id_venta = @id_venta AND id_medicamento = @id_medicamento;
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@id_venta", idVenta);
                    cmd.Parameters.AddWithValue("@id_medicamento", idMedicamento);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido borrar el detalle de venta.");
                    }
                }
            }
        }
    }
}
