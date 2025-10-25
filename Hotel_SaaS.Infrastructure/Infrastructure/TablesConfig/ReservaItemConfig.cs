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
    public class ReservaItemConfig
    {
        public void Configure(EntityTypeBuilder<ReservaItem> b)
        {
            b.ToTable("ReservaItem");
            b.HasKey(x => x.Id);

            b.Property(x => x.PrecioNoche).HasColumnType("decimal(18,2)");
            b.Property(x => x.Cantidad).HasDefaultValue(1);

            // Índice útil para búsquedas por fecha
            b.HasIndex(x => x.Fecha);
        }
    }
}
