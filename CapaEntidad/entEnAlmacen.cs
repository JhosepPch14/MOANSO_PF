﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEnAlmacen
    {
        public int IDEnAlmacen { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
    }
}
