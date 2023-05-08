using EntitiyLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class UserCfg : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(b => b.Email).HasMaxLength(20);
            builder.HasIndex(b => b.Email).IsUnique();
            builder.Property(b => b.Name).HasMaxLength(20);
            builder.Property(b => b.Surname).HasMaxLength(20);
            builder.Property(b => b.SpecificQuestion).HasMaxLength(100);
            builder.Property(b => b.QuestionAnswer).HasMaxLength(20);
            builder.Property(b => b.ActivePassiveSituation).HasDefaultValue(true);
        }
    }
}
