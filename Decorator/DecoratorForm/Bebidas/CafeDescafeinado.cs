using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorForm.Bebidas
{
    public class CafeDescafeinado : BebidasComponent
    {
        public override double Costo => 15;
        public override string Descripcion => "Café Descafeinado";
    }
}
