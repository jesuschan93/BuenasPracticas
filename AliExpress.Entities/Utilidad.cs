namespace AliExpress.Entities
{
    /// <summary>
    /// Clase perteneciente la los margenes de utilidad
    /// </summary>
    public class Utilidad
    {
        public Utilidad()
        {
            this.dTiempoReparto = 0M;
            this.iIdMedioTransporte = 0;
        }

        /// <summary>
        /// Tiempo de reparto.
        /// </summary>
        public decimal dTiempoReparto { get; set; }

        /// <summary>
        /// Identificador del Medio de Transporte.
        /// </summary>
        public int iIdMedioTransporte { get; set; }
    }   
}
