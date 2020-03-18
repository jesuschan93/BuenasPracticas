using AliExpress.Entities.Enumerables;
using AliExpress.Services.Decorador;
using AliExpress.Services.Decorador.Interfaces;
using AliExpress.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace AliExpress.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidadorDatosPedido: IValidadorDatosPedido
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFecha"></param>
        /// <returns></returns>
        public EEstaciones ValidarEstacionAnio(DateTime _dtFecha)
        {
            EEstaciones eEstacion=EEstaciones.Otonio;
            ValidarPrimavera(_dtFecha, ref eEstacion);
            ValidarVerano(_dtFecha, ref eEstacion);
            ValidarOtonio(_dtFecha, ref eEstacion);
            ValidarInvierno(_dtFecha, ref eEstacion);
            return eEstacion;
        }

        public List<string> ObtenerListaExpresiones(DateTime _dtFechaEntrega)
        {
            List<string> lstExpresiones = new List<string>();
            //ObtenerExpresion(_dtFechaEntrega, ref lstExpresiones);

            return lstExpresiones;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaEntrega"></param>
        public List<string> ObtenerExpresion(DateTime _dtFechaEntrega)
        {
            List<string> lstExpresiones = new List<string>();
            IDecoradorExpreciones decoradorExpresiones = new DecoradorExpreciones();
            IDecoradorExpreciones decoradorExpresionUno = new DecoradorExprecionUno(decoradorExpresiones);
            IDecoradorExpreciones decoradorExpresionDos = new DecoradorExprecionDos(decoradorExpresionUno);
            IDecoradorExpreciones decoradorExpresionTres = new DecoradorExprecionTres(decoradorExpresionDos);
            decoradorExpresionTres.ProcesarListaExpresiones(_dtFechaEntrega, ref lstExpresiones);

            return lstExpresiones;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFecha"></param>
        /// <param name="_eEstacion"></param>
        /// <returns></returns>
        private void ValidarPrimavera(DateTime _dtFecha, ref EEstaciones _eEstacion)
        {
            DateTime dtFechaAux = new DateTime(2020, _dtFecha.Month, _dtFecha.Day);
            DateTime dtFechaInicio = new DateTime(2020, 03, 21);
            DateTime dtFechaFin = new DateTime(2020, 06, 20);
            if (dtFechaAux >= dtFechaInicio && dtFechaAux <= dtFechaFin)
            {
                _eEstacion = EEstaciones.Primavera;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFecha"></param>
        /// <param name="_eEstacion"></param>
        /// <returns></returns>
        private void ValidarVerano(DateTime _dtFecha, ref EEstaciones _eEstacion)
        {
            DateTime dtFechaAux = new DateTime(2020, _dtFecha.Month, _dtFecha.Day);
            DateTime dtFechaInicio = new DateTime(2020, 06, 21);
            DateTime dtFechaFin = new DateTime(2020, 09, 23);
            if (dtFechaAux >= dtFechaInicio && dtFechaAux <= dtFechaFin)
            {
                _eEstacion = EEstaciones.Vernao;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFecha"></param>
        /// <param name="_eEstacion"></param>
        /// <returns></returns>
        private void ValidarOtonio(DateTime _dtFecha, ref EEstaciones _eEstacion)
        {
            DateTime dtFechaAux = new DateTime(2020, _dtFecha.Month, _dtFecha.Day);
            DateTime dtFechaInicio = new DateTime(2020, 09, 24);
            DateTime dtFechaFin = new DateTime(2020, 12, 20);
            if (dtFechaAux >= dtFechaInicio && dtFechaAux <= dtFechaFin)
            {
                _eEstacion = EEstaciones.Otonio;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFecha"></param>
        /// <param name="_eEstacion"></param>
        /// <returns></returns>
        private void ValidarInvierno(DateTime _dtFecha, ref EEstaciones _eEstacion)
        {
            DateTime dtFechaAux = new DateTime(2020, _dtFecha.Month, _dtFecha.Day);
            DateTime dtFechaInicio = new DateTime(2020, 12, 21);
            DateTime dtFechaFin = new DateTime(2021, 03, 20);
            if (dtFechaAux >= dtFechaInicio && dtFechaAux <= dtFechaFin)
            {
                _eEstacion = EEstaciones.Invierno;
            }
        }
    }
}
