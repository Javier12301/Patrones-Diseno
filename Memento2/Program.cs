using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Structural
{
    /// <summary>
    /// Memento Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel";
            s.Phone = "(123) 456-7890";
            s.Budget = 25000.0;

            // guardamos el estado actual
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Cambiamos el Originator

            s.Name = "Javier";
            s.Phone = "(312) 456-7890";
            s.Budget = 1000000.0;

            // guardamos otro estado en otro espacio de memoria
            ProspectMemory m2 = new ProspectMemory();
            m2.Memento = s.SaveMemento();

            // Cambiamos el Originator de nuevo
            s.Name = "Jorge";
            s.Phone = "3855219032";
            s.Budget = 4231;

            // Restauramos el estado que deseemos a traves de una pregunta:
            Console.WriteLine("¿Deseas restaurar el estado anterior? (y/n)");
            // si la respuesta es afirmativa, restauramos el estado anterior que sería m2
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                s.RestoreMemento(m2.Memento);
            }
            else
            {
                // Cerramos la aplicación
                Environment.Exit(0);
            }

            // Se preguntará de nuevo si se desea restaurar el estado anterior que sería el primero que se hizo
            Console.WriteLine("¿Deseas restaurar el estado anterior? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                s.RestoreMemento(m.Memento);
            }
            else
            {
                // Cerramos la aplicación
                Environment.Exit(0);
            }
            Console.ReadKey();


           
        }

        // Este es nuestro Originator
        public class SalesProspect
        {
            string name; // nombre
            string phone; // teléfono
            string budget; // presupuesto

            // creamos los getters y setters para el atributo Nombre
            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                    Console.WriteLine("Name: " + name);
                }
            }

            // creamos los gettes y setters para el atributo Teléfono
            public string Phone
            {
                get { return phone; }
                set
                {
                    phone = value;
                    Console.WriteLine("Phone: " + phone);
                }
            }

            public string Budget
            {
                get { return budget; }
                set
                {
                    budget = value;
                    Console.WriteLine("Budget: " + budget);
                }
            }

            // creamos un método para crear un Memento
            public Memento SaveMemento()
            {
                Console.WriteLine("\nSaving State --\n");
                return new Memento(name, phone, budget);
            }

            // creamos un método para restaurar un Memento
            public void RestoreMemento(Memento memento)
            {
                Console.WriteLine("\nRestoring State --\n");
                Name = memento.Name;
                Phone = memento.Phone;
                Budget = memento.Budget;
            }
        }

        // Creamos la clase Memento que es la que va a guardar el estado
        public class Memento
        {
            string name;
            string phone;
            string budget;

            // Creamos el constructor de la clase Memento
            public Memento(string name, string phone, string budget)
            {
                this.name = name;
                this.phone = phone;
                this.budget = budget;
            }

            // creamos los getters y setters para los atributos de la clase Memento
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }

            public string Budget
            {
                get { return budget; }
                set { budget = value; }
            }
        }

        // Creamos la clase Caretaker que es la que va a guardar los Mementos
        public class ProspectMemory
        {
            // 
            Memento memento;

            // creamos los getters y setters para la clase Memento
            public Memento Memento
            {
                set { memento = value;}
                get { return memento; }
            }
        }


    }

  
}
