using System.Collections.Generic;

namespace AliExpress.Datos.Interfaces.DatosPedido
{
    public interface IRecuperadorDatosPedido
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Entities.Pedido> ObtenerListaPedidos();
    }
}
