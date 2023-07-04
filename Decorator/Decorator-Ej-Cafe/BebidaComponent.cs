using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Ej_Cafe
{
    public abstract class BebidaComponent
    {
        //2 operaciones abstractas
        public abstract double Costo { get; }

        public abstract string Descripcion { get; }
    }
}
