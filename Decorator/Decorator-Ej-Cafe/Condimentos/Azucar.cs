using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Ej_Cafe.Condimentos
{
    public class Azucar : AgregadoDecorator
    {
        //usamos el constructor de la clase padre para pasarle la bebida
        public Azucar(BebidaComponent bebida) : base(bebida){}

        public override double Costo => _bebida.Costo + 0.50;

        public override string Descripcion => string.Format($"{_bebida.Descripcion}, Azucar");
    }
}
