using C15_EntidadesIO_05;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C15_Tests_05
{
    [TestClass]
    public class ArchivoTests
    {
        [TestMethod]
        public void ArchivoExtensiones_DebenSerCorrectas()
        {
            PuntoJSON<string> json = new PuntoJSON<string>();
            PuntoXML<string> xml = new PuntoXML<string>();
            PuntoTXT txt = new PuntoTXT();

            Assert.IsTrue(json.ValidarExtension("serializado.json"));
            Assert.IsTrue(xml.ValidarExtension("serializado.xml"));
            Assert.IsTrue(txt.ValidarExtension("texto.txt"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ArchivoJSONExtension_NoDebeSerCorrecta()
        {
            PuntoJSON<string> json = new PuntoJSON<string>();
            Assert.IsFalse(json.ValidarExtension("texto.txt"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ArchivoXMLExtension_NoDebeSerCorrecta()
        {
            PuntoXML<string> xml = new PuntoXML<string>();
            Assert.IsFalse(xml.ValidarExtension("serializado.json"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ArchivoTXTExtension_NoDebeSerCorrecta()
        {
            PuntoTXT txt = new PuntoTXT();
            Assert.IsFalse(txt.ValidarExtension("serializado.xml"));
        }
    }
}
