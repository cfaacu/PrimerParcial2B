using Entidades.DB_SQL;
using Entidades;
using System.Data.SqlClient;
using System.Data;

public class ProductoDB : DbManager, IDB<Producto>
{
    private SqlCommand command;

    public ProductoDB()
    {
        command = new SqlCommand();
        command.CommandType = CommandType.Text;
        command.Connection = this.GetConnection;
    }

    public bool Agregar(Producto obj)
    {
        try
        {
            this.Conectar();

            command.CommandText = "INSERT INTO Productos (codigo, nombre, cantidad, categoria, precioVenta, precioCompra) " +
                                  "VALUES (@codigo, @nombre, @cantidad, @categoria, @precioVenta, @precioCompra)";
            command.Parameters.AddWithValue("@codigo", obj.Codigo);
            command.Parameters.AddWithValue("@nombre", obj.Nombre);
            command.Parameters.AddWithValue("@cantidad", obj.Cantidad);
            command.Parameters.AddWithValue("@categoria", obj.Categoria.ToString());
            command.Parameters.AddWithValue("@precioVenta", obj.PrecioVenta);
            command.Parameters.AddWithValue("@precioCompra", obj.PrecioCompra);
            command.ExecuteNonQuery();

            return true;
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

    public bool Borrar(string id)
    {
        try
        {
            this.Conectar();

            command.CommandText = "DELETE FROM Productos WHERE codigo = @codigo";
            command.Parameters.AddWithValue("@codigo", id);
            command.ExecuteNonQuery();

            return true;
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

    public bool Editar(Producto obj)
    {
        try
        {
            this.Conectar();

            command.CommandText = "UPDATE Productos SET codigo = @codigo, nombre = @nombre, cantidad = @cantidad, " +
                                  "categoria = @categoria, precioVenta = @precioVenta, precioCompra = @precioCompra " +
                                  "WHERE codigo = @codigo";
            command.Parameters.AddWithValue("@codigo", obj.Codigo);
            command.Parameters.AddWithValue("@nombre", obj.Nombre);
            command.Parameters.AddWithValue("@cantidad", obj.Cantidad);
            command.Parameters.AddWithValue("@categoria", obj.Categoria.ToString());
            command.Parameters.AddWithValue("@precioVenta", obj.PrecioVenta);
            command.Parameters.AddWithValue("@precioCompra", obj.PrecioCompra);
            command.ExecuteNonQuery();

            return true;
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

    public Producto Traer(string codigoxd)
    {
        try
        {
            this.Conectar();
            command.Parameters.Clear();
            command.CommandText = "SELECT * FROM Productos WHERE codigo = @codigo";
            command.Parameters.AddWithValue("@codigo", codigoxd);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string codigo = reader["codigo"].ToString();
                    string nombre = reader["nombre"].ToString();
                    int cantidad = Convert.ToInt32(reader["cantidad"]);
                    string categoria = reader["categoria"].ToString();
                    double precioVenta = Convert.ToDouble(reader["precioVenta"]);
                    double precioCompra = Convert.ToDouble(reader["precioCompra"]);

                    return new Producto(codigo, nombre, this.ConvertCategoria(categoria), precioVenta, precioCompra, cantidad);
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            this.Cerrar();
        }

    }

    public Enumerado.ECategoria ConvertCategoria(string categoriaStr)
    {
        if (!string.IsNullOrEmpty(categoriaStr))
        {
            switch (categoriaStr.ToLower())
            {
                case "juego":
                    return Enumerado.ECategoria.Juego;
                case "accesorio":
                    return Enumerado.ECategoria.Accesorio;
                case "merchandising":
                    return Enumerado.ECategoria.Merchandising;
                case "consola":
                    return Enumerado.ECategoria.Consola;
                default:
                    return Enumerado.ECategoria.Otro;
            }
        }
        throw new Exception("Excepcion personalizada para despues");
        
    }
    public List<Producto> TraerTodo()
    {
        List<Producto> productos = new List<Producto>();

        try
        {
            this.Conectar();

            command.CommandText = "SELECT * FROM productos";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string codigo = reader["codigo"].ToString();
                    string nombre = reader["nombre"].ToString();
                    int cantidad = Convert.ToInt32(reader["cantidad"]);
                    string categoria = reader["categoria"].ToString();
                    double precioVenta = Convert.ToDouble(reader["precioVenta"]);
                    double precioCompra = Convert.ToDouble(reader["precioCompra"]);

                    Producto producto = new Producto(codigo, nombre, this.ConvertCategoria(categoria), precioVenta, precioCompra, cantidad);

                    productos.Add(producto);
                }
            }

            return productos;
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