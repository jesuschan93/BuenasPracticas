using AliExpress.Services.Decorador;
using AliExpress.Services.Decorador.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace AliExpress.ServicesUTest.Decorador
{
    /// <summary>
    /// Clase de pruebas unitarias para la clase DecoradorExprecionesUno.
    /// </summary>
    /// 
    [TestClass()]
    public class DecoradorExprecionDosUTest
    {
        [TestMethod()]
        public void DecoradorExprecionDos_InstanciaEsNull_DevuelveExcepcion()
        {
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => new DecoradorExprecionDos(null));
        }

        [TestMethod()]
        public void ProcesarListaExpresiones_FechaMenorAHoy_DevuelveListaCon2Registros()
        {
            //Arrange.
            var lstExpreciones = new List<string>() { "salió","llegó"};
            var dtFechAyer = DateTime.Now.AddDays(-1);
            Mock<IDecoradorExpreciones> srvDecorador = new Mock<IDecoradorExpreciones>();

            srvDecorador.Setup(srv => srv.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones));

            var SUT = new DecoradorExprecionDos(srvDecorador.Object);
            //Act.
            SUT.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones);

            //Assert
            Assert.AreEqual(3, lstExpreciones.Count);
        }
        [TestMethod()]
        public void ProcesarListaExpresiones_FechaMenorAHoy_DevuelveListaExpresionEsLlego()
        {
            //Arrange.
            var lstExpreciones = new List<string>() { "salió", "llegó" };
            var dtFechAyer = DateTime.Now.AddDays(-1);
            Mock<IDecoradorExpreciones> srvDecorador = new Mock<IDecoradorExpreciones>();

            srvDecorador.Setup(srv => srv.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones));

            var SUT = new DecoradorExprecionDos(srvDecorador.Object);
            //Act.
            SUT.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones);

            //Assert
            Assert.AreEqual("hace", lstExpreciones[2].ToString());
        }
    }
}
