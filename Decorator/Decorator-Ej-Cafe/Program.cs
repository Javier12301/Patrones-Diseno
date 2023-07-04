using Decorator_Ej_Cafe.Bebidas;
using Decorator_Ej_Cafe.Condimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Ej_Cafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BebidaComponent cafe = new CafeSolo();
            
            cafe = new Crema(cafe);
            cafe = new Azucar(cafe);

            Console.WriteLine("Producto: " + cafe.Descripcion + " Tiene un costo de: " + cafe.Costo);
            Console.ReadKey();

        }
    }
}
