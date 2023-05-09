using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using EntityLayer.Entities;
using EntityLayer.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configuration
{
    internal class UnitCfg : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.Property(b => b.Description).HasMaxLength(50);

            builder.HasData
                (
                new Unit() { Name = UnitType.gr, Description = "1 gram" },
                new Unit() { Name = UnitType.Porsiyon, Description = "1 tabak / 1 dilim / Tam" },
                new Unit() { Name = UnitType.Adet, Description = "1 tane" },
                new Unit() { Name = UnitType.lt, Description = "1000 mililitre" }
                );
        }
    }
}
