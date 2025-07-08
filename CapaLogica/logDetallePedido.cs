using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logDetallePedido
    {
        #region Singleton

        private static readonly logDetallePedido _instancia = new logDetallePedido();
        public static logDetallePedido Instancia { get { return logDetallePedido._instancia; } }

        #endregion Singleton 

        #region Metodos

        public List<entDetallePedido> ListarDetalles(int pedidoID)
        {
            return datDetallePedido.Instancia.ListarDetalles(pedidoID);
        }
        public bool registrarDetallePedido(List<entDetallePedido> ldp, int pedidoID) { 
            return datDetallePedido.Instancia.registrarDetalle(ldp, pedidoID);
        }
        public decimal CalcularTotalPorPedido(int pedidoID)
        {
            List<entDetallePedido> detalles = datDetallePedido.Instancia.ListarDetalles(pedidoID);
            return detalles.Sum(d => d.Subtotal);
        }

        #endregion Metodos
    }
}
