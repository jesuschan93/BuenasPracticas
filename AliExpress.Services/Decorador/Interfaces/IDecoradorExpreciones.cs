using System;
using System.Collections.Generic;
using System.Text;

namespace AliExpress.Services.Decorador.Interfaces
{
    public interface IDecoradorExpreciones
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaEntrega"></param>
        /// <param name="lstExpresiones"></param>
        void ProcesarListaExpresiones(DateTime _dtFechaEntrega, ref List<string> lstExpresiones);
    }
}
