using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_SaaS.Domain.Entities
{
    public class ReservaItem
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; } = default!;

        public DateTime Fecha { get; set; }                 // una línea por noche
        public int TipoHabitacionId { get; set; }           // categoría reservada
        public decimal PrecioNoche { get; set; }
        public int Cantidad { get; set; } = 1;              // # de habitaciones de ese tipo
        public string? ImpuestosAplicados { get; set; }     // JSON/Texto (opcional)

    }
}
