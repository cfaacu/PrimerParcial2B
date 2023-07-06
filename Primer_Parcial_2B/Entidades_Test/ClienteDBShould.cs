using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Archivos;
using Entidades.DB_SQL;

namespace Entidades_Test
{
    [TestClass]
    public class ClienteDBShould
    {
        [TestMethod]
        public void AgregarValido()
        {
            //ARRANGE
            ClienteDB db = new ClienteDB();
            Cliente cliente = new Cliente("Prueba", "Prueba", 85248985, "direccionPrueba", 11111111);
            Cliente clienteAux = new Cliente();
            //ACT
            db.Agregar(cliente);
            clienteAux = db.Traer("85248985");
            //ASSERT
            Assert.IsTrue(cliente.Nombre == clienteAux.Nombre);

            db.Borrar("85248985");
        }

        [TestMethod]
        public void AgregarEsperaException()
        {
            //ARRANGE
            ClienteDB db = new ClienteDB();
            Cliente cliente = new Cliente();
            //ACT

            //ASSERT
            Assert.ThrowsException<SqlException>(() =>
            {
                db.Agregar(cliente);
            });

            db.Borrar("85248985");
        }
    }
}
