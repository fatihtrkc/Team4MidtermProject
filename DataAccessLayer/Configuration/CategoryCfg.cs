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
                new Category() { Id = 1, Name = "Kahvaltılık" }, //1
                new Category() { Id = 2, Name = "Süt ve Süt Ürünleri" }, //2
                new Category() { Id = 3, Name = "Meyve ve Sebze" },//3
                new Category() { Id = 4, Name = "Ev Yemekleri" },//4
                new Category() { Id = 5, Name = "Et Yemekleri" },//5
                new Category() { Id = 6, Name = "Fast Food" },//6
                new Category() { Id = 7, Name = "Tatlı" },//7
                new Category() { Id = 8, Name = "Fırın" },//8
                new Category() { Id = 9, Name = "Atıştırmalık" },//9
                new Category() { Id = 10, Name = "İçecekler" }//10
                );
        }
    }
}
