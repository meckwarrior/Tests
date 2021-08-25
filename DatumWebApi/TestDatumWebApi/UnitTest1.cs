using DatumWebApi.Controllers;
using NUnit.Framework;

namespace TestDatumWebApi
{
    public class Tests
    {
        private JurosController _jurosController;

        [SetUp]
        public void Setup()
        {
            _jurosController = new JurosController();
        }

        [Test]
        public void Get_TaxaJuros_Returna001()
        {
            Assert.AreEqual(0.01m,_jurosController.GetTaxaJuros());
        }

        [Test]
        [TestCase(100,5,105.10)]
        [TestCase(200, 6, 212.30)]
        [TestCase(1000, 15, 1160.97)]
        public void Get_TaxaJuros_ReturnaDecimal(decimal valorInicial, int meses, decimal valorCorreto)
        {
            Assert.AreEqual(valorCorreto, _jurosController.GetCalculaJuros(valorInicial,meses));
        }

        [Test]
        public void Get_ShowMeTheCode_ReturnUrlString()
        {
            string url = "url";

            Assert.AreEqual(url,new ShowMeTheCodeController().GetTheCodeUrl());
        }
    }
}