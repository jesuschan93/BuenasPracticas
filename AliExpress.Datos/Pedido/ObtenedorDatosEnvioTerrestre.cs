using AliExpress.Datos.Interfaces.Pedido;
using AliExpress.Entities.Enumerables;
using System;

namespace AliExpress.Datos.Pedido
{
    /// <summary>
    /// Clase encargado de obtener los costos de envío por el medio de Transporte Terrestre.
    /// </summary>
    public class ObtenedorDatosEnvioTerrestre : IObtenedorDatosEnvio
    {
        /// <summary>
        /// Método encargado de obtener el precio por kilómetros.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <param name="_eEstacion">Estación del año.</param>
        /// <returns>Retorna el precio por kilómetros.</returns>
        public decimal ObtenerCostoPorEnvio(int _iDistancia, EEstaciones _eEstacion)
        {
            return 0;
        }

        /// <summary>
        /// Método encargado de obtener la velocidad de entrega.
        /// </summary>
        /// <returns>Retorna la velocidad de entrega.</returns>
        public int ObtenerVelocidadEntrega()
        {
            return 80;
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
            decimal iVelocidadEntrega = ObtenerVelocidadEntrega();
            decimal dRetrasoEstacion = ObtenerRetrasoPorEstacion(_eEstacion);
            decimal dTiempoEntrega = _iDistancia / iVelocidadEntrega;
            decimal dTiempoEntregaEnDias = Math.Round((dTiempoEntrega / 24),2);

            decimal dTiempoExtra = (dTiempoEntregaEnDias * dRetrasoEstacion)/24;
            dTiempoExtra = Math.Round(dTiempoExtra, 2);
            dTiempoTraslado = dTiempoEntregaEnDias + dTiempoExtra;

            return dTiempoTraslado;
        }

        /// <summary>
        /// Método encargado de obtener el precio por kilómetros.
        /// </summary>
        /// <param name="_iDistancia">Distancia de entrega.</param>
        /// <returns>Retorna el precio por kilómetros.</returns>
        private decimal ObtenerCostoPorKilometro(int _iDistancia)
        {
            decimal dCosto = 0M;
            ObtenerCostoDistanciaMenorACincuenta(_iDistancia, ref dCosto);
            ObtenerCostoDistanciaMenorADocientos(_iDistancia, ref dCosto);
            ObtenerCostoDistanciaMenorATrecientos(_iDistancia, ref dCosto);
            ObtenerCostoDistanciaMayorATrecientos(_iDistancia, ref dCosto);
            return dCosto;
        }

        /// <summary>
        /// Método encargado de Validar que la distancia se encuentre entre el rango de 1 a 100.
        /// </summary>
        /// <param name="_iDistancia">Distancia a evaluar.</param>
        /// <param name="dCosto">Costo enviado como referencia.</param>
        private void ObtenerCostoDistanciaMenorACincuenta(int _iDistancia, ref decimal dCosto)
        {
            if (_iDistancia > 0 && _iDistancia <= 50)
            {
                dCosto = 15M;
            }
        }

        /// <summary>
        /// Método encargado de Validar que la distancia se encuentre entre el rango de 51 a 200.
        /// </summary>
        /// <param name="_iDistancia">Distancia a evaluar.</param>
        /// <param name="dCosto">Costo enviado como referencia.</param>
        private void ObtenerCostoDistanciaMenorADocientos(int _iDistancia, ref decimal dCosto)
        {
            if (_iDistancia > 51 && _iDistancia <= 200)
            {
                dCosto = 10M;
            }
        }

        /// <summary>
        /// Método encargado de Validar que la distancia se encuentre entre el rango de 201 a 300.
        /// </summary>
        /// <param name="_iDistancia">Distancia a evaluar.</param>
        /// <param name="dCosto">Costo enviado como referencia.</param>
        private void ObtenerCostoDistanciaMenorATrecientos(int _iDistancia, ref decimal dCosto)
        {
            if (_iDistancia > 201 && _iDistancia <= 300)
            {
                dCosto = 8M;
            }
        }

        /// <summary>
        /// Método encargado de Validar que la distancia sea mayor a 300.
        /// </summary>
        /// <param name="_iDistancia">Distancia a evaluar.</param>
        /// <param name="dCosto">Costo enviado como referencia.</param>
        private void ObtenerCostoDistanciaMayorATrecientos(int _iDistancia, ref decimal dCosto)
        {
            if (_iDistancia > 300)
            {
                dCosto = 7M;
            }
        }

        private decimal ObtenerRetrasoPorEstacion(EEstaciones _eEstacion)
        {
            decimal _dPorcentaje = 0;
            switch (_eEstacion)
            {
                case EEstaciones.Primavera:
                    _dPorcentaje = 4;
                    break;
                case EEstaciones.Vernao:
                    _dPorcentaje = 6;
                    break;
                case EEstaciones.Otonio:
                    _dPorcentaje = 5;
                    break;
                case EEstaciones.Invierno:
                    _dPorcentaje = 8;
                    break;
            }

            return _dPorcentaje;
        }
    }
}
