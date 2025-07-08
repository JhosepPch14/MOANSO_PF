using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCliente
    {
        #region Singleton

        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia {  get { return logCliente._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        
        public bool agregarCliente (entCliente Cli) {
           return datCliente.Instancia.agregarCliente(Cli);
        }
        
        public bool modificarCliente (entCliente Cli) { 
            return datCliente.Instancia.modificarCliente(Cli);
        }

        public bool inhabilitarCliente (entCliente Cli) {
            return datCliente.Instancia.inhabilitarCliente(Cli);
        }

        #endregion Metodos
    }
}
