using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AliExpress.Services.Pedido.UTest
{
    [TestClass()]
    public class ObtenedorDatosEnvioAereoServiceUTest
    {
        [TestMethod()]
        public void ObtenedorDatosEnvioAereoService_InstanaciaEsNulo_DevuelveExcepcion()
        {
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => new ObtenedorDatosEnvioAereoService(null));
        }
    }
}