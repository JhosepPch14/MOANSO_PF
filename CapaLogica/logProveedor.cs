using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logProveedor
    {
        #region Singleton
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia
        {
            get { return logProveedor._instancia; }
        }
        #endregion Singleton

        #region Métodos Lógicos

        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        public bool InsertarProveedor(entProveedor prov)
        {
            return datProveedor.Instancia.InsertarProveedor(prov);
        }

        public bool ModificarProveedor(entProveedor prov)
        {
            return datProveedor.Instancia.EditarProveedor(prov);
        }

        public bool InhabilitarProveedor(entProveedor prov)
        {
            return datProveedor.Instancia.DeshabilitarProveedor(prov);
        }

        #endregion
    }
}
