using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AliExpress.Services.UTest
{
    /// <summary>
    /// Clase de pruebas unitarias para la clase ValidadorDatosPedido.
    /// </summary>
    /// 
    [TestClass()]
    public class ValidadorDatosPedidoUTest
    {
        [TestMethod()]
        public void ValidarEstacionAnio_FechaEntrePrimavera_DevuelveEstacionPrimavera()
        {
            //Arrange.
            var SUT = new ValidadorDatosPedido();

            //Act.
            var eEstacion = SUT.ValidarEstacionAnio(new DateTime(2020, 04, 28));

            //Assert.
            Assert.AreEqual(AliExpress.Entities.Enumerables.EEstaciones.Primavera, eEstacion);
        }

        [TestMethod()]
        public void ValidarEstacionAnio_FechaEntreVerano_DevuelveEstacionVerano()
        {
            //Arrange.
            var SUT = new ValidadorDatosPedido();

            //Act.
            var eEstacion = SUT.ValidarEstacionAnio(new DateTime(2020, 07, 23));

            //Assert.
            Assert.AreEqual(AliExpress.Entities.Enumerables.EEstaciones.Vernao, eEstacion);
        }

        [TestMethod()]
        public void ValidarEstacionAnio_FechaEntreOtonio_DevuelveEstacionOtonio()
        {
            //Arrange.
            var SUT = new ValidadorDatosPedido();

            //Act.
            var eEstacion = SUT.ValidarEstacionAnio(new DateTime(2020, 10, 19));

            //Assert.
            Assert.AreEqual(AliExpress.Entities.Enumerables.EEstaciones.Otonio, eEstacion);
        }

        [TestMethod()]
        public void ValidarEstacionAnio_FechaEntreInvierno_DevuelveEstacionInvierno()
        {
            //Arrange.
            var SUT = new ValidadorDatosPedido();

            //Act.
            var eEstacion = SUT.ValidarEstacionAnio(new DateTime(2020, 12, 25));

            //Assert.
            Assert.AreEqual(AliExpress.Entities.Enumerables.EEstaciones.Invierno, eEstacion);
        }
    }
}