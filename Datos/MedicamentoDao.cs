using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    static public class MedicamentoDao
    {
        private static readonly string cadenaConexion = Environment.GetEnvironmentVariable("DB_CONN_STRING");

        public static DataTable GetMedicamentos()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT * FROM medicamentos";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static void InsertarMedicamento(Medicamento medicamento)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        INSERT INTO medicamentos (nombre, descripcion, cantidad, 
                        control, fecha_vencimiento, costo, id_proveedor)
                        VALUES (@nombre, @descripcion, @cantidad, @control, 
                        @fecha_vencimiento, @costo, @id_proveedor);
                        """, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", medicamento.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", medicamento.Descripcion);
                    cmd.Parameters.AddWithValue("@cantidad", medicamento.Cantidad);
                    cmd.Parameters.AddWithValue("@control", medicamento.Control);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", medicamento.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@costo", medicamento.Costo);
                    cmd.Parameters.AddWithValue("@id_proveedor", medicamento.IdProveedor);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido crear el medicamento!");
                    }
                }
            }
        }

        public static void BorrarMedicamento(int id_medicamento)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM medicamentos WHERE id = @id_medicamento", conn))
                {
                    cmd.Parameters.AddWithValue("@id_medicamento", id_medicamento);
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido borrar el medicamento!");
                    }
                }
            }
        }

        public static void UpdateMedicamento(Medicamento medicamento)
        {
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("""
                        UPDATE medicamentos SET 
                            nombre = @nombre,
                            descripcion = @descripcion,
                            cantidad = @cantidad,
                            control = @control,
                            fecha_vencimiento = @fecha_vencimiento,
                            costo = @costo,
                            id_proveedor = @id_proveedor
                        WHERE id = @id;
                    """, conn))
                {
                    cmd.Parameters.AddWithValue("@id", medicamento.Id);
                    cmd.Parameters.AddWithValue("@nombre", medicamento.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", medicamento.Descripcion);
                    cmd.Parameters.AddWithValue("@cantidad", medicamento.Cantidad);
                    cmd.Parameters.AddWithValue("@control", medicamento.Control);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", medicamento.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@costo", medicamento.Costo);
                    cmd.Parameters.AddWithValue("@id_proveedor", medicamento.IdProveedor);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("No se ha podido actualizar el medicamento!");
                    }
                }
            }
        }
    }
}
