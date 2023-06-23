using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IABM<T>
    {
        public bool Agregar();
        public bool Modificar(T obj);
        public bool Borrar();
    }
}
