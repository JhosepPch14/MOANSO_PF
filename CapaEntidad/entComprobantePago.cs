using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entComprobantePago
    {
        public int ComprobanteID { get; set; }
        public int ClienteID { get; set; }
        public int PedidoID { get; set; }
        public string TipoComprobante { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal MontoTotal { get; set; }
        public bool EstadoComprobante { get; set; }
    }
}
