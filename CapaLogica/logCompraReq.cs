using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCompraReq
    {
        #region Singleton

        private static readonly logCompraReq _instancia = new logCompraReq();
        public static logCompraReq Instancia { get { return logCompraReq._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entCompraReq> ListarCompraReq()
        {
            return datCompraReq.Instancia.ListarCompraReq();
        }
        public bool registrarCompraReq(entCompraReq cr) {
            return datCompraReq.Instancia.registrarCompraReq(cr);
        }
        public bool anularCompraReq(entCompraReq cr) {
            return datCompraReq.Instancia.anularCompraReq(cr);
        }

        #endregion Metodos
    }
}
