using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorForm.Decorator
{
    public class Azucar : DecoratorCondimentos
    {
        public Azucar(BebidasComponent bebida) : base(bebida) { }

        public override double Costo => bebidas.Costo + 0.50;

        public override string Descripcion => string.Format($"{bebidas.Descripcion}, Azucar");
    }
}
