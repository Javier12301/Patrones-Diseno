using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClases
{
    public class CareTaker
    {
        // creamos una lista de mementos
        private List<Memento> _mementos = new List<Memento>();

        // creamos una función para agregar mementos a la lista
        public void Add(Memento m)
        {
            // agregamos el memento a la lista
            _mementos.Add(m);
        }

        // creamos una función para obtener un memento de la lista
        public Memento GetMemento(int index)
        {
            return _mementos[index];
        }

    }
}
