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
    public class HabitacionConfig
    {
        public void Configure(EntityTypeBuilder<Habitacion> b)
        {
            b.ToTable("Habitacion");
            b.HasKey(x => x.Id);

            b.Property(x => x.Numero).HasMaxLength(20).IsRequired();
            b.Property(x => x.Piso).IsRequired();
            b.Property(x => x.Estado).HasMaxLength(30).HasDefaultValue("Disponible");

            b.HasIndex(x => x.Numero).IsUnique();
        }
    }
}
