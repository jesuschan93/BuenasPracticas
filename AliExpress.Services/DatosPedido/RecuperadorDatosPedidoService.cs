using AliExpress.Datos.Interfaces.DatosPedido;
using AliExpress.Services.Interfaces.DatosPedido;
using System;
using System.Collections.Generic;

namespace AliExpress.Services.DatosPedido
{
    public class RecuperadorDatosPedidoService: IRecuperadorDatosPedidoService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IRecuperadorDatosPedido recuperadorDatosPedido;
        public RecuperadorDatosPedidoService(IRecuperadorDatosPedido _recuperadorDatosPedido)
        {
            recuperadorDatosPedido = _recuperadorDatosPedido ?? throw new ArgumentNullException(nameof(_recuperadorDatosPedido));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Entities.Pedido> ObtenerListaPedidos()
        {
            return recuperadorDatosPedido.ObtenerListaPedidos();
        }
    }
}
