using MySql.Data.MySqlClient;
using System.Data;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDatos
{
    static public class VentaDao
    {
        private static readonly string cadenaConexion = Environment.GetEnvironmentVariable("DB_CONN_STRING");

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

        public static int InsertarVenta(Venta venta)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // Insertamos la venta
                        string queryVenta = "INSERT INTO ventas (fecha_venta, total) VALUES (@fecha, @total)";
                        MySqlCommand cmdVenta = new MySqlCommand(queryVenta, conn, trans);
                        cmdVenta.Parameters.AddWithValue("@fecha", venta.Fecha_Venta);
                        cmdVenta.Parameters.AddWithValue("@total", venta.Total);
                        cmdVenta.ExecuteNonQuery();

                        int idVenta = (int)cmdVenta.LastInsertedId;

                        // Insertamos los detalles
                        foreach (var detalle in venta.Detalles)
                        {
                            string queryDetalle = @"INSERT INTO detalle_venta (id_venta, id_medicamento, cantidad, precio_unitario, subtotal)
                                            VALUES (@idVenta, @idMedicamento, @cantidad, @precio, @subtotal)";
                            MySqlCommand cmdDetalle = new MySqlCommand(queryDetalle, conn, trans);
                            cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                            cmdDetalle.Parameters.AddWithValue("@idMedicamento", detalle.IdMedicamento);
                            cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("@precio", detalle.PrecioUnitario);
                            cmdDetalle.Parameters.AddWithValue("@subtotal", detalle.Subtotal);
                            cmdDetalle.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return idVenta;
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        throw new Exception("Error al insertar la venta con sus detalles.");
                    }
                }
            }
        }

        public static DataTable ObtenerFactura(int idVenta)
        {
            DataTable dtFactura = new DataTable();

            using (var conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT * FROM VistaFactura WHERE id_venta = @id", conn);
                cmd.Parameters.AddWithValue("@id", idVenta);

                using (var reader = cmd.ExecuteReader())
                {
                    dtFactura.Load(reader);
                }
            }

            return dtFactura;
        }

        public static DataTable ObtenerMedicamentosMasVendidos(int year, int month)
        {
            DataTable dt = new DataTable();

            using (var conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();

                var cmd = new MySqlCommand(@"
                    SELECT
                        m.nombre AS Medicamento,
                        SUM(d.cantidad) AS TotalVendidos
                    FROM
                        detalle_venta d
                    JOIN
                        medicamentos m ON d.id_medicamento = m.id_medicamento
                    JOIN
                        ventas v ON v.id_venta = d.id_venta  -- Asegúrate de hacer el JOIN con la tabla 'ventas'
                    WHERE
                        YEAR(v.fecha_venta) = @year AND MONTH(v.fecha_venta) = @month  -- Cambié 'd.fecha_venta' por 'v.fecha_venta'
                    GROUP BY
                        m.nombre
                    ORDER BY
                        TotalVendidos DESC", conn);


                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@month", month);

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }


    }
}
