using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_SaaS.Domain.Entities
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string Numero { get; set; } = default!; // único
        public int Piso { get; set; }
        public string Estado { get; set; } = "Disponible"; // Disponible/Ocupada/Mantenimiento

        public int TipoHabitacionId { get; set; }
        public TipoHabitacion TipoHabitacion { get; set; } = default!;
    }
}
