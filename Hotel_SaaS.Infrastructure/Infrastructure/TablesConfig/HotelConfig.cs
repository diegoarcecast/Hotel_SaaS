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
    public class HotelConfig
    {
        public void Configure(EntityTypeBuilder<Hotel> b)
        {
            b.ToTable("Hotel");
            b.HasKey(x => x.Id);

            b.Property(x => x.Nombre).HasMaxLength(150).IsRequired();
            b.Property(x => x.RntCodigo).HasMaxLength(50).IsRequired();
            b.Property(x => x.Direccion).HasMaxLength(300).IsRequired();
            b.Property(x => x.Telefono).HasMaxLength(30).IsRequired();
            b.Property(x => x.EmailContacto).HasMaxLength(200).IsRequired();
            b.Property(x => x.SitioWeb).HasMaxLength(200).IsRequired();
            b.Property(x => x.MonedaBase).HasMaxLength(10).IsRequired();
            b.Property(x => x.TimeZone).HasMaxLength(100).IsRequired();

        }
    }
}
