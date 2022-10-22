using C13_Entidades_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C13_Tests_02
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            PaquetePesado paquetePesado = new PaquetePesado("02122007", 100, "Lanús", "Caballito", 24);
            Assert.AreEqual(100 + 100 * (decimal)0.35 + 100 * (decimal)0.25, paquetePesado.AplicarImpuestos());
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorCientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            PaquetePesado paquetePesado = new PaquetePesado("02122007", 100, "Lanús", "Caballito", 24);
            Assert.AreEqual(100 * (decimal)0.25, ((IAfip)paquetePesado).Impuestos);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorCientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            PaquetePesado paquetePesado = new PaquetePesado("02122007", 100, "Lanús", "Caballito", 24);
            Assert.AreEqual(100 * (decimal)0.35, paquetePesado.Impuestos);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado paquetePesado = new PaquetePesado("02122007", 100, "Lanús", "Caballito", 24);
            Assert.IsFalse(paquetePesado.TienePrioridad);
        }
    }
}
