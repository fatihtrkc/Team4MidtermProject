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
    public class UserCfg : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(b => b.Email).IsUnique();
            builder.Property(b => b.Email).HasMaxLength(50);
            builder.Property(b => b.Name).HasMaxLength(20);
            builder.Property(b => b.Surname).HasMaxLength(20);
            builder.Property(b => b.SpecificQuestion).HasMaxLength(100);
            builder.Property(b => b.QuestionAnswer).HasMaxLength(20);

            builder.HasData
                (
                    new User() { Id = 1, Name = "Ahmet", Surname = "Yılmaz", Email = "ahmetyilmaz@yilmaz.com", Password = "AaBb12.,", Gender = Gender.Male, BirthDate = Convert.ToDateTime(2000 / 01 / 01), Height = 1.82, Weight = 103, SpecificQuestion = "En Sevdiğin Programlama Dili?", QuestionAnswer = "C#", LifeStyleId = LifeStyleType.Low, ActivePassiveSituation = true, CreationDate = DateTime.Now },
                    new User() { Id = 2, Name = "Ayşe", Surname = "Sevgi", Email = "ayşesevgi@sevgi.com", Password = "AaBb12.,", Gender = Gender.Female, BirthDate = Convert.ToDateTime(1990 / 01 / 01), Height = 1.55, Weight = 55, SpecificQuestion = "En Sevdiğin Programlama Dili?", QuestionAnswer = "Java", LifeStyleId = LifeStyleType.Middle, ActivePassiveSituation = true, CreationDate = DateTime.Now }
                );
        }
    }
}
