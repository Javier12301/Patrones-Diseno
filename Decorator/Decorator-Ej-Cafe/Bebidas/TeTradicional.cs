using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Ej_Cafe.Bebidas
{
    public class TeTradicional : BebidaComponent
    {
        public override double Costo => 8;

        public override string Descripcion => "Té tradicional";
    }
}
