using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class ArchivoTexto : IArchivo<string>
    {
        public ArchivoTexto()
        {
            
        }

        public void Escribir(string dato, string carpeta, string nombreArchivo)
        {
            try
            {
                if(!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    sw.WriteLine(dato);
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("ERROR al crear la carpeta");
            }
            catch (Exception)
            {
                throw new Exception("ERROR al escribir el archivo");
            }
        }

        public string Leer(string carpeta, string nombreArchivo)
        {
            StringBuilder sb = new StringBuilder();
            string linea;

            try
            {
                string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    while((linea = sr.ReadLine()) != null)
                    { 
                        sb.AppendLine(linea); 
                    }
                }

                return sb.ToString();
            }
            catch (Exception)
            {

                throw new Exception("ERROR al leer el archivo");
            }

        }
    }
}
