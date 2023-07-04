using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Ej_Cafe.Bebidas
{
    public class CafeExpreso : BebidaComponent
    {
        public override double Costo => 12;

        public override string Descripcion => "Café Expreso";
    }
}
