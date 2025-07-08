using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logOrdenPedido
    {
        #region Singleton

        private static readonly logOrdenPedido _instancia = new logOrdenPedido();
        public static logOrdenPedido Instancia { get { return logOrdenPedido._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entOrdenPedido> ListarOrdenes()
        {
            return datOrdenPedido.Instancia.ListarOrden();
        }

        public bool agregarOrden(entOrdenPedido op)
        {
            return datOrdenPedido.Instancia.agregarOrden(op);
        }

        public bool modificarOrden(entOrdenPedido op)
        {
            return datOrdenPedido.Instancia.modificarOrden(op);
        }

        public bool inhabilitarOrden(entOrdenPedido op)
        {
            return datOrdenPedido.Instancia.inhabilitarOrden(op);
        }
        public bool actualizarTotal(int pedidoID, decimal total)
        {
            return datOrdenPedido.Instancia.actualizarTotal(pedidoID, total);
        }


        #endregion Metodos
    }
}
