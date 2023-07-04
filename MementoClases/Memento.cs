using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClases
{
    public class Memento
    {
        private string _estado;

        public Memento() { }

        // constructor con parametros
        public Memento(string estado)
        {
            _estado = estado;
        }

        // creamos un getter para el estado
        public string Estado
        {
            get
            {
                return _estado;
            }
        }

    }
}
