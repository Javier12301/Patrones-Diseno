﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Ej_Cafe.Bebidas
{
    public class CafeSolo : BebidaComponent
    {
        public override double Costo => 10;

        public override string Descripcion => "Café Solo";
    }
}