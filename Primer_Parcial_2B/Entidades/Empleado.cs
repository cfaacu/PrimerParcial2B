using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DB_SQL;

namespace Entidades
{
    public class Empleado : Persona, IABM<Empleado>
    {
        private string? usuario;
        private string? password;
        private bool admin;
        EmpleadoDB dbEmpleadoService;

        public Empleado(string? nombre, string? apellido, int dni, string? usuario, string? password, bool admin) : base(nombre, apellido, dni)
        {
            this.Password = password;
            this.Usuario = usuario;
            this.Admin = admin;
            dbEmpleadoService = new EmpleadoDB();
        }
        public Empleado()
        {
            dbEmpleadoService = new EmpleadoDB();
        }

        public string? Usuario { get => usuario; set => usuario = value; }
        public string? Password { get => password; set => password = value; }
        public bool Admin { get => admin; set => admin = value; }

        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }

        public bool Agregar()
        {
            try
            {
                dbEmpleadoService.Agregar(this);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(Empleado obj)
        {
            try
            {
                dbEmpleadoService.Editar(obj);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Borrar()
        {
            try
            {
                dbEmpleadoService.Borrar(this.Dni.ToString());
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
