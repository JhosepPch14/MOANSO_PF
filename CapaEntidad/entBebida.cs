using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entBebida
    {
        public int IdBebida { get; set; }
        public int TipoBebida { get; set; }
        public string NombreBebida { get; set; }
        public decimal Precio { get; set; }
        public string Tamaño { get; set; }
        public Boolean EstadoBebida { get; set; }
    }
}
