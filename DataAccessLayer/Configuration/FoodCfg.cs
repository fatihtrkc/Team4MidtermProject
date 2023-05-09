using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Enums;

namespace DataAccessLayer.Configuration
{
    internal class FoodCfg : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(50);

            builder.HasData
                (
                //Category name => Kahvaltılık
                new Food() { Name = "Haşlanmış Yumurta", CaloryPerUnit = 75, CategoryId = 1, UnitId = UnitType.Adet },
                new Food() { Name = "Siyah Zeytin", CaloryPerUnit = 4.2, CategoryId = 1, UnitId = UnitType.Adet },
                new Food() { Name = "Yeşil Zeytin", CaloryPerUnit = 6, CategoryId = 1, UnitId = UnitType.Adet },
                new Food() { Name = "Çilek Reçeli", CaloryPerUnit = 2.3, CategoryId = 1, UnitId = UnitType.gr },
                new Food() { Name = "Vişne Reçeli", CaloryPerUnit = 2.7, CategoryId = 1, UnitId = UnitType.gr },
                new Food() { Name = "Pekmez", CaloryPerUnit = 3.5, CategoryId = 1, UnitId = UnitType.gr },
                new Food() { Name = "Tahin", CaloryPerUnit = 6.4, CategoryId = 1, UnitId = UnitType.gr },
                //Category name => Süt ve Süt Ürünleri
                new Food() { Name = "Beyaz Peynir", CaloryPerUnit = 2.7, CategoryId = 2, UnitId = UnitType.gr },
                new Food() { Name = "Kaşar Peyniri", CaloryPerUnit = 3.5, CategoryId = 2, UnitId = UnitType.gr },
                new Food() { Name = "Süt", CaloryPerUnit = 500, CategoryId = 2, UnitId = UnitType.lt },
                new Food() { Name = "Yoğurt", CaloryPerUnit = 0.73, CategoryId = 2, UnitId = UnitType.gr },
                //Category name => Meyve ve Sebze
                new Food() { Name = "Domates", CaloryPerUnit = 23, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Salatalık", CaloryPerUnit = 14, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Carliston Biber", CaloryPerUnit = 20, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Köy Biberi", CaloryPerUnit = 30, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Kapya Biberi", CaloryPerUnit = 25, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Kırmızı Elma", CaloryPerUnit = 45, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Yeşil Elma", CaloryPerUnit = 50, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Portakal", CaloryPerUnit = 47, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Mandalina", CaloryPerUnit = 40, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Kiraz", CaloryPerUnit = 1.4, CategoryId = 3, UnitId = UnitType.Adet },
                new Food() { Name = "Karpuz", CaloryPerUnit = 45, CategoryId = 3, UnitId = UnitType.Porsiyon },

                //Category name => Ev Yemekleri
                new Food() { Name = "Tarhana Çorbası", CaloryPerUnit = 150, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Mercimek Çorbası", CaloryPerUnit = 140, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Ezogelin Çorbası", CaloryPerUnit = 95, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Tavuk Çorbası", CaloryPerUnit = 132, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Pirinç Pilavı", CaloryPerUnit = 200, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Bulgur Pilavı", CaloryPerUnit = 240, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Kuru Fasülye", CaloryPerUnit = 265, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Nohut", CaloryPerUnit = 160, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Pırasa", CaloryPerUnit = 80, CategoryId = 4, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Brokoli", CaloryPerUnit = 40, CategoryId = 4, UnitId = UnitType.Porsiyon },

                //Category name => Et Yemekleri
                new Food() { Name = "Cağ Kebap", CaloryPerUnit = 250, CategoryId = 5, UnitId = UnitType.Adet },
                new Food() { Name = "Adana Kebap", CaloryPerUnit = 400, CategoryId = 5, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Urfa Kebap", CaloryPerUnit = 380, CategoryId = 5, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Şiş Köfte", CaloryPerUnit = 500, CategoryId = 5, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Antrikot", CaloryPerUnit = 280, CategoryId = 5, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Biftek", CaloryPerUnit = 300, CategoryId = 5, UnitId = UnitType.Porsiyon },
                new Food() { Name = "Pirzola", CaloryPerUnit = 450, CategoryId = 5, UnitId = UnitType.Porsiyon },

                //Category name => Fast Food
                new Food() { Name = "Hamburger", CaloryPerUnit = 450, CategoryId = 4, UnitId = UnitType.Porsiyon },
                );
        }
    }
}
