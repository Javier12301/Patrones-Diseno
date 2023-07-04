using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorForm.Bebidas
{
    public class CafeSolo : BebidasComponent
    {
        public override double Costo => 10;
        public override string Descripcion => "Café Solo";
    }
}
