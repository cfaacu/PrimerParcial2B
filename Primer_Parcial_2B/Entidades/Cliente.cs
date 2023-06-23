using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DB_SQL;

namespace Entidades
{
    public class Cliente : Persona, IABM<Cliente>
    {
        private int telefono;
        private string direccion;
        private List<Reparacion> reparaciones;
        ClienteDB dbClienteService;

        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
  
        public Cliente(string nombre, string apellido, int dni, string direccion, int telefono) : base(nombre, apellido, dni)
        {
            this.Telefono = telefono;
            this.Direccion = direccion;
            reparaciones = new List<Reparacion>();
            dbClienteService = new ClienteDB();
        }
        public Cliente()
        {
            dbClienteService = new ClienteDB();
        }
        public void AgregarReparacion(Reparacion reparacion)
        {
            if(reparacion != null)
            {
                reparaciones.Add(reparacion);
            }
        }

        public void EliminarReparacion(Reparacion reparacion)
        {
            if(reparacion != null)
            {
                reparaciones.Remove(reparacion);
            }
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(Direccion);
            sb.AppendLine(Telefono.ToString());

            return sb.ToString();
        }

        public bool Agregar()
        {
            try
            {
                dbClienteService.Agregar(this);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(Cliente obj)
        {
            try
            {
                dbClienteService.Editar(obj);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Borrar()
        {
            try
            {
                dbClienteService.Borrar(this.Dni.ToString());
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
