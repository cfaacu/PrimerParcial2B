using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Entidades.Enumerado;
using System.Xml.Serialization;
using Google.Type;

namespace Entidades.Archivos
{
    public class Serializadora<T> : IArchivo<T>
    {
        private ETipo tipo;
        public Serializadora(ETipo tipo)
        {
            this.tipo = tipo;
        }

        public void Escribir(T dato, string carpeta, string nombreArchivo)
        {
            try
            {
                string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

                if (this.tipo == ETipo.XML)
                {
                    if (Path.GetExtension(rutaCompleta) == ".xml")
                    {
                        using (StreamWriter xml = new StreamWriter(rutaCompleta))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            xmlSerializer.Serialize(xml, dato);
                        }
                    }
                    else
                    {
                        throw new Exception("Extension invalida para tipo XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(rutaCompleta) == ".json")
                    {
                        ArchivoTexto json = new ArchivoTexto();
                        JsonSerializerOptions option = new JsonSerializerOptions();
                        option.WriteIndented = true;
                        json.Escribir(JsonSerializer.Serialize(dato, typeof(T), option), carpeta, nombreArchivo);
                    }
                    else
                    {
                        throw new Exception("Extension invalida para tipo JSON");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Leer(string carpeta, string nombreArchivo)
        {
            T dato;
            try
            {
                string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

                if (this.tipo == ETipo.XML)
                {
                    if (Path.GetExtension(nombreArchivo) == ".xml")
                    {
                        using (StreamReader xml = new StreamReader(rutaCompleta))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            dato = (T)xmlSerializer.Deserialize(xml);
                            return dato;
                        }
                    }
                    else
                    {
                        throw new Exception("Extension invalida");
                    }
                }
                else
                {
                    T datoAux;
                    if (Path.GetExtension(nombreArchivo) == ".json")
                    {
                        string objetoJson = File.ReadAllText(rutaCompleta);

                        datoAux = JsonSerializer.Deserialize<T>(objetoJson);
                        return datoAux;
                    }
                    else
                    {
                        throw new Exception("Extension invalida");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
