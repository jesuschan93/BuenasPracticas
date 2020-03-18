using System.Collections.Generic;

namespace AliExpress.Entities
{
    /// <summary>
    /// Clase perteneciente a las empresas.
    /// </summary>
    public class Empresa
    {
        public Empresa()
        {
            this.iIdEmpresa = 0;
            this.cNombre = string.Empty;
            this.UtilidadEmpresa = new List<Utilidad>();
        }

        /// <summary>
        /// Identificador de la Empresa.
        /// </summary>
        public int iIdEmpresa { get; set; }

        /// <summary>
        /// Nombre de la Empresa.
        /// </summary>
        public string cNombre { get; set; }   
        
        /// <summary>
        /// Utilidad de la empresa.
        /// </summary>
        public List<Utilidad> UtilidadEmpresa { get; set; }
    }
    
}
