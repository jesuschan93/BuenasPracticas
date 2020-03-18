using AliExpress.Entities.Enumerables;
using System;

namespace AliExpress.Services.Interfaces.Paqueteria
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRecuperadorDatosPaqueteriaService
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="_dtFechaPedido"></param>
       /// <returns></returns>
        decimal ObtenerMargenUtilidad(DateTime _dtFechaPedido);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_eMedioTransporte"></param>
        /// <returns></returns>
        decimal ObtenerTiempoRepartoHoras(EMediosTransporte _eMedioTransporte);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        EPaqueteria ObtenerPaqueteria();
    }
}
