using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB_SQL
{
    public abstract class DbManager
    {
        private SqlConnection conexion;
        private string stringConexion;
        public SqlConnection GetConnection { get { return this.conexion; } }


        public DbManager()
        {
            this.stringConexion = "Server=.;Database=ParcialLaboratorio;Trusted_Connection=True;";
            conexion = new SqlConnection(stringConexion);

        }
        public void Conectar()
        {
            conexion.Open();
        }

        public void Cerrar()
        {
            conexion.Close();
        }


    }
}
