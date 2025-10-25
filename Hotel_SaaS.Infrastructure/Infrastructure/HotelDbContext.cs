using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_SaaS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel_SaaS.Infrastructure.Infrastructure
{
    public class HotelDbContext: DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public DbSet<Hotel> Hoteles => Set<Hotel>();
        public DbSet<TipoHabitacion> TiposHabitacion => Set<TipoHabitacion>();
        public DbSet<Habitacion> Habitaciones => Set<Habitacion>();
        public DbSet<Huesped> Huespedes => Set<Huesped>();
        public DbSet<Reserva> Reservas => Set<Reserva>();
        public DbSet<ReservaItem> ReservaItems => Set<ReservaItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HotelDbContext).Assembly);

            // Semilla mono-hotel
            modelBuilder.Entity<Hotel>().HasData(new Hotel
            {
                Id = 1,
                Nombre = "Hotel Mirador del Valle",
                RntCodigo = "CR-12345",
                Direccion = "San José, Costa Rica",
                Telefono = "2222-3333",
                EmailContacto = "info@miradordelvalle.com",
                SitioWeb = "https://miradordelvalle.example",
                MonedaBase = "CRC",
                TimeZone = "America/Costa_Rica",
                LogoUrl = null
            });
        }
    }
}
