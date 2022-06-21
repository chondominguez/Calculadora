using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interfaz
{
    public abstract class OperacionArit : Nodo
    {
        protected Nodo izquierda;
        protected Nodo derecha;

        
        public OperacionArit(Nodo izquierda, Nodo derecha)
        {
            this.izquierda = izquierda;
            this.derecha = derecha;
        }

        //public abstract bool esSecundaria();
        public abstract int resultado();
    }
}
