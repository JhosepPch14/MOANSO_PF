using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logReqInsumos
    {
        #region Singleton

        private static readonly logReqInsumos _instancia = new logReqInsumos();
        public static logReqInsumos  Instancia { get { return logReqInsumos._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entReqInsumos> ListarReqInsumos()
        {
            return datReqInsumos.Instancia.ListarReq();
        }
        public bool registrarReq(entReqInsumos ri)
        {
            return datReqInsumos.Instancia.registrarReq(ri);
        }
        public bool anularReq(entReqInsumos ri)
        {
            return datReqInsumos.Instancia.anularReq(ri);
        }

        #endregion Metodos
    }
}
