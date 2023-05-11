using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        static public List<Empleado> listaEmpleados;
        static public List<Producto> listaProductos;
        static public List<Cliente> listaClientes;
        static public List<Venta> listaVentas;
        static private Stack<Producto> carrito;
        static public List<Reparacion> listaReparaciones;

        static Sistema()
        {
            listaEmpleados = new List<Empleado>();
            listaProductos = new List<Producto>();
            listaClientes = new List<Cliente>();
            listaVentas = new List<Venta>();
            carrito = new Stack<Producto>();
            listaReparaciones = new List<Reparacion>();
   
            Sistema.CargarDatos();
        }

        private static void CargarDatos()
        {
            Empleado emp1 = new Empleado("Facundo", "Careri", 42252911,"Facu", "asd123");
            Empleado emp2 = new Empleado("Pepe", "Gomez", 42252221,"Pepe1234", "123456");
            Administrador admin1 = new Administrador("admin", "admin", 12345678, "admin", "admin");
            Administrador admin2 = new Administrador("roberto", "carlos", 12345674, "robert123", "asd123");
            Producto producto1 = new Producto("123456","Gta 5", Enumerado.ECategoria.Juego,10000,5000,100);
            Producto producto2 = new Producto("42502f","PS4", Enumerado.ECategoria.Consola,120000,50000, 100);
            Producto producto3 = new Producto("TazaGow","Taza Ceramica Gow", Enumerado.ECategoria.Merchandising,1200,800, 100);
            Cliente cliente1 = new Cliente("Sofia", "Lopez", 32451978, "calle123", 1123289499);
            Cliente cliente2 = new Cliente("Luisito", "Comunica", 52451238, "Espacio", 1186129499);
            Cliente cliente3 = new Cliente("Emanuel", "Noir", 21451228, "KEPERSONAJES", 1186188669);
            Reparacion reparacion1 = new Reparacion("123456", Enumerado.ETiposDeReparaciones.JoystickPs4, cliente1, "No enciende");
            Reparacion reparacion2 = new Reparacion("123457", Enumerado.ETiposDeReparaciones.Ps3, cliente2, "Prende y apaga");
            carrito.Push(producto1);
            carrito.Push(producto2);
            carrito.Push(producto3);

            Venta venta1 = new Venta(cliente1, carrito);
            Venta venta2 = new Venta(cliente2, carrito);

            listaEmpleados.Add(emp1);
            listaEmpleados.Add(emp2);
            listaEmpleados.Add(admin1);
            listaEmpleados.Add(admin2);
            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
            listaVentas.Add(venta1);
            listaVentas.Add(venta2);
            listaReparaciones.Add(reparacion1);
            listaReparaciones.Add(reparacion2);
        }

        public static Empleado LoguearUsuario(string usuario, string password)
        {
            if ((!string.IsNullOrEmpty(usuario)) && (!string.IsNullOrEmpty(password)))
            {
                foreach (Empleado item in listaEmpleados)
                {
                    if (item.Usuario.Trim().ToLower() == usuario.Trim().ToLower() && item.Password.Trim() == password.Trim())
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static bool EliminarProducto(string codigo)
        {
            Producto producto = BuscarProducto(codigo);
            if(producto != null)
            {
                listaProductos.Remove(producto);
                return true;
            }
            return false;
        }

        public static bool Agregar(Producto producto)
        {
            if(producto != null)
            {
                listaProductos.Add(producto);
                return true;
            }
            return false;
        }

        public static Producto BuscarProducto(string codigo)
        {
            foreach (Producto item in listaProductos)
            {
                if (item.Codigo == codigo)
                {
                    return item;
                }
            }
            return null;
        }

        public static bool Agregar(Cliente cliente)
        {
            if (cliente != null)
            {
                listaClientes.Add(cliente);
                return true;
            }
            return false;
        }

        public static bool EliminarCliente(string dni)
        {
            Cliente cliente = BuscarCliente(dni);
            if (cliente != null)
            {
                listaClientes.Remove(cliente);
                return true;
            }
            return false;
        }

        public static Cliente BuscarCliente(string dni)
        {
            if(int.TryParse(dni, out int dniInt))
            {
                foreach (Cliente item in listaClientes)
                {
                    if (item.Dni == dniInt)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static Reparacion BuscarReparacion(string codigoSerie)
        {
            if (!string.IsNullOrEmpty(codigoSerie))
            {
                foreach (Reparacion item in listaReparaciones)
                {
                    if (item.NumeroSerie == codigoSerie)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static bool EliminarReparacion(string codigoSerie)
        {
            if (!string.IsNullOrEmpty(codigoSerie))
            {
                foreach (Reparacion item in listaReparaciones)
                {
                    if (item.NumeroSerie == codigoSerie)
                    {
                        Sistema.listaReparaciones.Remove(item);
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool RestarStock(Producto producto, string cantidad)
        {
            if(producto != null && int.TryParse(cantidad, out int cantidadInt))
            {
                if(producto.Cantidad >= cantidadInt)
                {
                    producto.Cantidad = producto.Cantidad - cantidadInt;
                    return true;
                }
            }
            return false;
        }
    }
}
