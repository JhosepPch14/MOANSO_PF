using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCompraReq
    {
        public int IdCompra { get; set; }
        public string Encargado { get; set; }
        public DateTime FechaCompra { get; set; }
        public string MetodoPago { get; set; }
        public decimal MontoTotal { get; set; }
        public int IDRequerimiento { get; set; }
        public int IDProveedor { get; set; }
        public bool EstadoCompra { get; set; } // Para el estado (Activo/Anulado)
    }
}
