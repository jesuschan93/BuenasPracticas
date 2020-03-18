using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Entities.Enumerables;
using System;

namespace AliExpress.Datos.Pedido.UTest
{
    /// <summary>
    /// Clase de pruebas unitarias para la clase ObtenedorDatosEnvioMaritimo.
    /// </summary>
    [TestClass()]
    public class ObtenedorDatosEnvioMaritimoUTest
    {
        [TestMethod()]
        public void ObtenerCostoPorEnvio_CostoEnvioEnPrimavera_CostoPorKilometroEsTrecientosSesenta()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var dCosto = SUT.ObtenerCostoPorEnvio(1200 ,EEstaciones.Primavera);

            //Assert.
            Assert.AreEqual(360M, dCosto);
        }

        [TestMethod()]
        public void ObtenerCostoPorEnvio_CostoEnvioEnVerano_CostoPorKilometroEsTrecientosNoventaYSeis()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var dCosto = SUT.ObtenerCostoPorEnvio(1200, EEstaciones.Vernao);

            //Assert.
            Assert.AreEqual(396M, dCosto);
        }

        [TestMethod()]
        public void ObtenerCostoPorEnvio_CostoEnvioEnOtonio_CostoPorKilometroEsCuatrocientosCatorce()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var dCosto = SUT.ObtenerCostoPorEnvio(1200, EEstaciones.Otonio);

            //Assert.
            Assert.AreEqual(414M, dCosto);
        }

        [TestMethod()]
        public void ObtenerCostoPorEnvio_CostoEnvioEnInvierno_CostoPorKilometroEsCuatrocientosCuarentaYDosPuntoOcho()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var dCosto = SUT.ObtenerCostoPorEnvio(1200, EEstaciones.Invierno);

            //Assert.
            Assert.AreEqual(442.8M, dCosto);
        }

        [TestMethod()]
        public void ObtenerVelocidadEntrega_VelocidadMaritima_ValocidadEsCuarentaYSeis()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var iVelocidad = SUT.ObtenerVelocidadEntrega();

            //Assert.
            Assert.AreEqual(46, iVelocidad);
        }

        [TestMethod()]
        public void ObtenerTiempoDeTraslado_DistanciaEsMilDocientosKilometrosEnPrimavera_TiempoTrasladoEsUnoPunotCeroNueve()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var iVelocidad = SUT.ObtenerTiempoDeTraslado(1200, EEstaciones.Primavera);

            //Assert.
            Assert.AreEqual(1.09M, iVelocidad);
        }

        [TestMethod()]
        public void ObtenerTiempoDeTraslado_DistanciaEsMilDocientosKilometrosVerano_TiempoTrasladoEsUnoPuntoVeintiuno()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var iVelocidad = SUT.ObtenerTiempoDeTraslado(1200, EEstaciones.Vernao);

            //Assert.
            Assert.AreEqual(1.21M, iVelocidad);
        }

        [TestMethod()]
        public void ObtenerTiempoDeTraslado_DistanciaEsMilDocientosKilometrosEnOtonio_TiempoTrasladoEsCeroPuntoNoventaYCinco()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var iVelocidad = SUT.ObtenerTiempoDeTraslado(1200, EEstaciones.Otonio);

            //Assert.
            Assert.AreEqual(0.95M, iVelocidad);
        }

        [TestMethod()]
        public void ObtenerTiempoDeTraslado_DistanciaEsMilDocientosKilometrosInvierno_TiempoTrasladoEsUnDiaYMedio()
        {
            //Arrange.
            var SUT = new ObtenedorDatosEnvioMaritimo();

            //Act.
            var iVelocidad = SUT.ObtenerTiempoDeTraslado(1200, EEstaciones.Invierno);

            //Assert.
            Assert.AreEqual(1.55M, iVelocidad);
        }


    }
}