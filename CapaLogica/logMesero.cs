using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logMesero
    {
        #region Singleton

        private static readonly logMesero _instancia = new logMesero();
        public static logMesero Instancia { get { return logMesero._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entMesero> ListarMesero()
        {
            return datMesero.Instancia.ListarMesero();
        }

        public bool agregarMesero(entMesero m)
        {
            return datMesero.Instancia.agregarMesero(m);
        }

        public bool modificarMesero(entMesero m)
        {
            return datMesero.Instancia.modificarMesero(m);
        }

        public bool inhabilitarMesero(entMesero m)
        {
            return datMesero.Instancia.inhabilitarMesero(m);
        }

        #endregion Metodos
    }
}
