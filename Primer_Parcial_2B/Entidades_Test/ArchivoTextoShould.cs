using Entidades;
using Entidades.Archivos;

namespace Entidades_Test
{
    [TestClass]
    public class ArchivoTextoShould
    {
        [TestMethod]
        public void LogErroresEscrituraValida()
        {
            //ARRANGE
            ArchivoTexto archivo = new ArchivoTexto();
            Exception ex = new Exception("ExceptionTest");
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LogError.txt");
            string datos;
            //ACT
            archivo.LogErrores(ex);
            datos = archivo.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LogError.txt");
            //ASSERT
            Assert.IsTrue(datos.Contains(ex.Message));
            Assert.IsTrue(datos.Contains(ex.GetType().FullName));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LogErroresFallaException()
        {
            //ARRANGE
            ArchivoTexto archivo = new ArchivoTexto();
            Exception ex = null;
            
            //ACT
            archivo.LogErrores(ex);
            //ASSERT
        }
    }
}