﻿using AliExpress.Services.Decorador;
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
    public class DecoradorExprecionTresUTest
    {
        [TestMethod()]
        public void DecoradorExprecionTres_InstanciaEsNull_DevuelveExcepcion()
        {
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => new DecoradorExprecionTres(null));
        }

        [TestMethod()]
        public void ProcesarListaExpresiones_FechaMenorAHoy_DevuelveListaCon2Registros()
        {
            //Arrange.
            var lstExpreciones = new List<string>() { "salió", "llegó", "hace" };
            var dtFechAyer = DateTime.Now.AddDays(-1);
            Mock<IDecoradorExpreciones> srvDecorador = new Mock<IDecoradorExpreciones>();

            srvDecorador.Setup(srv => srv.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones));

            var SUT = new DecoradorExprecionTres(srvDecorador.Object);
            //Act.
            SUT.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones);

            //Assert
            Assert.AreEqual(4, lstExpreciones.Count);
        }
        [TestMethod()]
        public void ProcesarListaExpresiones_FechaMenorAHoy_DevuelveListaExpresionEsLlego()
        {
            //Arrange.
            var lstExpreciones = new List<string>() { "salió", "llegó", "hace" };
            var dtFechAyer = DateTime.Now.AddDays(-1);
            Mock<IDecoradorExpreciones> srvDecorador = new Mock<IDecoradorExpreciones>();

            srvDecorador.Setup(srv => srv.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones));

            var SUT = new DecoradorExprecionTres(srvDecorador.Object);
            //Act.
            SUT.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones);

            //Assert
            Assert.AreEqual("tuvo", lstExpreciones[3].ToString());
        }
    }
}
