using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetallePedido
    {
        public int DetalleID { get; set; }
        public int PedidoID { get; set; }
        public int PlatilloID { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        public string NombrePlatillo { get; set; }
        public decimal Precio { get; set; }
    }
}
