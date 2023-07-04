using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mementoclas
{
    public class Persona
    {
        // get y set para el nombre
        public string Nombre { get; set; }

        // guardamos el estado de la persona
        public Memento saveToMemento()
        {
            Console.WriteLine("Originator: Guardando memento para " + Nombre);
            return new Memento(Nombre);
        }

        // restauramos el estado de la persona
        public void restoreMemento(Memento m)
        {
            Nombre = m.Estado;
            Console.WriteLine("Originator: Recuperando memento " + Nombre);
        }
    }
}
