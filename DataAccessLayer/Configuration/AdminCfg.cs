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
    public class AdminCfg : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(b => b.Email).HasMaxLength(50);
            builder.HasIndex(b => b.Email).IsUnique();

            builder.HasData
                (
                new Admin() { Id = 1, Email = "admin@admin.com", Password = "60FE74406E7F353ED979F350F2FBB6A2E8690A5FA7D1B0C32983D1D8B3F95F67", CreationDate = DateTime.Now }
                );
        }
    }
}
