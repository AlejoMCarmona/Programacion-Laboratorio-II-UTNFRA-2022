using C13_Entidades_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace C13_Tests_02
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestoDeAduana()
        {
            GestionImpuestos gestion = new GestionImpuestos();
            decimal totalImpuestos = (decimal)395.5;

            List<Paquete> listaPaquetes = new List<Paquete>();
            listaPaquetes.Add(new PaqueteFragil("02122007", 100, "Lanús", "Caballito", 1.4));
            listaPaquetes.Add(new PaquetePesado("02122009", 200, "Boedo", "Palermo", 24));
            listaPaquetes.Add(new PaquetePesado("02122010", 800, "Córdoba", "Banfield", 30));
            listaPaquetes.Add(new PaqueteFragil("02122008", 30, "Caballito", "Lanús", 6));

            gestion.RegistrarImpuestos(listaPaquetes);
            Assert.AreEqual(totalImpuestos, gestion.CalcularTotalImpuestosAduana());
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestoDeAfip()
        {
            GestionImpuestos gestion = new GestionImpuestos();
            decimal totalImpuestos = (decimal)250;

            List<Paquete> listaPaquetes = new List<Paquete>();
            listaPaquetes.Add(new PaqueteFragil("02122007", 100, "Lanús", "Caballito", 1.4));
            listaPaquetes.Add(new PaquetePesado("02122009", 200, "Boedo", "Palermo", 24));
            listaPaquetes.Add(new PaquetePesado("02122010", 800, "Córdoba", "Banfield", 30));
            listaPaquetes.Add(new PaqueteFragil("02122008", 30, "Caballito", "Lanús", 6));

            gestion.RegistrarImpuestos(listaPaquetes);
            Assert.AreEqual(totalImpuestos, gestion.CalcularTotalImpuestosAfip());
        }
    }
}
