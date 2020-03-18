using System.Collections.Generic;

namespace AliExpress.Services.Interfaces.DatosPedido
{
    public interface IRecuperadorDatosPedidoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Entities.Pedido> ObtenerListaPedidos();
    }
}
