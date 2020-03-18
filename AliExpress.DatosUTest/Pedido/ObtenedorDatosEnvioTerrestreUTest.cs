using AliExpress.Entities.Enumerables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AliExpress.Datos.Pedido.UTest
{
    /// <summary>
    /// Clase de pruebas unitarias para la clase ObtenedorDatosEnvioTerrestre.
    /// </summary>
    [TestClass()]
    public class ObtenedorDatosEnvioTerrestreUTest
    {
        [TestMethod()]
        public void ObtenerTiempoDeTraslado_TiempoTrasladoPrimavera_TiempoTrasladoEsUnoPuntoCincuentaYSiete()
        {
            //Arrange.
            var iDistancia = 2600;
            var SUT = new ObtenedorDatosEnvioTerrestre();

            //Act.
            var dTiempoTrasldo = SUT.ObtenerTiempoDeTraslado(iDistancia, EEstaciones.Primavera);

            //Assert.
            Assert.AreEqual(1.57M, dTiempoTrasldo);
        }

        [TestMethod()]
        public void ObtenerTiempoDeTraslado_TiempoTrasladoVerano_TiempoTrasladoEsUnoPuntoSesentaYNueve()
        {
            //Arrange.
            var iDistancia = 2600;
            var SUT = new ObtenedorDatosEnvioTerrestre();

            //Act.
            var dTiempoTrasldo = SUT.ObtenerTiempoDeTraslado(iDistancia, EEstaciones.Vernao);

            //Assert.
            Assert.AreEqual(1.69M, dTiempoTrasldo);
        }

        [TestMethod()]
        public void ObtenerTiempoDeTraslado_TiempoTrasladoOtonio_TiempoTrasladoEsUnoPuntoSesentaYTres()
        {
            //Arrange.
            var iDistancia = 2600;
            var SUT = new ObtenedorDatosEnvioTerrestre();

            //Act.
            var dTiempoTrasldo = SUT.ObtenerTiempoDeTraslado(iDistancia, EEstaciones.Otonio);

            //Assert.
            Assert.AreEqual(1.63M, dTiempoTrasldo);
        }

        [TestMethod()]
        public void ObtenerTiempoDeTraslado_TiempoTrasladoInvierno_TiempoTrasladoEsUnoPuntoOcho()
        {
            //Arrange.
            var iDistancia = 2600;
            var SUT = new ObtenedorDatosEnvioTerrestre();

            //Act.
            var dTiempoTrasldo = SUT.ObtenerTiempoDeTraslado(iDistancia, EEstaciones.Invierno);

            //Assert.
            Assert.AreEqual(1.8M, dTiempoTrasldo);
        }

        [TestMethod()]
        public void ObtenerVelocidadEntrega_VelocidadTerrestre_ValocidadEsOchenta()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioTerrestre();

            //Act.
            var iVelocidad = SUT.ObtenerVelocidadEntrega();

            //Assert.
            Assert.AreEqual(80, iVelocidad);
        }
    }
}