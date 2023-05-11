using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private Stack<Producto> carrito;
        private double precioTotal;
        Cliente cliente;

        public Stack<Producto> Carrito { get => carrito; set => carrito = value; }
        public double PrecioTotal { get => precioTotal;}
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public Venta(Cliente cliente, Stack<Producto> carrito)
        {
            this.Carrito = carrito;
            this.Cliente = cliente;
            this.precioTotal = 0;
            foreach (Producto item in carrito)
            {
                this.precioTotal = precioTotal + item.PrecioVenta;
            }
        }
        public Venta(Cliente cliente, Stack<Producto> carrito, double precioTotal)
        {
            this.Carrito = carrito;
            this.Cliente = cliente;
            this.precioTotal = precioTotal;
        }
        public Venta()
        {

        }

    }
}
