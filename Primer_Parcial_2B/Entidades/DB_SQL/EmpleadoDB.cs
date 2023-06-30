using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Google.Api.Gax.Grpc.Gcp.AffinityConfig.Types;

namespace Entidades.DB_SQL
{
    public class EmpleadoDB : DbManager, IDB<Empleado>
    {
        private static SqlCommand command;

        public EmpleadoDB() : base()
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;

        }

        public bool Agregar(Empleado obj)
        {
            try
            {
                command.Connection = base.GetConnection;
                this.Conectar();

                command.CommandText = "INSERT INTO empleados (dni, nombre, apellido, usuario, password, esAdmin) " +
                                      "VALUES (@dni, @nombre, @apellido, @usuario, @password, @esAdmin)";
                command.Parameters.AddWithValue("@dni", obj.Dni);
                command.Parameters.AddWithValue("@nombre", obj.Nombre);
                command.Parameters.AddWithValue("@apellido", obj.Apellido);
                command.Parameters.AddWithValue("@usuario", obj.Usuario);
                command.Parameters.AddWithValue("@password", obj.Password);
                command.Parameters.AddWithValue("@esAdmin", obj.Admin);
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
                command.Connection = base.GetConnection;
                this.Conectar();

                command.CommandText = "DELETE FROM empleados WHERE dni = @dni";
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

        public bool Editar(Empleado obj)
        {
            try
            {
                command.Connection = base.GetConnection;
                this.Conectar();
                var query = "UPDATE empleados SET nombre = @nombre, apellido = @apellido, usuario = @usuario, password = @password, esAdmin = @esAdmin  WHERE dni = @dni";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", obj.Nombre);
                command.Parameters.AddWithValue("@apellido", obj.Apellido);
                command.Parameters.AddWithValue("@usuario", obj.Usuario);
                command.Parameters.AddWithValue("@password", obj.Password);
                command.Parameters.AddWithValue("@esAdmin", obj.Admin);
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
            };
        }

        public List<Empleado> TraerTodo()
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                command.Connection = base.GetConnection;
                this.Conectar();

                command.CommandText = "SELECT * FROM empleados";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int dniInt = Convert.ToInt32(reader["dni"]);
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        string usuario = reader["usuario"].ToString();
                        string password = reader["password"].ToString();
                        bool esAdmin = bool.Parse(reader["esAdmin"].ToString());

                        Empleado empleado = new Empleado(nombre, apellido, dniInt, usuario, password,esAdmin);

                        empleados.Add(empleado);
                    }
                }

                return empleados;
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

        public Empleado Traer(string dni)
        {
            try
            {
                command.Connection = base.GetConnection;
                Empleado emp = null;
                this.Conectar();
                command.Parameters.Clear();

                command.CommandText = "SELECT * FROM empleados WHERE dni = @dni";
                command.Parameters.AddWithValue("@dni", dni);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int dniInt = Convert.ToInt32(reader["dni"]);
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        string usuario = reader["usuario"].ToString();
                        string password = reader["password"].ToString();
                        bool esAdmin = bool.Parse(reader["esAdmin"].ToString());

                       emp = new Empleado(nombre, apellido, dniInt, usuario, password, esAdmin);
                    }
                }
                if(emp != null)
                {
                    return emp;
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

        public Empleado TraerUser(string usuarioParam, string passwordParam)
        {
            try
            {
                command.Connection = base.GetConnection;

                Empleado emp = null;
                this.Conectar();
                command.Parameters.Clear();
                command.Connection = base.GetConnection;
                command.CommandText = "SELECT * FROM empleados WHERE usuario = @usuario AND password = @password";
                command.Parameters.AddWithValue("@usuario", usuarioParam);
                command.Parameters.AddWithValue("@password", passwordParam);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int dniInt = Convert.ToInt32(reader["dni"]);
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        string usuario = reader["usuario"].ToString();
                        string password = reader["password"].ToString();
                        bool esAdmin = bool.Parse(reader["esAdmin"].ToString());

                        emp =  new Empleado(nombre, apellido, dniInt, usuario, password, esAdmin);
                    }
                }
                if(emp != null)
                {
                    return emp;
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

        public Empleado TraerAdmin()
        {
            try
            {
                command.Connection = base.GetConnection;

                Empleado emp = null;
                this.Conectar();
                command.Parameters.Clear();

                command.CommandText = "SELECT * FROM empleados WHERE esAdmin = 1";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int dniInt = Convert.ToInt32(reader["dni"]);
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        string usuario = reader["usuario"].ToString();
                        string password = reader["password"].ToString();
                        bool esAdmin = bool.Parse(reader["esAdmin"].ToString());

                        emp = new Empleado(nombre, apellido, dniInt, usuario, password, esAdmin);
                    }
                }

                if (emp != null)
                {
                    return emp;
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

        public Empleado TraerEmpleado()
        {
            try
            {
                command.Connection = base.GetConnection;

                Empleado emp = null;
                this.Conectar();
                command.Parameters.Clear();

                command.CommandText = "SELECT * FROM empleados WHERE esAdmin = 0";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int dniInt = Convert.ToInt32(reader["dni"]);
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        string usuario = reader["usuario"].ToString();
                        string password = reader["password"].ToString();
                        bool esAdmin = bool.Parse(reader["esAdmin"].ToString());

                        emp = new Empleado(nombre, apellido, dniInt, usuario, password, esAdmin);
                    }
                }
                if(emp != null)
                {
                    return emp;
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
    }
}
