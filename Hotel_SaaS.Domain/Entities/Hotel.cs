using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_SaaS.Domain.Entities
{
   

    public class Hotel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = default!;
        public string RntCodigo { get; set; } = default!;
        public string Direccion { get; set; } = default!;
        public string Telefono { get; set; } = default!;
        public string EmailContacto { get; set; } = default!;
        public string SitioWeb { get; set; } = default!;
        public string MonedaBase { get; set; } = "CRC";
        public string TimeZone { get; set; } = "America/Costa_Rica";
        public string? LogoUrl { get; set; }
    }

}

