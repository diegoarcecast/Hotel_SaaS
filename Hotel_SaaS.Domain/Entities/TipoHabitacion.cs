using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_SaaS.Domain.Entities
{
    public class TipoHabitacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public string? Descripcion { get; set; }
        public List<Habitacion> Habitaciones { get; set; }
    }
}
