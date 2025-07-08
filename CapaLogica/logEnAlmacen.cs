using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logEnAlmacen
    {
        #region Singleton

        private static readonly logEnAlmacen _instancia = new logEnAlmacen();
        public static logEnAlmacen Instancia { get { return logEnAlmacen._instancia; } }

        #endregion Singleton

        #region Metodos

        public List<entEnAlmacen> ListarEnAlmacen()
        {
            return datEnAlmacen.Instancia.ListarEnAlmacen();
        }
        public bool agregarEnAlmacen(entEnAlmacen ea) {
            return datEnAlmacen.Instancia.agregarEnAlmacen(ea);
        }
        public bool modificarEnAlmacen(entEnAlmacen ea)
        {
            return datEnAlmacen.Instancia.modificarEnAlmacen(ea);
        }
        public bool deshabilitarEnAlmacen(entEnAlmacen ea)
        {
            return datEnAlmacen.Instancia.inhabilitarEnAlmacen(ea);
        }
        #endregion Metodos
    }
}
