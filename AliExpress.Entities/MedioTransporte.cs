namespace AliExpress.Entities
{
    /// <summary>
    /// Clase perteneciente a los medios de transporte.
    /// </summary>
    public class MedioTransporte
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public MedioTransporte()
        {
            this.iIdMedioTransporte = 0;
            this.cMedioTransporte = string.Empty;
            this.iVelocidad = 0;
            this.dCostoEnvio = 0M;
            //this.lstVariante = new List<Variante>();            
        }

        /// <summary>
        /// Identificador del Medio de transporte.
        /// </summary>
        public int iIdMedioTransporte { get; set; }

        /// <summary>
        /// Medio de transporte.
        /// </summary>
        public string cMedioTransporte { get; set; }

        /// <summary>
        /// Velocidad de entrega.
        /// </summary>
        public int iVelocidad { get; set; }

        /// <summary>
        /// Costo por kilómetros en pesos.
        /// </summary>
        public decimal dCostoEnvio { get; set; }

        ///// <summary>
        ///// Variantes por temporada en porcentajes.
        ///// </summary>
        //public List<Variante> lstVariante { get; set; }
    }
}
