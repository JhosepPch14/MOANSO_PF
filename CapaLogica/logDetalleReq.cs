using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logDetalleReq
    {
        #region Singleton

        private static readonly logDetalleReq _instancia = new logDetalleReq();
        public static logDetalleReq Instancia { get { return logDetalleReq._instancia; } }

        #endregion Singleton

        #region Metodos 

        public List<entDetalleReq> ListarDetallesReq(int requerimientoID) { 
            return datDetalleReq.Instancia.ListarDetalles(requerimientoID);
        }
        public bool registrarDetalleReq(List<entDetalleReq> ldr, int requerimientoID)
        {
            return datDetalleReq.Instancia.registrarDetalleReq(ldr, requerimientoID);
        }
        #endregion Metodos
    }
}
