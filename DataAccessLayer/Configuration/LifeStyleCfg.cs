using EntitiyLayer.Entities;
using EntityLayer.Entities;
using EntityLayer.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class LifeStyleCfg : IEntityTypeConfiguration<LifeStyle>
    {
        public void Configure(EntityTypeBuilder<LifeStyle> builder)
        {
            builder.Property(b => b.Description).HasMaxLength(100);


            builder.HasData
                (
                    new LifeStyle() { Type = LifeStyleType.Never, Description = "Haraket etmiyorum veya çok az hareket ediyorum" },
                    new LifeStyle() { Type = LifeStyleType.Low, Description = "Haftada 1-3 gün egzersiz yapıyorum" },
                    new LifeStyle() { Type = LifeStyleType.Middle, Description = "Haftada 3-5 gün egzersiz yapıyorum" },
                    new LifeStyle() { Type = LifeStyleType.High, Description = "Haftada 6-7 gün egzersiz yapıyorum" },
                    new LifeStyle() { Type = LifeStyleType.More, Description = "Profesyonel sporcu, atlet seviyesi" }
                );
        }
    }
}
