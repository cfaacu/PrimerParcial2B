using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reparacion
    {
        private Cliente cliente;
        private string numeroSerie;
        private Enumerado.ETiposDeReparaciones tipoDeReparacion;
        private Enumerado.EEstado estado;
        private string falla;
        private string presupuesto;
        private double precio;

        public string NumeroSerie { get => numeroSerie;}
        public Enumerado.ETiposDeReparaciones TipoDeReparacion { get => tipoDeReparacion; set => tipoDeReparacion = value; }
        public Enumerado.EEstado Estado { get => estado; set => estado = value; }
        public string Presupuesto { get => presupuesto; set => presupuesto = value; }
        public double Precio { get => precio; set => precio = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string Falla { get => falla; set => falla = value; }

        public Reparacion(string numeroSerie, Enumerado.ETiposDeReparaciones tipoDeReparacion, Cliente cliente, string falla)
        {
            this.numeroSerie = numeroSerie;
            this.TipoDeReparacion = tipoDeReparacion;
            this.Estado = Enumerado.EEstado.Abierto;
            Cliente = cliente;
            Falla = falla;
        }

        public Reparacion(string numeroSerie, Enumerado.ETiposDeReparaciones tipoDeReparacion, Enumerado.EEstado estado, string presupuesto, double precio, Cliente cliente, string falla) : this(numeroSerie,tipoDeReparacion,cliente,falla)
        {
            this.Presupuesto = presupuesto;
            this.Precio = precio;
            this.estado = estado;
        }
    }
}
