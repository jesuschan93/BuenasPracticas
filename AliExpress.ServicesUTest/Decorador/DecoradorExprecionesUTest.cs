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
    public class DecoradorExprecionesUTest
    {
        [TestMethod()]
        public void ProcesarListaExpresiones_FechaMenorAHoy_DevuelveListaCon2Registros()
        {
            //Arrange.
            var lstExpreciones = new List<string>();
            var dtFechAyer = DateTime.Now.AddDays(-1);

            var SUT = new DecoradorExpreciones();
            //Act.
            SUT.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones);

            //Assert
            Assert.AreEqual(1, lstExpreciones.Count);
        }
        [TestMethod()]
        public void ProcesarListaExpresiones_FechaMenorAHoy_DevuelveListaExpresionEsLlego()
        {
            //Arrange.
            var lstExpreciones = new List<string>();
            var dtFechAyer = DateTime.Now.AddDays(-1);

            var SUT = new DecoradorExpreciones();
            //Act.
            SUT.ProcesarListaExpresiones(dtFechAyer, ref lstExpreciones);

            //Assert
            Assert.AreEqual("salió", lstExpreciones[0].ToString());
        }
    }
}
