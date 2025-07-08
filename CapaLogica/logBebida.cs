using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logBebida
    {
        #region Singleton

        private static readonly logBebida _instancia = new logBebida();
        public static logBebida Instancia { get { return logBebida._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entBebida> ListarBebida()
        {
            return datBebida.Instancia.ListarBebida();
        }

        public bool agregarBebida(entBebida b)
        {
            return datBebida.Instancia.agregarBebida(b);
        }

        public bool modificarBebida(entBebida b)
        {
            return datBebida.Instancia.modificarBebida(b);
        }

        public bool inhabilitarBebida(entBebida b)
        {
            return datBebida.Instancia.inhabilitarBebida(b);
        }

        #endregion Metodos
    }
}
