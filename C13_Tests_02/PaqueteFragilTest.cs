using C13_Entidades_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C13_Tests_02
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("02122007", 100, "Lanús", "Caballito", 1.4);
            Assert.AreEqual(100 + 100 * (decimal)0.35, paqueteFragil.AplicarImpuestos());
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorCientoSobreCostoEnvio()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("02122007", 100, "Lanús", "Caballito", 1.4);
            Assert.IsTrue(100 * (decimal)0.35 == paqueteFragil.Impuestos);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("02122007", 100, "Lanús", "Caballito", 1.4);
            Assert.IsTrue(paqueteFragil.TienePrioridad);
        }
    }
}
