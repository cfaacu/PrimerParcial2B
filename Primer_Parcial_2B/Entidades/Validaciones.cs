using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Entidades.Enumerado;

namespace Entidades
{
    public static class Validaciones
    {
        public static bool StringSoloLetras(string nombre)
        {
            bool retorno;

            if(Validaciones.StringCargado(nombre))
            {
                // Expresión regular que permite solo letras y letras con acento
                Regex regex = new Regex(@"^[a-zA-ZáÁéÉíÍóÓúÚüÜñÑ\s]+$");

                if( regex.IsMatch(nombre))
                {
                    return true;
                }
                else
                {
                    throw new DatosInvalidosException("ERROR Ingrese un string solo de letras");
                }
            }
            else
            {
                throw new DatosInvalidosException("ERROR complete los campos vacios");
            }
        }

        public static bool StringCargado(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) == false)
            {
                foreach (char item in cadena)
                {
                    if (item != ' ')
                    {
                        return true;
                    }
                }
            }
            throw new DatosInvalidosException("Ingrese los datos");
        }
        public static bool StringSoloNumeros(string cadena)
        {
            bool retorno;
            if (Validaciones.StringCargado(cadena))
            {
                foreach (char c in cadena)
                {
                    if (!Char.IsDigit(c))
                    {
                        throw new DatosInvalidosException("Ingrese un string solo numeros");
                    }
                }
                retorno = true;
            }
            else
            { throw new DatosInvalidosException("Ingrese un string solo letras"); }

            return retorno;
        }

        public static bool EsDNIValido(string dni)
        {
            bool retorno;

            if (dni.Length != 8 || dni[0] == '0' || string.IsNullOrEmpty(dni) && Validaciones.StringCargado(dni))
            {
                retorno = false;
            }
            else
            {
                foreach (char c in dni)
                {
                    if (!Char.IsDigit(c))
                    {
                        throw new DatosInvalidosException("DNI invalido");
                    }
                }
                retorno = true;
            }

            return retorno;
        }
        public static bool ValidarCampos(string nombre, string apellido, string dni, string usuario, string password)
        {
            if (Validaciones.StringSoloLetras(nombre))
            {
                if (Validaciones.StringSoloLetras(apellido))
                {
                    if (Validaciones.EsDNIValido(dni))
                    {
                        if (Validaciones.StringCargado(usuario))
                        {
                            if (Validaciones.StringCargado(password))
                            {
                                return true;
                            }
                        }                            
                    }
                }
            }
            throw new DatosInvalidosException("Datos incorrectos");
        }
        public static bool ValidarCampos(string codigo, string nombre, string categoria, string precioVenta, string precioCompra, string cantidad)
        {
            if (Validaciones.StringCargado(codigo) &&
                Validaciones.StringCargado(nombre) &&
                Validaciones.StringCargado(categoria) &&
                Validaciones.NumerosPositivos(precioVenta) &&
                Validaciones.NumerosPositivos(precioCompra) &&
                Validaciones.NumerosPositivos(cantidad))
            {
                return true;
            }
            throw new DatosInvalidosException("Datos incorrectos");
        }

        public static bool ValidarCampos(string numeroSerie, string TipoReparacion, string falla)
        {
            if (Validaciones.StringCargado(numeroSerie))
            {
                if (Validaciones.StringCargado(TipoReparacion))
                {
                    if (Validaciones.StringCargado(falla))
                    {
                        return true;
                    }
                }
            }
            throw new DatosInvalidosException("Datos incorrectos");
        }

        public static bool ValidarCamposReparacion(string presupuesto, string estado, string precio)
        {
            if (Validaciones.StringCargado(presupuesto))
            {
                if (Validaciones.StringCargado(estado))
                {
                    if (Validaciones.NumerosPositivos(precio))
                    {
                        return true;
                    }
                }
            }
            throw new DatosInvalidosException("Datos incorrectos");
        }

        public static bool ValidarCamposClientes(string nombre, string apellido, string dni, string telefono, string direccion)
        {
            if (Validaciones.StringSoloLetras(nombre))
            {
                if (Validaciones.StringSoloLetras(apellido))
                {
                    if (Validaciones.EsDNIValido(dni))
                    {
                        if (Validaciones.StringSoloNumeros(telefono))
                        {
                            if (Validaciones.StringCargado(direccion))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            throw new DatosInvalidosException("Datos incorrectos");
        }

        public static bool NumerosPositivos(string numero)
        {
            if(double.TryParse(numero, out double numeroInt))
            {
                if(numeroInt > 0)
                {
                    return true;
                }
            }
            throw new DatosInvalidosException("Numero Negativo");
        }

        public static bool ValidarProducto(ProductoVenta producto)
        {
            return (producto.Producto is not null && producto.Cantidad > 0 && ValidarStock(producto.Producto, producto.Cantidad));
        }
        private static bool ValidarStock(Producto producto, int cantidad)
        {
            return producto.Cantidad >= cantidad;
        }
    }
}
