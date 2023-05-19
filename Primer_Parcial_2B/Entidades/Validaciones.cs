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
            bool retorno;

            if(Validaciones.StringCargado(nombre))
            {
                nombre = nombre.ToLower();
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (!(nombre[i] >= 'a' && nombre[i] <= 'z' || nombre[i] == ' '))
                    {
                        retorno = false;
                    }
                }
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
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
            return false;
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
                        retorno = false;
                    }
                }
                retorno = true;
            }
            else
            { retorno = false; }

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
                        retorno = false;
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
            return false;
        }
        public static bool ValidarCampos(string codigo, string nombre, string categoria, string precioVenta, string precioCompra, string cantidad)
        {
            if (Validaciones.StringCargado(codigo))
            {
                if (Validaciones.StringCargado(nombre))
                {
                    if (Validaciones.StringCargado(categoria))
                    {
                        if (Validaciones.NumerosPositivos(precioVenta))
                        {
                            if (Validaciones.NumerosPositivos(precioCompra))
                            {
                                if (Validaciones.NumerosPositivos(cantidad))
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
            return false;
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
            return false;
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
            return false;
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
            return false;
        }
    }
}
