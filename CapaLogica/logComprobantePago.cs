using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logComprobantePago
    {
        #region Singleton

        private static readonly logComprobantePago _instancia = new logComprobantePago();
        public static logComprobantePago Instancia { get { return logComprobantePago._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entComprobantePago> ListarComprobantes() { 
            return datComprobantePago.Instancia.ListarComprobantes();
        }

        public bool registrarComprobante(entComprobantePago cop) {
            return datComprobantePago.Instancia.registrarComprobante(cop);
        }

        public bool deshabilitarComprobante(entComprobantePago cop) {
            return datComprobantePago.Instancia.deshabilitarComprobante(cop);
        }

        #endregion Metodos
    }
}
