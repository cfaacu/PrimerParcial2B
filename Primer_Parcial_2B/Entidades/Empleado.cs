using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private string usuario;
        private string password;

        public Empleado(string nombre, string apellido, int dni, string usuario, string password) : base(nombre,apellido,dni)
        {
            this.Password = password;
            this.Usuario = usuario;
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }
    }
}
