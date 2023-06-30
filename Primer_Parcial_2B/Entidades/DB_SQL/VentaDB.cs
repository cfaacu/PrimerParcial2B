using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB_SQL
{
    public class VentaDB : DbManager
    {
        SqlCommand command;
        ClienteDB clientService;
        ProductoDB productService;
        public VentaDB()
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.GetConnection;
            clientService = new ClienteDB();
            productService = new ProductoDB();
        }


        public async Task<bool> Agregar(Venta obj)
        {

            StringBuilder sb = new StringBuilder(); 

            try
            {
                this.Conectar();

                command.Parameters.Clear();
                string queryVentas = "INSERT INTO ventas (idVenta, idCliente, fecha) VALUES (@idVenta, @idCliente, @fecha)";
                command.CommandText = queryVentas;
                command.Parameters.AddWithValue("@idVenta", obj.IdVenta);
                command.Parameters.AddWithValue("@idCliente", obj.Cliente.Dni);
                command.Parameters.AddWithValue("@fecha", obj.Fecha);
                await command.ExecuteNonQueryAsync();


                command.Parameters.Clear();
                int counter = 0;
                obj.Detalle.ForEach((x) =>
                {
                    sb.AppendLine($"INSERT INTO detalles_ventas (idVenta, codigoProducto, cantidad) VALUES (@idVenta{counter}, @codigoProducto{counter}, @cantidad{counter})");
                    sb.AppendLine($"UPDATE productos SET cantidad = cantidad-@cantidad{counter} WHERE codigo = @codigoProducto{counter}");
                    command.Parameters.AddWithValue($"@idVenta{counter}", obj.IdVenta);
                    command.Parameters.AddWithValue($"@codigoProducto{counter}", x.Producto.Codigo);
                    command.Parameters.AddWithValue($"@cantidad{counter}", x.Cantidad);

                    counter++;
                });

                command.CommandText = sb.ToString();
                await command.ExecuteNonQueryAsync();
                return true;
            }
            catch(DbException dbEx)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: Hubo un problema al intentar agregar el producto a la base de datos.\n{ex.Message}");
            }
            finally
            {
                this.Cerrar();
            }
        }

        public Venta Traer(string id)
        {
            try
            {
                List<Venta> aux = TraerTodo();
                if (id != null)
                {
                    Guid idVentaGuid = Guid.Parse(id);
                    foreach (Venta item in aux)
                    {
                        if (item.IdVenta == idVentaGuid)
                        {
                            return item;
                        }
                    }
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public List<Venta> TraerTodo()
        {
            List<Venta> ventas = new();
            try
            {
                command.Parameters.Clear();
                this.Conectar();
                var query = "SELECT * FROM ventas";
                command.CommandText = query;

                List<Dictionary<string, object>> ventaRows = new List<Dictionary<string, object>>(); // Almacenar los resultados del primer SqlDataReader

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> ventaRow = new Dictionary<string, object>();
                        ventaRow["idVenta"] = reader["idVenta"].ToString();
                        ventaRow["fecha"] = reader["fecha"].ToString();
                        ventaRow["idCliente"] = reader["idCliente"].ToString();
                        ventaRows.Add(ventaRow);
                    }
                }

                // Cerrar el primer SqlDataReader antes de ejecutar el segundo comando
                command.Dispose();
                command = new SqlCommand();
                command.Connection = this.GetConnection;
                command.CommandType = CommandType.Text;

                foreach (Dictionary<string, object> ventaRow in ventaRows)
                {
                    Venta ventita = new();
                    ventita.IdVenta = Guid.Parse(ventaRow["idVenta"].ToString());
                    ventita.Fecha = DateTime.Parse(ventaRow["fecha"].ToString());
                    ventita.Cliente = clientService.Traer(ventaRow["idCliente"].ToString());
                    var query2 = "SELECT * FROM VENTAS as v INNER JOIN detalles_ventas as dv on v.idVenta = dv.idVenta WHERE v.idVenta = @id";
                    command.Parameters.AddWithValue("@id", ventita.IdVenta);
                    command.CommandText = query2;

                    using (SqlDataReader prodctsReader = command.ExecuteReader())
                    {
                        while (prodctsReader.Read())
                        {
                            var codigoProducto = prodctsReader["codigoProducto"].ToString();
                            var cantidad = int.Parse(prodctsReader["cantidad"].ToString());
                            ventita.Detalle.Add(new ProductoVenta
                            {
                                Producto = productService.Traer(codigoProducto),
                                Cantidad = cantidad
                            });
                        }
                    }

                    ventas.Add(ventita);
                    command.Parameters.Clear();
                }

                return ventas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.Cerrar();
            }
        }

    }
}
