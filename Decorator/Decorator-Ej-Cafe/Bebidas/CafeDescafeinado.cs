﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Ej_Cafe.Bebidas
{
    public class CafeDescafeinado : BebidaComponent
    {
        public override double Costo => 15;

        public override string Descripcion => "CafÉ Descafeinado";
    }
}
