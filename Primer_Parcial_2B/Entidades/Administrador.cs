using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {
        private string usuario;
        private string password;

        public Administrador(string nombre, string apellido, int dni, string usuario, string password) : base(nombre, apellido, dni, usuario, password)
        {
            this.password = password;
            this.usuario = usuario;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }
    }
}
