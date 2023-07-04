using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorForm.Bebidas
{
    public class CafeExpreso : BebidasComponent
    {
        public override double Costo => 12;
        public override string Descripcion => "Café Expreso";
    }
}
