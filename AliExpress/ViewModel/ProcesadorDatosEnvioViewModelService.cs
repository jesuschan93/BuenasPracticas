using AliExpress.Datos.Interfaces.DatosPedido;
using AliExpress.Entities;
using AliExpress.Entities.Enumerables;
using AliExpress.Interfaces.ViewModel;
using AliExpress.Services.Interfaces;
using AliExpress.Services.Interfaces.Paqueteria;
using AliExpress.Services.Interfaces.Pedido;
using System;
using System.Collections.Generic;

namespace AliExpress.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class ProcesadorDatosEnvioViewModelService : IProcesadorDatosEnvioViewModelService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IObtenedorDatosEnvioService obtenedorDatosEnvioService;

        /// <summary>
        /// 
        /// </summary>
        private readonly IRecuperadorDatosPaqueteriaService recuperadorDatosPaqueteriaService;

        /// <summary>
        /// 
        /// </summary>
        public readonly IValidadorDatosPedido validadorDatosPedido;

        /// <summary>
        /// 
        /// </summary>
        public readonly IRecuperadorDatosPedido recuperadorDatosPedido;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_obtenedorDatosEnvioService"></param>
        /// <param name="_recuperadorDatosPaqueteriaService"></param>
        /// <param name="_validadorDatosPedido"></param>
        /// <param name="_recuperadorDatosPedido"></param>
        public ProcesadorDatosEnvioViewModelService(IObtenedorDatosEnvioService _obtenedorDatosEnvioService, IRecuperadorDatosPaqueteriaService _recuperadorDatosPaqueteriaService, IValidadorDatosPedido _validadorDatosPedido, IRecuperadorDatosPedido _recuperadorDatosPedido)
        {
            obtenedorDatosEnvioService = _obtenedorDatosEnvioService ?? throw new System.ArgumentNullException(nameof(_obtenedorDatosEnvioService));
            recuperadorDatosPaqueteriaService = _recuperadorDatosPaqueteriaService ?? throw new System.ArgumentNullException(nameof(_recuperadorDatosPaqueteriaService));
            validadorDatosPedido = _validadorDatosPedido ?? throw new ArgumentNullException(nameof(_validadorDatosPedido));
            recuperadorDatosPedido = _recuperadorDatosPedido ?? throw new ArgumentNullException(nameof(_recuperadorDatosPedido));
        }

        public string ObtenerMensaje()
        {
            double tiempoReparto = 0;
            var eMedioTransporte = obtenedorDatosEnvioService.ObtenerMedioTransporte();            
            var dTiempoReparto = recuperadorDatosPaqueteriaService.ObtenerTiempoRepartoHoras(eMedioTransporte);
            var iVelocidadMedioTransporte = obtenedorDatosEnvioService.ObtenerVelocidadEntrega();
            var lstPedidos = ObtenerListaPedidos();
            foreach(var item in lstPedidos)
            {
                var iTiempoTraslado = item.iDistancia / iVelocidadMedioTransporte;
                var eEstacionAnio = validadorDatosPedido.ValidarEstacionAnio(item.dtFechaPedido);
                decimal dTiempoEntrega = iTiempoTraslado + dTiempoReparto;
                double.TryParse(dTiempoEntrega.ToString(), out tiempoReparto);
                var dtFechaEntrega = item.dtFechaPedido.AddHours(tiempoReparto);
                var dCostoEnvio = ObtenerCostoServicio(item.iDistancia, eEstacionAnio, item.dtFechaPedido);
                var cOrigen = string.Format("{0}, {1}",item.cCiudadOrigen,item.cPaisOrigen);
                var cDestino = string.Format("{0}, {1}", item.cCiudadDestino, item.cPaisDestino);

            }
            return null;
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="_iDistancia"></param>
        /// <param name="_eEstacion"></param>
        /// <param name="_dtFechaPedido"></param>
        /// <returns></returns>
        public decimal ObtenerCostoServicio(int _iDistancia, EEstaciones _eEstacion, DateTime _dtFechaPedido)
        {
            decimal dCostoServicio = 0;
            var dCostoTransporte = obtenedorDatosEnvioService.ObtenerCostoPorEnvio(_iDistancia, _eEstacion);
            decimal dMargenUtilidad = recuperadorDatosPaqueteriaService.ObtenerMargenUtilidad(_dtFechaPedido);
            dCostoServicio = dCostoTransporte * dMargenUtilidad;

            return dCostoServicio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaPedido"></param>
        /// <param name="_iDistancia"></param>
        /// <returns></returns>
        public decimal ObtenerTiempoTransporte(DateTime _dtFechaPedido, int _iDistancia)
        {
            decimal dTiempoTotal = 0;
            var EstacionAnnio = validadorDatosPedido.ValidarEstacionAnio(_dtFechaPedido);
            var dtiempotraslado = obtenedorDatosEnvioService.ObtenerTiempoDeTraslado(_iDistancia, EstacionAnnio);
            var dTiempoTrasladoHoras = dtiempotraslado * 24;
            var eMedioTransporte = obtenedorDatosEnvioService.ObtenerMedioTransporte();
            var dTiempoEntrega = recuperadorDatosPaqueteriaService.ObtenerTiempoRepartoHoras(eMedioTransporte);

            dTiempoTotal = dTiempoTrasladoHoras + dTiempoEntrega;

            return dTiempoTotal;
        }

        public List<Pedido> ObtenerListaPedidos()
        {
            List<Pedido> lstPedidos = recuperadorDatosPedido.ObtenerListaPedidos();

            return lstPedidos;
        }
    }
}
