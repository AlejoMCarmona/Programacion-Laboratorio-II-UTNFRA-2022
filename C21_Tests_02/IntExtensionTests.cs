using C21_Ejercicio_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace C21_Tests_02
{
    [TestClass]
    public class IntExtensionTests
    {
        [TestMethod]
        public void ContarCantidadDeDigitos_DeberiaRetornarLaCorrectaCantidadDeDigitosDelNumero()
        {
            long numero1 = 10;
            long numero2 = 10;
            long numero3 = 1648922222222;
            long numero4 = 16874;
            long numero5 = 9348654;
            long numero6 = 0;

            Assert.AreEqual(2, numero1.ContarCantidadDeDigitos());
            Assert.AreEqual(2, numero2.ContarCantidadDeDigitos());
            Assert.AreEqual(13, numero3.ContarCantidadDeDigitos());
            Assert.AreEqual(5, numero4.ContarCantidadDeDigitos());
            Assert.AreEqual(7, numero5.ContarCantidadDeDigitos());
            Assert.AreEqual(1, numero6.ContarCantidadDeDigitos());
        }
    }
}
