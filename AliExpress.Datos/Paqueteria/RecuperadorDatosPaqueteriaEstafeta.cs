using AliExpress.Datos.Interfaces.Paqueteria;
using AliExpress.Entities.Enumerables;
using System;

namespace AliExpress.Datos.Paqueteria
{
    /// <summary>
    /// 
    /// </summary>
    public class RecuperadorDatosPaqueteriaEstafeta : IRecuperadorDatosPaqueteria
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaPedido"></param>
        /// <returns></returns>
        public decimal ObtenerMargenUtilidad(DateTime _dtFechaPedido)
        {
            decimal dMargenUtilidad = 0;
            int iMesAño = _dtFechaPedido.Month;
            ObtenerMargenUtilidadFebrero(iMesAño, ref dMargenUtilidad);
            ObtenerMargenUtilidadDiciembre(iMesAño, ref dMargenUtilidad);
            ObtenerUtilidadMesPedido(iMesAño, ref dMargenUtilidad);

            return (dMargenUtilidad / 100) + 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_eMedioTransporte"></param>
        /// <returns></returns>
        public decimal ObtenerTiempoRepartoHoras(EMediosTransporte _eMedioTransporte)
        {
            decimal dHoras = 0;
            switch (_eMedioTransporte)
            {
                case EMediosTransporte.Maritimo:
                    dHoras = 20;
                    break;
                case EMediosTransporte.Terrestre:
                    dHoras = 12;
                    break;
                case EMediosTransporte.Aereo:
                    dHoras = 3;
                    break;
            }
            return dHoras;
        }        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iMesAño"></param>
        private void ObtenerMargenUtilidadFebrero(int iMesAño, ref decimal _iMargenUtilidad)
        {
            if (iMesAño == 2)
            {
                _iMargenUtilidad = 10;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iMesAño"></param>
        private void ObtenerMargenUtilidadDiciembre(int iMesAño, ref decimal _iMargenUtilidad)
        {
            if (iMesAño == 12)
            {
                _iMargenUtilidad = 50;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_iMesAño"></param>
        /// <param name="_iMargenUtilidad"></param>
        private void ObtenerUtilidadMesPedido(int _iMesAño, ref decimal _iMargenUtilidad)
        {
            if (_iMargenUtilidad == 0)
            {
                _iMargenUtilidad = 45;
            }
        }

    }
}