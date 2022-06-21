using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interfaz
{
    public class Arbol
    {
        public int Resolver(string cuenta)
        {
            List<Numero> operandos = new List<Numero> { };
            List<char> operacionesEnCaracter = new List<char> { };

            string nod = "";
            int i = 0;
            for (i = 0; i < cuenta.Length; i++)
            {
                if (EsUnaOperacion(cuenta[i]))
                {
                    operandos.Add(new Numero(Convert.ToInt32(nod)));
                    nod = "";
                    operacionesEnCaracter.Add(cuenta[i]);
                }
                else
                {
                    nod += cuenta[i];
                    if (i == (cuenta.Length - 1))
                    {
                        operandos.Add(new Numero(Convert.ToInt32(nod)));
                        nod = "";
                    }
                }

            }
            Nodo resultado = new Numero(0);
            List<OperacionArit> nodosSecundarios = new List<OperacionArit> { };
            OperacionArit auxiliarSec = new Mult(new Numero(0), new Numero(0));
            if (operandos.Count == 0)
            {
                resultado = new Numero(0);
            }
            else
            {
                if(operacionesEnCaracter.Count == 0)
                {
                    resultado = operandos[0];
                }
                else
                {
                    bool primeroEnLaSecuencia = true;
                    for (i = 0; i < operacionesEnCaracter.Count; i++)
                    {
                        if (esSecundaria(operacionesEnCaracter[i]))
                        {
                            if (primeroEnLaSecuencia)
                            {
                                auxiliarSec = OperacionQueLeCorresponde(operacionesEnCaracter[i], operandos[i], operandos[i + 1]);
                                primeroEnLaSecuencia = false;
                            }
                            else
                            {
                                auxiliarSec = OperacionQueLeCorresponde(operacionesEnCaracter[i], auxiliarSec, operandos[i + 1]);
                            }
                            if (i == (operacionesEnCaracter.Count - 1))
                            {
                                nodosSecundarios.Add(auxiliarSec);
                                primeroEnLaSecuencia = true;
                            }
                            else
                            {
                                if(!esSecundaria(operacionesEnCaracter[i + 1]))
                                {
                                    nodosSecundarios.Add(auxiliarSec);
                                    primeroEnLaSecuencia = true;
                                }
                            }
                        }
                    }
                    int j = 0;
                    for (i = 0; i < operacionesEnCaracter.Count; i++)
                    {
                        if (!esSecundaria(operacionesEnCaracter[i]))
                        {
                            if (i == 0)
                            {
                                if (!esSecundaria(operacionesEnCaracter[i + 1]))
                                    resultado = OperacionQueLeCorresponde(operacionesEnCaracter[i], operandos[i], operandos[i + 1]);
                                else
                                {
                                    resultado = OperacionQueLeCorresponde(operacionesEnCaracter[i], operandos[i], nodosSecundarios[j]);
                                    j++;
                                }
                            }
                            else
                            {
                                Nodo nIz;
                                Nodo nDe;
                                if (j == 0)
                                {
                                    nIz = nodosSecundarios[j];
                                    j++;
                                }
                                else
                                {
                                    nIz = resultado;
                                }

                                if (i == (operacionesEnCaracter.Count - 1))
                                {
                                    nDe = operandos[i + 1];
                                }
                                else
                                {
                                    if (!esSecundaria(operacionesEnCaracter[i + 1]))
                                    {
                                        nDe = operandos[i + 1];
                                    }
                                    else
                                    {
                                        nDe = nodosSecundarios[j];
                                        j++;
                                    }
                                }
                                resultado = OperacionQueLeCorresponde(operacionesEnCaracter[i], nIz, nDe);
                            }
                        }
                    }
                }
            }
            return resultado.resultado();
        }

        private bool EsUnaOperacion(char caracter)
        {
            return caracter == 'x' || caracter == '/' || caracter == '+' || caracter == '-';
        }

        private bool esSecundaria(char caracter)
        {
            return caracter == 'x' || caracter == '/';
        }

        private OperacionArit OperacionQueLeCorresponde(char caracter, Nodo nodoIz, Nodo nodoDer)
        {
            OperacionArit operacion = new Sum(nodoIz, nodoDer);
            switch (caracter)
            {
                case 'x':
                    operacion = new Mult(nodoIz, nodoDer);
                    break;
                case '/':
                    operacion = new Divi(nodoIz, nodoDer);
                    break;
                case '+':
                    operacion = new Sum(nodoIz, nodoDer);
                    break;
                case '-':
                    operacion = new Res(nodoIz, nodoDer);
                    break;
            }
            return operacion;
        }

    }
}
