using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logPlatillo
    {
        #region Singleton

        private static readonly logPlatillo _instancia = new logPlatillo();
        public static logPlatillo Instancia { get { return logPlatillo._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entPlatillo> ListarPlatillo()
        {
            return datPlatillo.Instancia.ListarPlatillo();
        }

        public bool InsertarPlatillo(entPlatillo pla)
        {
            return datPlatillo.Instancia.InsertarPlatillo(pla);
        }

        public bool ModificarPlatillo(entPlatillo pla)
        {
            return datPlatillo.Instancia.EditarPlatillo(pla);
        }

        public bool DeshabilitarPlatillo(entPlatillo pla)
        {
            return datPlatillo.Instancia.DeshabilitarPlatillo(pla);
        }

        #endregion Metodos
    }
}
