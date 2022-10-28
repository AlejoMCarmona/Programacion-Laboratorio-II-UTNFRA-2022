using C14_EntidadesCentralita_05;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace C14_TestsCentralita_05
{
    [TestClass]
    public class CentralitaTests
    {
        [TestMethod]
        public void NuevaCentralita_ListaLlamadas_Ok()
        {
            Centralita centralita = new Centralita("Test");
            Assert.IsTrue(centralita.Llamadas is not null);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AgregarLlamadaLocalExistente_Excepcion()
        {
            Centralita centralita = new Centralita("Test");
            Local llamadaLocal1 = new Local(20, "115724815", "1135263416", 2.4f);
            Local llamadaLocal2 = new Local(12, "115724815", "1135263416", 1.0f);

            _ = centralita + llamadaLocal1;
            _ = centralita + llamadaLocal2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AgregarLlamadaProvincialExistente_Excepcion()
        {
            Centralita centralita = new Centralita("Test");
            Provincial llamadaProvincial1 = new Provincial(eFranja.Franja_1, 20, "115724815", "1135263416");
            Provincial llamadaProvincial2 = new Provincial(eFranja.Franja_3, 30, "115724815", "1135263416");

            _ = centralita + llamadaProvincial1;
            _ = centralita + llamadaProvincial2;
        }

        [TestMethod]
        public void CompararLlamadasDiferentes_Iguales()
        {
            Centralita centralita = new Centralita("Test");
            Local llamadaLocal1 = new Local(20, "115724815", "1135263416", 2.4f);
            Local llamadaLocal2 = new Local(12, "115724815", "1135263416", 1.0f);
            Provincial llamadaProvincial1 = new Provincial(eFranja.Franja_1, 20, "115724815", "1135263416");
            Provincial llamadaProvincial2 = new Provincial(eFranja.Franja_3, 30, "115724815", "1135263416");

            Assert.IsFalse(llamadaLocal1 == llamadaProvincial1);
            Assert.IsFalse(llamadaLocal1 == llamadaProvincial2);
            Assert.IsFalse(llamadaLocal2 == llamadaProvincial1);
            Assert.IsFalse(llamadaLocal2 == llamadaProvincial2);

            Assert.IsTrue(llamadaLocal1 == llamadaLocal2);
            Assert.IsTrue(llamadaProvincial1 == llamadaProvincial2);
        }
    }
}
