using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Ej_Cafe
{
    public abstract class AgregadoDecorator : BebidaComponent
    {
        // Esta es la clase abstracta que hereda de BebidaComponent
        protected BebidaComponent _bebida;

        // Constructor, esta es la agregación
        //En la agregación, una clase contiene una instancia de otra clase como parte de su estructura.

        public AgregadoDecorator(BebidaComponent bebida)
        {           
            _bebida = bebida;
        }
    }
}
