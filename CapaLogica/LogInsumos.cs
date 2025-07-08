using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogInsumos
    {
        #region Singleton
        private static readonly LogInsumos _instancia = new LogInsumos();
        public static LogInsumos Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos Lógicos

        public List<entInsumos> ListarInsumos()
        {
            return datInsumos.Instancia.ListarInsumos();
        }

        public bool InsertarInsumo(entInsumos insumo)
        {
            return datInsumos.Instancia.InsertarInsumo(insumo);
        }

        public  bool ModificarInsumo(entInsumos insumo)
        {
            return datInsumos.Instancia.ModificarInsumo(insumo);
        }

        public bool InhabilitarInsumo(entInsumos insumo)
        {
            return datInsumos.Instancia.InhabilitarInsumo(insumo);
        }

        #endregion
    }

}


