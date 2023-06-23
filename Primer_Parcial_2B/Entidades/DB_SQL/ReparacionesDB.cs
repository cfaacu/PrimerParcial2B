using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB_SQL
{
    public class ReparacionesDB : DbManager, IDB<Reparacion>
    {

        SqlCommand command;
        ClienteDB dbClientService;
        public ReparacionesDB() {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.GetConnection;
            dbClientService = new ClienteDB();
        }
        public bool Agregar(Reparacion obj)
        {
            this.Conectar();
            var query = "INSERT INTO reparaciones (codigoReparacion, idCliente, numeroSerie, tipoDeReparacion, estado, falla, presupuesto, precio) " +
                "VALUES (@codigoReparacion, @idCliente, @numeroSerie, @tipoDeReparacion, @estado, @falla, @presupuesto, @precio)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@codigoReparacion", obj.Id);
            command.Parameters.AddWithValue("@idCliente", obj.Cliente.Dni);
            command.Parameters.AddWithValue("@numeroSerie", obj.NumeroSerie);
            command.Parameters.AddWithValue("@tipoDeReparacion", obj.TipoDeReparacion.ToString());
            command.Parameters.AddWithValue("@estado", obj.Estado);
            command.Parameters.AddWithValue("@falla", obj.Falla);

            if (!string.IsNullOrEmpty(obj.Presupuesto))
                command.Parameters.AddWithValue("@presupuesto", obj.Presupuesto);
            else
                command.Parameters.AddWithValue("@presupuesto", DBNull.Value);

            command.Parameters.AddWithValue("@precio", obj.Precio);
            command.CommandText = query;
            command.ExecuteNonQuery();
            this.Cerrar();
            return true;
        }

        public bool Borrar(string numeroSerie)
        {
            try
            {
                this.Conectar();

                command.CommandText = "DELETE FROM reparaciones WHERE numeroSerie = @numeroSerie";
                command.Parameters.AddWithValue("@numeroSerie", numeroSerie);
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

        public bool Editar(Reparacion obj)
        {
            try
            {
                this.Conectar();
                var query = "UPDATE reparaciones SET presupuesto = @presupuesto, precio = @precio, estado = @estado WHERE codigoReparacion = @codigoReparacion";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@codigoReparacion", obj.Id);
                // Manejo del valor nulo para el campo "presupuesto"
                if (!string.IsNullOrEmpty(obj.Presupuesto))
                    command.Parameters.AddWithValue("@presupuesto", obj.Presupuesto);
                else
                    command.Parameters.AddWithValue("@presupuesto", DBNull.Value);

                command.Parameters.AddWithValue("@precio", obj.Precio);
                command.Parameters.AddWithValue("@estado", (int)obj.Estado);
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

        public Reparacion Traer(string id)
        {
            Reparacion reparacion = new();

            try
            {
                this.Conectar();
                var query = "SELECT * FROM reparaciones WHERE numeroSerie = @codigoReparacion";
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@codigoReparacion", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reparacion = new Reparacion();
                        reparacion.Id = Guid.Parse(reader["codigoReparacion"].ToString());
                        reparacion.Cliente = dbClientService.Traer(reader["idCliente"].ToString());
                        reparacion.NumeroSerie = reader["numeroSerie"].ToString();
                        reparacion.TipoDeReparacion = ConvertTipoReparacion(reader["tipoDeReparacion"].ToString());
                        reparacion.Estado = (Enumerado.EEstado)int.Parse(reader["estado"].ToString());
                        reparacion.Falla = reader["falla"].ToString();
                        // Verificar si el campo "presupuesto" es nulo
                        if (!reader.IsDBNull(reader.GetOrdinal("presupuesto")))
                        {
                            reparacion.Presupuesto = reader["presupuesto"].ToString();
                        }
                        reparacion.Precio = Convert.ToDouble(reader["precio"]);
                    }
                }

                return reparacion;
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

        public List<Reparacion> TraerTodo()
        {
            List<Reparacion> reparaciones = new();

            try
            {
                this.Conectar();
                var query = "SELECT * FROM reparaciones";
                command.CommandText = query;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Reparacion reparacion;
                    while (reader.Read())
                    {
                        reparacion = new Reparacion();
                        reparacion.Id = Guid.Parse(reader["codigoReparacion"].ToString());
                        reparacion.Cliente = dbClientService.Traer(reader["idCliente"].ToString());
                        reparacion.NumeroSerie = reader["numeroSerie"].ToString();
                        reparacion.TipoDeReparacion = ConvertTipoReparacion(reader["tipoDeReparacion"].ToString());
                        reparacion.Estado = (Enumerado.EEstado)int.Parse(reader["estado"].ToString());
                        reparacion.Falla = reader["falla"].ToString();
                        // Verificar si el campo "presupuesto" es nulo
                        if (!reader.IsDBNull(reader.GetOrdinal("presupuesto")))
                        {
                            reparacion.Presupuesto = reader["presupuesto"].ToString();
                        }
                        reparacion.Precio = Convert.ToDouble(reader["precio"]);
                        reparaciones.Add(reparacion);
                    }
                }

                return reparaciones;
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


        public Enumerado.ETiposDeReparaciones ConvertTipoReparacion(string tipoReparacionStr)
        {
            if (!string.IsNullOrEmpty(tipoReparacionStr))
            {
                switch (tipoReparacionStr.ToLower())
                {
                    case "ps2":
                        return Enumerado.ETiposDeReparaciones.Ps2;
                    case "ps3":
                        return Enumerado.ETiposDeReparaciones.Ps3;
                    case "ps4":
                        return Enumerado.ETiposDeReparaciones.Ps4;
                    case "ps5":
                        return Enumerado.ETiposDeReparaciones.Ps5;
                    case "xbox360":
                        return Enumerado.ETiposDeReparaciones.Xbox360;
                    case "xboxone":
                        return Enumerado.ETiposDeReparaciones.XboxOne;
                    case "nintendoswitch":
                        return Enumerado.ETiposDeReparaciones.NintendoSwitch;
                    case "joystickps4":
                        return Enumerado.ETiposDeReparaciones.JoystickPs4;
                    case "joystickps5":
                        return Enumerado.ETiposDeReparaciones.JoystickPs5;
                    case "joystickxbox360":
                        return Enumerado.ETiposDeReparaciones.JoystickXbox360;
                    case "joystickxboxone":
                        return Enumerado.ETiposDeReparaciones.joystickXboxOne;
                    case "joyconizquierdo":
                        return Enumerado.ETiposDeReparaciones.JoyconIzquierdo;
                    case "joyconderecho":
                        return Enumerado.ETiposDeReparaciones.JoyconDerecho;
                    default:
                        throw new Exception("Valor de tipo de reparación inválido");
                }
            }
            throw new Exception("Excepcion personalizada para después");
        }
    }
}
