using AliExpress.Datos.Interfaces.Pedido;
using AliExpress.Entities.Enumerables;
using System;

namespace AliExpress.Datos.Pedido
{
    /// <summary>
    /// Clase encargado de obtener los costos de envío por el medio de Transporte Marítimo.
    /// </summary>
    public class ObtenedorDatosEnvioMaritimo : IObtenedorDatosEnvio
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
            decimal dCostoPorKilometro = ObtenerCostoPorKilometro(_iDistancia);
            decimal dCostoPorEnvio = ObtenerPorcentajeCostoPorEstacion(_eEstacion);
            dCostoEnvio = _iDistancia * dCostoPorKilometro;
            dCostoEnvio = dCostoEnvio * dCostoPorEnvio;
            
            return dCostoEnvio;
        }

        /// <summary>
        /// Método encargado de obtener la velocidad de entrega.
        /// </summary>
        /// <returns>Retorna la velocidad de entrega.</returns>
        public int ObtenerVelocidadEntrega()
        {
            return 46;
        }

        /// <summary>
        /// Método encargado de obtener el tiempo de traslado del pedido.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <param name="_eEstacion">Estación del año.</param>
        /// <returns>Retorna el tiempo total de traslado.</returns>
        public decimal ObtenerTiempoDeTraslado(int _iDistancia, EEstaciones _eEstacion)
        {
            decimal dTiempoTraslado = 0M;
            int iVelocidad = ObtenerVelocidadEntrega();
            decimal dPorcentajeEstacion = ObtenerPorcentajeVelocidadPorEstacion(_eEstacion);

            decimal dVelocidad = iVelocidad + (iVelocidad * dPorcentajeEstacion);

            dTiempoTraslado = _iDistancia / dVelocidad;
            dTiempoTraslado = (dTiempoTraslado / 24);

            return Math.Round(dTiempoTraslado,2);
        }

        /// <summary>
        /// Método encargado de obtener el precio por kilómetros.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <returns>Retorna el precio por kilómetros.</returns>
        private decimal ObtenerCostoPorKilometro(int _iDistancia)
        {
            decimal dCosto = 0M;
            ObtenerCostoDistanciaMenorACien(_iDistancia, ref dCosto);
            ObtenerCostoDistanciaMenorAMil(_iDistancia, ref dCosto);
            ObtenerCostoDistanciaMayoAMil(_iDistancia, ref dCosto);
            return dCosto;
        }

        /// <summary>
        /// Método encargado de Validar que la distancia se encuentre entre el rango de 1 a 100.
        /// </summary>
        /// <param name="_iDistancia">Distancia a evaluar.</param>
        /// <param name="dCosto">Costo enviado como referencia.</param>
        private void ObtenerCostoDistanciaMenorACien(int _iDistancia, ref decimal dCosto)
        {
            if (_iDistancia > 0 && _iDistancia <= 100)
            {
                dCosto = 1M;
            }
        }

        /// <summary>
        /// Método encargado de Validar que la distancia se encuentre entre el rango de 100 a 1000.
        /// </summary>
        /// <param name="_iDistancia">Distancia a evaluar.</param>
        /// <param name="dCosto">Costo enviado como referencia.</param>
        private void ObtenerCostoDistanciaMenorAMil(int _iDistancia, ref decimal dCosto)
        {
            if (_iDistancia > 100 && _iDistancia <= 1000)
            {
                dCosto = 0.5M;
            }
        }

        /// <summary>
        /// Método encargado de Validar que la distancia sea mayor a 1000.
        /// </summary>
        /// <param name="_iDistancia">Distancia a evaluar.</param>
        /// <param name="dCosto">Costo enviado como referencia.</param>
        private void ObtenerCostoDistanciaMayoAMil(int _iDistancia, ref decimal dCosto)
        {
            if (_iDistancia > 1000)
            {
                dCosto = 0.3M;
            }
        }

        private decimal ObtenerPorcentajeVelocidadPorEstacion(EEstaciones _eEstacion)
        {
            decimal _dPorcentaje = 0;
            switch (_eEstacion)
            {
                case EEstaciones.Primavera:
                    _dPorcentaje = 0;
                    break;
                case EEstaciones.Vernao:
                    _dPorcentaje = -10;
                    break;
                case EEstaciones.Otonio:
                    _dPorcentaje = 15;
                    break;
                case EEstaciones.Invierno:
                    _dPorcentaje = -30;
                    break;
            }

            return (_dPorcentaje / 100);
        }

        private decimal ObtenerPorcentajeCostoPorEstacion(EEstaciones _eEstacion)
        {
            decimal _dPorcentaje = 0;
            switch (_eEstacion)
            {
                case EEstaciones.Primavera:
                    _dPorcentaje = 0;
                    break;
                case EEstaciones.Vernao:
                    _dPorcentaje = 10;
                    break;
                case EEstaciones.Otonio:
                    _dPorcentaje = 15;
                    break;
                case EEstaciones.Invierno:
                    _dPorcentaje = 23;
                    break;
            }
            _dPorcentaje = ((_dPorcentaje / 100) + 1);

            return _dPorcentaje;
        }
    }
}
