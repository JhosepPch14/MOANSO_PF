using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenPedido
    {
        public int PedidoID { get; set; }
        public DateTime Fecha { get; set; }
        public int NroMesa { get; set; }
        public decimal Total { get; set; }
        public Boolean EstadoPedido { get; set; }
        public int MeseroID { get; set; }

        public String NombreMesero { get; set; }
    }
}
