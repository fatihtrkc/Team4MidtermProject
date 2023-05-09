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
    public class MealCfg : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData
                (
                new Meal() { Name = MealType.Breakfast },
                new Meal() { Name = MealType.Lunch },
                new Meal() { Name = MealType.Snack },
                new Meal() { Name = MealType.Dinner }
                );
        }
    }
}
