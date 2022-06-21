using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interfaz
{
    public class Numero : Nodo
    {
        private int valor;
        public Numero(int valor) => this.valor = valor;
        public int resultado() => valor;
    }
}
