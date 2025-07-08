using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string RUC { get; set; } 
        public string EmailProveedor { get; set; } 
        public DateTime FechaRProveedor { get; set; }
        public Boolean EstadoProveedor { get; set; }
    }
}
