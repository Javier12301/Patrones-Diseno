using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorForm.Decorator
{
    public class Leche : DecoratorCondimentos
    {
        public Leche(BebidasComponent bebida) : base(bebida) { }

        public override double Costo => bebidas.Costo + 2;

        public override string Descripcion => string.Format($"{bebidas.Descripcion}, Leche");
    }
}
