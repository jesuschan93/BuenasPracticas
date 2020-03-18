using AliExpress.Services.Decorador.Interfaces;
using System;
using System.Collections.Generic;

namespace AliExpress.Services.Decorador
{
    public class DecoradorExpreciones: IDecoradorExpreciones
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaEntrega"></param>
        /// <param name="_lstExpresiones"></param>
        public void ProcesarListaExpresiones(DateTime _dtFechaEntrega, ref List<string> _lstExpresiones)
        {
            string cMensaje = string.Empty;
            if (_dtFechaEntrega < DateTime.Now)
            {
                cMensaje = "salió";
            }
            else
            {
                cMensaje = "ha salido";
            }
            _lstExpresiones.Add(cMensaje);
        }
    }
}
