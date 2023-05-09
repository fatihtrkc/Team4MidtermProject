using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    internal class CategoryCfg : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(50);
            builder.HasIndex(a => a.Name).IsUnique();

            builder.HasData
                (
                new Category() { Name = "Kahvaltılık" }, //1
                new Category() { Name = "Süt ve Süt Ürünleri" }, //2
                new Category() { Name = "Meyve ve Sebze" },//3
                new Category() { Name = "Ev Yemekleri" },//4
                new Category() { Name = "Et Yemekleri" },//5
                new Category() { Name = "Fast Food" },//6
                new Category() { Name = "Tatlı" },//7
                new Category() { Name = "Fırın" },//8
                new Category() { Name = "Atıştırmalık" },//9
                new Category() { Name = "İçecekler" }//10
                );
        }
    }
}
