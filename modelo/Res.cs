﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interfaz
{
    public class Res : OperacionArit
    {
        public Res(Nodo izquierda, Nodo derecha) : base(izquierda, derecha) { }

        //public override bool esSecundaria() => false;
        public override int resultado() => izquierda.resultado() - derecha.resultado();
    }
}
