using AliExpress.Datos.Interfaces.DatosPedido;
using System;
using System.Collections.Generic;
using System.IO;

namespace AliExpress.Datos.DatosPedido
{
    public class RecuperadorDatosPedido: IRecuperadorDatosPedido
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Entities.Pedido> ObtenerListaPedidos()
        {
            List<Entities.Pedido> lstPedidos = new List<Entities.Pedido>();
            string cRuta = ObtenerRutaArchivo();
            string[] Datos = System.IO.File.ReadAllLines(cRuta);
            foreach (string item in Datos)
            {
                int iDistancia = 0;
                DateTime dtFechaPedido = DateTime.MinValue;
                var lstDatosPedido = item.Split(",".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);
                int.TryParse(lstDatosPedido[0], out iDistancia);
                DateTime.TryParse(lstDatosPedido[3], out dtFechaPedido);
                Entities.Pedido objPedido = new Entities.Pedido()
                {
                    iDistancia = iDistancia,
                    cPaqueteria = lstDatosPedido[1],
                    cMedioTransporte = lstDatosPedido[2],
                    dtFechaPedido = dtFechaPedido,
                    cPaisOrigen = lstDatosPedido[4],
                    cCiudadOrigen = lstDatosPedido[5],
                    cPaisDestino = lstDatosPedido[6],
                    cCiudadDestino = lstDatosPedido[7]
                };
                lstPedidos.Add(objPedido);
            }
            return lstPedidos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string ObtenerRutaArchivo()
        {
            string cArchivo = "Pedidos.csv";
            string cRuta = Path.GetFullPath(".\\..\\..\\..\\..\\");

            cRuta = string.Format("{0}{1}", cRuta, cArchivo);

            return cRuta;
        }
    }
}
