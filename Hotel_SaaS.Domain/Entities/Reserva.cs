using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_SaaS.Domain.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public int HuespedId { get; set; }
        public Huesped Huesped { get; set; } = default!;

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public string Canal { get; set; } = "Directo"; // Directo/OTA
        public string Estado { get; set; } = "Tentativa"; // Tentativa/Confirmada/CheckIn/CheckOut/Cancelada
        public string PoliticaCancelacion { get; set; } = "Flexible";
        public string Moneda { get; set; } = "CRC";
        public decimal Total { get; set; }

        public List<ReservaItem> Items { get; set; } = new();
    }
}
