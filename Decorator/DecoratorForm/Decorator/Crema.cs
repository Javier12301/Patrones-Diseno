using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorForm.Decorator
{
    public class Crema : DecoratorCondimentos
    {
        public Crema(BebidasComponent bebidas) : base(bebidas) { }

        public override double Costo => bebidas.Costo + 4;

        public override string Descripcion => string.Format($"{bebidas.Descripcion}, Crema");
    }
}
