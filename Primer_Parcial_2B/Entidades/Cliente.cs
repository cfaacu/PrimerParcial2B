using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int telefono;
        private string direccion;
        private List<Reparacion> reparaciones;

        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
  
        public Cliente(string nombre, string apellido, int dni, string direccion, int telefono) : base(nombre, apellido, dni)
        {
            this.Telefono = telefono;
            this.Direccion = direccion;
            reparaciones = new List<Reparacion>();
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
    }
}
