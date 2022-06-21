using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora.Interfaz;

namespace Test_Calculadora
{
    [TestClass]
    public class UnitTest1
    {
        Arbol PruebaSol;

        [TestInitialize]
        public void TestInitialize()
        {
            PruebaSol = new Arbol();
        }

        [TestMethod]
        public int UnaHoja()
        {
            return PruebaSol.Resolver("4");
        }
        public int DosHoja()
        {
            return PruebaSol.Resolver("10-5");
        }
        public int RaizConRaiz()
        {
            return PruebaSol.Resolver("1*2+3");
        }
    }
}
