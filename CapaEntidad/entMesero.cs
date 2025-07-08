using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMesero
    {
        public int IdMesero { get; set; }
        public string NombreMesero { get; set; }
        public int DNIMesero { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Boolean EstadoMesero { get; set; }
    }
}
