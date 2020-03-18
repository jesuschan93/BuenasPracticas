using AliExpress.Services.Decorador.Interfaces;
using System;
using System.Collections.Generic;

namespace AliExpress.Services.Decorador
{
    public class DecoradorExprecionUno: IDecoradorExpreciones
    {
        public readonly IDecoradorExpreciones decoradorExpreciones;
        public DecoradorExprecionUno(IDecoradorExpreciones _decoradorExpreciones) {
            decoradorExpreciones = _decoradorExpreciones ?? throw new ArgumentNullException(nameof(_decoradorExpreciones));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dtFechaEntrega"></param>
        /// <param name="_lstExpresiones"></param>
        public void ProcesarListaExpresiones(DateTime _dtFechaEntrega, ref List<string> _lstExpresiones)
        {
            decoradorExpreciones.ProcesarListaExpresiones(_dtFechaEntrega, ref _lstExpresiones);
            string cMensaje = string.Empty;
            if (_dtFechaEntrega < DateTime.Now)
            {
                cMensaje = "llegó";
            }
            else
            {
                cMensaje = "llegará";
            }
            _lstExpresiones.Add(cMensaje);
        }
    }
}
