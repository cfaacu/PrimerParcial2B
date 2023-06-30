using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Archivos;

namespace Entidades
{
    public class Venta
    {
        //private Stack<ProductoVenta> carrito;
        Guid idVenta;
        double precioTotal;
        Cliente cliente;
        List<ProductoVenta> detalle = new List<ProductoVenta>();
        DateTime fecha;
        public delegate void TicketDelegate();
        public event TicketDelegate TicketGenerado;
        Serializadora<string> ser;

        public Guid IdVenta { get => idVenta; set => idVenta = value; }
        public double PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<ProductoVenta> Detalle { get => detalle; set => detalle = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Venta(Cliente cliente, Stack<ProductoVenta> carrito) : this()
        {
            this.Cliente = cliente;
            this.PrecioTotal = 0;
        }
        public Venta(Cliente cliente, Stack<ProductoVenta> carrito, double precioTotal) : this(cliente, carrito)
        {
            this.PrecioTotal = precioTotal;
        }
        public Venta()
        {
            ser = new Serializadora<string>(Enumerado.ETipo.XML);
        }

        public double CalcularPrecioTotal()
        {
            double total = 0;
            foreach (ProductoVenta item in this.Detalle)
            {
                total = total + (item.Producto.PrecioVenta * item.Cantidad);
            }
            return total;
        }

        public void GenerarTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*************** TICKET ***************");
            sb.AppendLine($"Codigo de compra: {this.IdVenta}");
            sb.AppendLine($"Fecha: {this.Fecha}");
            sb.AppendLine($"Cliente: {this.Cliente.Nombre} {this.cliente.Apellido}");
            sb.AppendLine("Artículos:");
            foreach (var articulo in Detalle)
            {
                sb.AppendLine($"- {articulo.Producto.Nombre}   Cantidad: {articulo.Cantidad}");
            }
            sb.AppendLine($"Total: ${this.PrecioTotal}");
            sb.AppendLine("***************************************");

            ser.Escribir(sb.ToString(), Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Ticket.xml");

            TicketGenerado.Invoke();
        }
    }
    
}
