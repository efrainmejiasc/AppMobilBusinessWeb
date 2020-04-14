using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.Models
{
    public class FacturaVista
    {
        public string RazonSocial { get; set; }
        public string Rif { get; set; }
        public string NumeroFactura { get; set; }
        public TimeSpan FechaFactura { get; set; }
    }
}
