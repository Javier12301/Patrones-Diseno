using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorForm
{
    public abstract class BebidasComponent
    {
        public abstract double Costo { get; }
        public abstract string Descripcion { get; }
        
    }
}
