using System;

namespace AliExpress.Entities
{
    /// <summary>
    /// Clase perteneciente al pedido.
    /// </summary>
    public class Pedido
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public Pedido()
        {
            this.iIdPedido = 0;
            this.iDistancia = 0;
            this.cPaqueteria = string.Empty;
            this.cMedioTransporte = string.Empty;
            this.dtFechaPedido = DateTime.MinValue;
            this.cPaisOrigen = string.Empty;
            this.cCiudadOrigen = string.Empty;
            this.cPaisDestino = string.Empty;
            this.cCiudadDestino = string.Empty;
        }

        /// <summary>
        /// Identificador del Pedido.
        /// </summary>
        public int iIdPedido { get; set; }

        /// <summary>
        /// distancia del pedido.
        /// </summary>
        public int iDistancia { get; set; }

        /// <summary>
        /// Empresa de paquetería para el envío del pedido.
        /// </summary>
        public string cPaqueteria { get; set; }

        /// <summary>
        /// Medio de transporte elegido para el pedido.
        /// </summary>
        public string cMedioTransporte { get; set; }

        /// <summary>
        /// Fecha y hora del pedido.
        /// </summary>
        public DateTime dtFechaPedido { get; set; }

        /// <summary>
        /// País de origen del pedido.
        /// </summary>
        public string cPaisOrigen { get; set; }

        /// <summary>
        /// Ciudad de origen del pedido.
        /// </summary>
        public string cCiudadOrigen { get; set; }

        /// <summary>
        /// País de destino del pedido.
        /// </summary>
        public string cPaisDestino { get; set; }

        /// <summary>
        /// Ciudad de destino del pedido.
        /// </summary>
        public string cCiudadDestino { get; set; }
    }
}
