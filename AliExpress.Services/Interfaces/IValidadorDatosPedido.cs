using AliExpress.Entities.Enumerables;
using System;
using System.Collections.Generic;
using System.Text;

namespace AliExpress.Services.Interfaces
{
    /// <summary>
    /// Interfaz de la clase ValidadorDatosPedido.
    /// </summary>
    public interface IValidadorDatosPedido
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        EEstaciones ValidarEstacionAnio(DateTime _dtFecha);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaEntrega"></param>
        List<string> ObtenerExpresion(DateTime _dtFechaEntrega);
    }
}
