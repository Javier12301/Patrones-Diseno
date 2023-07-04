using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorForm
{
    // I don't want to use github copilot in this class
    public abstract class DecoratorCondimentos : BebidasComponent
    {
        protected BebidasComponent bebidas;

        public DecoratorCondimentos(BebidasComponent bebidas)
        {
            this.bebidas = bebidas;
        }
      
    }
}
