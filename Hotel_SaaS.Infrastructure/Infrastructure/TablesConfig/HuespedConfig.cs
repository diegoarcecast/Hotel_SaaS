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
    public class HuespedConfig
    {
        public void Configure(EntityTypeBuilder<Huesped> b)
        {
            b.ToTable("Huesped");
            b.HasKey(x => x.Id);

            b.Property(x => x.Nombre).HasMaxLength(100).IsRequired();
            b.Property(x => x.Apellidos).HasMaxLength(120).IsRequired();
            b.Property(x => x.Email).HasMaxLength(200).IsRequired();
            b.Property(x => x.Telefono).HasMaxLength(30).IsRequired();
            b.Property(x => x.Documento).HasMaxLength(50).IsRequired();

            b.HasIndex(x => x.Email).IsUnique();

            b.HasMany(x => x.Reservas)
             .WithOne(x => x.Huesped)
             .HasForeignKey(x => x.HuespedId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
