using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Entidades.DB_SQL
{
    public class ClienteDB : DbManager, IDB<Cliente>
    {
        private SqlCommand command;

        public ClienteDB()
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.GetConnection;
        }
        public bool Agregar(Cliente obj)
        {
            try
            {
                this.Conectar();

                command.Parameters.Clear();
                command.CommandText = "INSERT INTO clientes (dni, nombre, apellido, telefono, direccion) " +
                                      "VALUES (@dni, @nombre, @apellido, @telefono, @direccion)";
                command.Parameters.AddWithValue("@dni", obj.Dni);
                command.Parameters.AddWithValue("@nombre", obj.Nombre);
                command.Parameters.AddWithValue("@apellido", obj.Apellido);
                command.Parameters.AddWithValue("@telefono", obj.Telefono);
                command.Parameters.AddWithValue("@direccion", obj.Direccion);
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
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM clientes WHERE dni = @dni";
                command.Parameters.AddWithValue("@dni", id);
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

        public bool Editar(Cliente obj)
        {
            try
            {
                this.Conectar();
                var query = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion  WHERE dni = @dni";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", obj.Nombre);
                command.Parameters.AddWithValue("@apellido", obj.Apellido);
                command.Parameters.AddWithValue("@telefono", obj.Telefono);
                command.Parameters.AddWithValue("@direccion",obj.Direccion);
                command.Parameters.AddWithValue("@dni", obj.Dni);
                command.CommandText = query;
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

        public Cliente Traer(string dni)
        {
            try
            {
                this.Conectar();
                command.Parameters.Clear();

                command.CommandText = "SELECT * FROM clientes WHERE dni = @dni";
                command.Parameters.AddWithValue("@dni", dni);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int dniInt = Convert.ToInt32(reader["dni"]);
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        int telefono = Convert.ToInt32(reader["telefono"]);
                        string direccion = reader["direccion"].ToString();

                        return new Cliente(nombre, apellido, dniInt, direccion, telefono);
                    }
                }

                return null;
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

        public List<Cliente> TraerTodo()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                this.Conectar();

                command.CommandText = "SELECT * FROM clientes";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int dniInt = Convert.ToInt32(reader["dni"]);
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        int telefono = Convert.ToInt32(reader["telefono"]);
                        string direccion = reader["direccion"].ToString();

                        Cliente cliente = new Cliente(nombre, apellido, dniInt, direccion, telefono);

                        clientes.Add(cliente);
                    }
                }

                return clientes;
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
