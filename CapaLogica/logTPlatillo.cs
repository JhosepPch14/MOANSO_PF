using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTPlatillo
    {
        #region Singleton

        private static readonly logTPlatillo _instancia = new logTPlatillo();
        public static logTPlatillo Instancia { get { return logTPlatillo._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entTPlatillo> ListarTPlatillo()
        {
            return datTPlatillo.Instancia.ListarTPlatillo();
        }
        public bool agregarTPLatillo(entTPlatillo tp) {
            return datTPlatillo.Instancia.agregarTPlatillo(tp);
        }
        public bool modificarTPLatillo(entTPlatillo tp) { 
            return datTPlatillo.Instancia.modificarTPlatillo(tp);

        }
        public bool inhabilitarTPLatillo(entTPlatillo tp) { 
            return datTPlatillo.Instancia.inhabilitarTPlatillo(tp);

        }


        #endregion Metodos
    }
}
