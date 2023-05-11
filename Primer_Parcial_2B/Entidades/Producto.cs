﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string codigo;
        private string nombre;
        private int cantidad;
        private Enumerado.ECategoria categoria;
        private double precioVenta;
        private double precioCompra;

        public string Codigo { get => codigo; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Enumerado.ECategoria Categoria { get => categoria; set => categoria = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Producto(string codigo, string nombre, Enumerado.ECategoria categoria, double precioVenta, double precioCompra, int cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precioVenta = precioVenta;
            this.precioCompra = precioCompra;
            this.cantidad = cantidad;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(codigo.ToString());
            sb.AppendLine(nombre);
            sb.AppendLine(categoria.ToString());
            sb.AppendLine(precioVenta.ToString());
            sb.AppendLine(precioCompra.ToString());
            sb.AppendLine(cantidad.ToString());

            return sb.ToString();
        }
    }
}
