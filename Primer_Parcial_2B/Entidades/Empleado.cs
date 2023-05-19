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
        private bool admin;

        public Empleado(string nombre, string apellido, int dni, string usuario, string password, bool admin) : base(nombre, apellido, dni)
        {
            this.Password = password;
            this.Usuario = usuario;
            this.Admin = admin;

        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public bool Admin { get => admin; set => admin = value; }

        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }
    }
}
