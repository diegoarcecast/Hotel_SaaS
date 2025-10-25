using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_SaaS.Domain.Entities
{
    public class Huesped
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = default!;
        public string Apellidos { get; set; } = default!;
        public string Email { get; set; } = default!;   // único
        public string Telefono { get; set; } = default!;
        public string Documento { get; set; } = default!;

        public List<Reserva> Reservas { get; set; } = new();
    }
}
