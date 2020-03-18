using AliExpress.Datos.Interfaces.Paqueteria;
using AliExpress.Entities.Enumerables;
using System;

namespace AliExpress.Datos.Paqueteria
{
    /// <summary>
    /// 
    /// </summary>
    public class RecuperadorDatosPaqueteriaDHL : IRecuperadorDatosPaqueteria
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
                    dHoras = 21;
                    break;
                case EMediosTransporte.Terrestre:
                    dHoras = 10;
                    break;
                case EMediosTransporte.Aereo:
                    dHoras = 0;
                    break;
            }
            return dHoras;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_iMesAño"></param>
        /// <param name="_dMargenUtilidad"></param>
        /// <returns></returns>
        private void ObtenerUtilidadMesPedido(int _iMesAño, ref decimal _dMargenUtilidad)
        {
            if (_iMesAño > 0 && _iMesAño <= 6)
            {
                _dMargenUtilidad = 50;
            }
            else
            {
                _dMargenUtilidad = 30;
            }         
        }
    }
}