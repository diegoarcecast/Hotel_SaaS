using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_SaaS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_SaaS.Infrastructure.Infrastructure.TablesConfig
{
    public class TipoHabitacionConfig
    {
        public void Configure(EntityTypeBuilder<TipoHabitacion> b)
        {
            b.ToTable("TipoHabitacion");
            b.HasKey(x => x.Id);
            b.Property(x => x.Nombre).HasMaxLength(100).IsRequired();
            b.Property(x => x.Capacidad).IsRequired();

            b.HasMany(x => x.Habitaciones)
             .WithOne(x => x.TipoHabitacion)
             .HasForeignKey(x => x.TipoHabitacionId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
