using AliExpress.Datos.Interfaces.Pedido;
using AliExpress.Entities.Enumerables;
using AliExpress.Services.Interfaces.Pedido;

namespace AliExpress.Services.Pedido
{
    /// <summary>
    /// Clase encargado de obtener los costos de envío por el medio de Transporte Marítimo.
    /// </summary>
    public class ObtenedorDatosEnvioMaritimoService : IObtenedorDatosEnvioService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IObtenedorDatosEnvio obtenedorDatosEnvio;
        public ObtenedorDatosEnvioMaritimoService(IObtenedorDatosEnvio _obtenedorDatosEnvio)
        {
            obtenedorDatosEnvio = _obtenedorDatosEnvio ?? throw new System.ArgumentNullException(nameof(_obtenedorDatosEnvio));
        }

        public decimal ObtenerCostoPorEnvio(int _iDistancia, EEstaciones _eEstacion)
        {
            return obtenedorDatosEnvio.ObtenerCostoPorEnvio(_iDistancia, _eEstacion);
        }

        public decimal ObtenerTiempoDeTraslado(int _iDistancia, EEstaciones _eEstacion)
        {
            return obtenedorDatosEnvio.ObtenerTiempoDeTraslado(_iDistancia, _eEstacion);
        }

        /// <summary>
        /// Método encargado de obtener la velocidad de entrega.
        /// </summary>
        /// <returns>Retorna la velocidad de entrega.</returns>
        public int ObtenerVelocidadEntrega()
        {
            return obtenedorDatosEnvio.ObtenerVelocidadEntrega();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public EMediosTransporte ObtenerMedioTransporte()
        {
            return EMediosTransporte.Maritimo;
        }
    } 
}
