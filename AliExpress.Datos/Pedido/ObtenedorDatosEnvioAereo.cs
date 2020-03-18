using AliExpress.Datos.Interfaces.Pedido;
using AliExpress.Entities.Enumerables;
using System;

namespace AliExpress.Datos.Pedido
{
    /// <summary>
    /// Clase encargado de obtener los costos de envío por el medio de Transporte Aéreo.
    /// </summary>
    public class ObtenedorDatosEnvioAereo : IObtenedorDatosEnvio
    {
        /// <summary>
        /// Método encargado de obtener el precio por kilómetros.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <param name="_eEstacion">Estación del año.</param>
        /// <returns>Retorna el precio por kilómetros.</returns>
        public decimal ObtenerCostoPorEnvio(int _iDistancia, EEstaciones _eEstacion)
        {
            decimal dCostoEnvio = 0;
            decimal dCostoEscala = ObtenerCostoPorEscala();
            decimal dCostoPorKilometro = ObtenerCostoPorKilometro(_iDistancia);
            decimal dDistanciaEscala = _iDistancia / 1000;
            decimal dNumeroEscalas = Math.Truncate(dDistanciaEscala);

            decimal dCargoExtra = dNumeroEscalas * dCostoEscala;
            dCostoEnvio = (_iDistancia * dCostoPorKilometro);
            dCostoEnvio = dCostoEnvio + dCargoExtra;

            return dCostoEnvio;
        }

        /// <summary>
        /// Método encargado de obtener la velocidad de entrega.
        /// </summary>
        /// <returns>Retorna la velocidad de entrega.</returns>
        public int ObtenerVelocidadEntrega()
        {
            return 600;
        }

        /// <summary>
        /// Método encargado de obtener el tiempo de traslado del pedido.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <param name="_dtFechaPedido">Fecha del pedido.</param>
        /// <returns>Retorna el tiempo total de traslado.</returns>
        public decimal ObtenerTiempoDeTraslado(int _iDistancia, EEstaciones _eEstacion)
        {
            decimal dTiempoTraslado = 0;
            int iHorasPorEscala = 6;            
            int iVelocidadEntrega = ObtenerVelocidadEntrega();
            decimal dDistanciaEscala = _iDistancia / 1000;
            decimal dNumeroEscalas = Math.Truncate(dDistanciaEscala);
            decimal dTiempoExtra = dNumeroEscalas * iHorasPorEscala;

            dTiempoTraslado = (_iDistancia / iVelocidadEntrega);
            dTiempoTraslado = dTiempoTraslado + dTiempoExtra;

            return dTiempoTraslado;
        }

        /// <summary>
        /// Método encargado de obtener el precio por escala.
        /// </summary>
        /// <returns>Retorna el precio por escala.</returns>
        private decimal ObtenerCostoPorEscala()
        {
            return 200M;
        }

        /// <summary>
        /// Método encargado de obtener el precio por kilómetros.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <returns>Retorna el precio por kilómetros.</returns>
        private decimal ObtenerCostoPorKilometro(int _iDistancia)
        {
            decimal dCosto = 0M;
            ObtenerCostoDistanciaMayorAUno(_iDistancia, ref dCosto);
            return dCosto;
        }        

        /// <summary>
        /// Método encargado de Validar que la distancia sea mayor a 1.
        /// </summary>
        /// <param name="_iDistancia">Distancia a evaluar.</param>
        /// <param name="dCosto">Costo enviado como referencia.</param>
        private void ObtenerCostoDistanciaMayorAUno(int _iDistancia, ref decimal dCosto)
        {
            if (_iDistancia > 1)
            {
                dCosto = 10M;
            }
        }
    }
}
