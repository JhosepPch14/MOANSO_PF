using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoBebida
    {
        #region Singleton
        private static readonly logTipoBebida _instancia = new logTipoBebida();
        public static logTipoBebida Instancia => _instancia;
        #endregion

        public List<entTipoBebida> ListarTBebida()
        {
            return datTipoBebida.Instancia.ListarTBebida();
        }

        public bool InsertarTBebida(entTipoBebida tb)
        {
            return datTipoBebida.Instancia.InsertarTBebida(tb);
        }

        public bool ModificarTBebida(entTipoBebida tb)
        {
            return datTipoBebida.Instancia.ModificarTBebida(tb);
        }

        public bool InhabilitarTBebida(entTipoBebida tb)
        {
            return datTipoBebida.Instancia.InhabilitarTBebida(tb);
        }
    }
}
