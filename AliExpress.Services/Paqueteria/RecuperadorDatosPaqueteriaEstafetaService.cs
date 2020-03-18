using AliExpress.Datos.Interfaces.Paqueteria;
using AliExpress.Entities.Enumerables;
using AliExpress.Services.Interfaces.Paqueteria;
using System;

namespace AliExpress.Services.Paqueteria
{
    /// <summary>
    /// 
    /// </summary>
    public class RecuperadorDatosPaqueteriaEstafetaService : IRecuperadorDatosPaqueteriaService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IRecuperadorDatosPaqueteria recuperadorDatosPaqueteria;
        public RecuperadorDatosPaqueteriaEstafetaService(IRecuperadorDatosPaqueteria _recuperadorDatosPaqueteria)
        {
            recuperadorDatosPaqueteria = _recuperadorDatosPaqueteria ?? throw new ArgumentNullException(nameof(_recuperadorDatosPaqueteria));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaPedido"></param>
        /// <returns></returns>
        public decimal ObtenerMargenUtilidad(DateTime _dtFechaPedido)
        {
            return recuperadorDatosPaqueteria.ObtenerMargenUtilidad(_dtFechaPedido);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_eMedioTransporte"></param>
        /// <returns></returns>
        public decimal ObtenerTiempoRepartoHoras(EMediosTransporte _eMedioTransporte)
        {
            return recuperadorDatosPaqueteria.ObtenerTiempoRepartoHoras(_eMedioTransporte);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public EPaqueteria ObtenerPaqueteria()
        {
            return EPaqueteria.Estafeta;
        }
    }
}