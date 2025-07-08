using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int ClienteID { get; set; }
        public string Nombre_Cliente { get; set; }
        public int DNI { get; set; }
        public int Numero { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }
        public Boolean EstadoCliente { get; set; }
    }
}
