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
            builder.Property(b => b.Email).HasMaxLength(30);
            builder.HasIndex(b => b.Email).IsUnique();

            builder.HasData
                (
                new Admin() { Email = "admin@admin.com", Password = "Admin1234", CreationDate = DateTime.Now }
                );
        }
    }
}
