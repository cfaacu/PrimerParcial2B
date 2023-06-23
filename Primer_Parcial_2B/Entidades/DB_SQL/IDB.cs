using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB_SQL
{
    public interface IDB<T>
    {
        public List<T> TraerTodo();
        public T Traer(string id);
        public bool Borrar(string id);
        public bool Agregar(T obj);
        public bool Editar(T obj);
    }
}
