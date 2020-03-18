using AliExpress.Entities;
using AliExpress.Entities.Enumerables;
using System;
using System.Collections.Generic;

namespace AliExpress.Interfaces.ViewModel
{
    public interface IProcesadorDatosEnvioViewModelService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_iDistancia"></param>
        /// <param name="_eEstacion"></param>
        /// <param name="_dtFechaPedido"></param>
        /// <returns></returns>
        decimal ObtenerCostoServicio(int _iDistancia, EEstaciones _eEstacion, DateTime _dtFechaPedido);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Pedido> ObtenerListaPedidos();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaPedido"></param>
        /// <param name="_iDistancia"></param>
        /// <returns></returns>
        decimal ObtenerTiempoTransporte(DateTime _dtFechaPedido, int _iDistancia);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string ObtenerMensaje();
    }
}