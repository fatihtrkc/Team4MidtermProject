using EntitiyLayer.Entities;
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
    internal class GoalCfg : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.Property(b => b.Description).HasMaxLength(100);


            builder.HasData
                (
                    new Goal() { GoalType = GoalType.Zayıflamak, Description = "Kilo vermek istiyorum." },
                    new Goal() { GoalType = GoalType.KiloAlmak, Description = "Dengeli bir şekilde kilo almak istiyorum." },
                    new Goal() { GoalType = GoalType.HızlıKiloAlmak, Description = "Hızlı ve sağlıklı bir şekilde kilo almalıyım." },
                    new Goal() { GoalType = GoalType.KiloyuKorumak, Description = "Mevcut kilomu korumak istiyorum" }
                );
        }
    }
}
