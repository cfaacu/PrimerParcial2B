using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Guid IdVenta { get => idVenta; set => idVenta = value; }
        public double PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<ProductoVenta> Detalle { get => detalle; set => detalle = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }


        // CONSTRUCTOR CON CLIENTE, SOBRECARGA DE OPERADORES PARA AGREGAR,RESTAR PRODUCTOS AL CARRITO
        // METODO CONCLUIRVENTA ACTIVAR UN EVENTO PARA VER SI SALIO TODO BIEN, VALIDAR
        // METODO PARA EXPORTAR TICKET O PDF O TXT
        // CREAR UNA EXCEPCION PARA PRODUCTONOTFOUND
        // METODO PARA CALCULAR EL TOTAL DEL CARRITO


        public Venta(Cliente cliente, Stack<ProductoVenta> carrito)
        {
            this.Cliente = cliente;
            this.PrecioTotal = 0;
            /*foreach (Producto item in carrito)
            {
                this.precioTotal = precioTotal + item.PrecioVenta;
            }
            */
        }
        public Venta(Cliente cliente, Stack<ProductoVenta> carrito, double precioTotal)
        {
            this.Cliente = cliente;
            this.PrecioTotal = precioTotal;
        }
        public Venta()
        {

        }

        public void TerminarVenta()
        {
            //VALIDACIONES

            //Recorrer carrito
            /*this.carrito.ToList().ForEach(producto =>
            {

            })
            */
            //
        }
    }
}
