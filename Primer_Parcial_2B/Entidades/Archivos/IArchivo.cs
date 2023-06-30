using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public interface IArchivo<T>
    {
        public void Escribir(T dato, string carpeta, string nombreArchivo);

        public T Leer(string carpeta, string nombreArchivo);
    }
}