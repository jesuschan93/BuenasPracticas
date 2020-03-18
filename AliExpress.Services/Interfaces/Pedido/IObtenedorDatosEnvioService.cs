using AliExpress.Entities.Enumerables;

namespace AliExpress.Services.Interfaces.Pedido
{
    public interface IObtenedorDatosEnvioService
    {
        /// <summary>
        /// Método encargado de obtener el precio por kilómetros.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <param name="_eEstacion">Estación del año.</param>
        /// <returns>Retorna el precio por kilómetros.</returns>
        decimal ObtenerCostoPorEnvio(int _iDistancia, EEstaciones _eEstacion);

        /// <summary>
        /// Método encargado de obtener la velocidad de entrega.
        /// </summary>
        /// <returns>Retorna la velocidad de entrega.</returns>
        int ObtenerVelocidadEntrega();

        /// <summary>
        /// Método encargado de obtener el tiempo de traslado del pedido.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <param name="_eEstacion">Estación del año.</param>
        /// <returns>Retorna el tiempo total de traslado.</returns>
        decimal ObtenerTiempoDeTraslado(int _iDistancia, EEstaciones _eEstacion);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        EMediosTransporte ObtenerMedioTransporte();
    }
}
