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
    public class ReservaConfig
    {
        public void Configure(EntityTypeBuilder<Reserva> b)
        {
            b.ToTable("Reserva", t => t.HasCheckConstraint("CK_Reserva_Fechas", "[FechaInicio] < [FechaFin]"));
            b.HasKey(x => x.Id);

            b.Property(x => x.Canal).HasMaxLength(50).HasDefaultValue("Directo");
            b.Property(x => x.Estado).HasMaxLength(30).HasDefaultValue("Tentativa");
            b.Property(x => x.PoliticaCancelacion).HasMaxLength(200).HasDefaultValue("Flexible");
            b.Property(x => x.Moneda).HasMaxLength(10).HasDefaultValue("CRC");
            b.Property(x => x.Total).HasColumnType("decimal(18,2)");

            b.HasMany(x => x.Items)
             .WithOne(x => x.Reserva)
             .HasForeignKey(x => x.ReservaId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
