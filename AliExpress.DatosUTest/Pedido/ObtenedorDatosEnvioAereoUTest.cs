using AliExpress.Entities.Enumerables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AliExpress.Datos.Pedido.UTest
{
    /// <summary>
    /// Clase de pruebas unitarias para la clase ObtenedorDatosEnvioAereo.
    /// </summary>
    [TestClass()]
    public class ObtenedorDatosEnvioAereoUTest
    {
        [TestMethod()]
        public void ObtenerTiempoDeTraslado_DistanciaEsMilDocientos_CostoPorKilometroEsOcho()
        {
            //Arrange.
            var iDistancia = 1200;
            var SUT = new ObtenedorDatosEnvioAereo();

            //Act.
            var dCosto = SUT.ObtenerTiempoDeTraslado(iDistancia, EEstaciones.Primavera);

            //Assert.
            Assert.AreEqual(8M, dCosto);
        }

        [TestMethod()]
        public void ObtenerCostoPorEnvioo_DistanciaEsCero_CostoPorKilometroEsCero()
        {
            //Arrange.
            var iDistancia = 1200;
            var SUT = new ObtenedorDatosEnvioAereo();

            //Act.
            var dCosto = SUT.ObtenerCostoPorEnvio(iDistancia, EEstaciones.Primavera);

            //Assert.
            Assert.AreEqual(12200, dCosto);
        }

        [TestMethod()]
        public void ObtenerVelocidadEntrega_VelocidadAerea_ValocidadEsCuarentaSeiscientos()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioAereo();

            //Act.
            var iVelocidad = SUT.ObtenerVelocidadEntrega();

            //Assert.
            Assert.AreEqual(600, iVelocidad);
        }
    }
}