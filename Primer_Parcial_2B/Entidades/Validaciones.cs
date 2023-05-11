using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumerado;

namespace Entidades
{
    public static class Validaciones
    {
        public static bool StringSoloLetras(string nombre)
        {
            nombre = nombre.ToLower();
            for (int i = 0; i < nombre.Length; i++)
            {
                if (!(nombre[i] >= 'a' && nombre[i] <= 'z' || nombre[i] == ' '))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool StringSoloNumeros(string cadena)
        {
            if(cadena is not null)
            {
                foreach (char c in cadena)
                {
                    if (!Char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            { return false; }
        }

        public static bool EsDNIValido(string dni)
        {
            if (dni.Length != 8 || dni[0] == '0')
            {
                return false;
            }
            else
            {
                foreach (char c in dni)
                {
                    if (!Char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool ValidarCampos(string nombre, string apellido, string dni, string usuario, string password)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.StringSoloLetras(nombre))
            {
                if (!string.IsNullOrEmpty(apellido) && Validaciones.StringSoloLetras(apellido))
                {
                    if (!string.IsNullOrEmpty(dni) && Validaciones.EsDNIValido(dni))
                    {
                        if (!string.IsNullOrEmpty(usuario))
                        {
                            if (!string.IsNullOrEmpty(password))
                            {
                                return true;
                            }
                        }                            
                    }
                }
            }
            return false;
        }
        public static bool ValidarCampos(string codigo, string nombre, string categoria, string precioVenta, string precioCompra, string cantidad)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                if (!string.IsNullOrEmpty(nombre))
                {
                    if (!string.IsNullOrEmpty(categoria))
                    {
                        if (!string.IsNullOrEmpty(precioVenta) && int.TryParse(precioVenta, out int numero))
                        {
                            if (!string.IsNullOrEmpty(precioCompra) && int.TryParse(precioCompra, out int numero2))
                            {
                                if (!string.IsNullOrEmpty(cantidad) && int.TryParse(cantidad, out int numero3))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static bool ValidarCampos(string numeroSerie, string TipoReparacion, string falla)
        {
            if (!string.IsNullOrEmpty(numeroSerie))
            {
                if (!string.IsNullOrEmpty(TipoReparacion))
                {
                    if (!string.IsNullOrEmpty(falla))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ValidarCamposReparacion(string presupuesto, string estado, string precio)
        {
            if (!string.IsNullOrEmpty(presupuesto))
            {
                if (!string.IsNullOrEmpty(estado))
                {
                    if (!string.IsNullOrEmpty(precio) && Validaciones.StringSoloNumeros(precio))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ValidarCamposClientes(string nombre, string apellido, string dni, string telefono, string direccion)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.StringSoloLetras(nombre))
            {
                if (!string.IsNullOrEmpty(apellido) && Validaciones.StringSoloLetras(apellido))
                {
                    if (!string.IsNullOrEmpty(dni) && Validaciones.EsDNIValido(dni))
                    {
                        if (!string.IsNullOrEmpty(telefono) && Validaciones.StringSoloNumeros(telefono))
                        {
                            if (!string.IsNullOrEmpty(direccion))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
