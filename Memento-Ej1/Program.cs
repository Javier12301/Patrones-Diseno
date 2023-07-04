using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mementoclas;





namespace Memento_Ej1
{
    public class Program
    {
        
        static CareTaker caretaker = new CareTaker();

        static void Main(string[] args)
        {
            var persona1 = new Persona();
            persona1.Nombre = "Javier";

            caretaker.Add(persona1.saveToMemento());
            persona1.Nombre = "Javier2";
            caretaker.Add(persona1.saveToMemento());
            persona1.Nombre = "Javier3";
            caretaker.Add(persona1.saveToMemento());

            Memento m1 = caretaker.GetMemento(0);
            Console.WriteLine("Viendo memento 1: " + m1.Estado);
            Console.WriteLine("Viendo memento 2: " + caretaker.GetMemento(1).Estado);
            Console.WriteLine("Viendo memento 3: " + caretaker.GetMemento(2).Estado);
            persona1.restoreMemento(m1);
            Console.WriteLine("Viendo memento 1: " + m1.Estado);
            Console.ReadKey();
        }
    }
}
