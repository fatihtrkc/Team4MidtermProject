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
            builder.Property(b => b.Email).HasMaxLength(50);
            builder.HasIndex(b => b.Email).IsUnique();
            builder.Property(b => b.Name).HasMaxLength(20);
            builder.Property(b => b.Surname).HasMaxLength(20);
            builder.Property(b => b.SpecificQuestion).HasMaxLength(100);
            builder.Property(b => b.QuestionAnswer).HasMaxLength(20);
            builder.Property(b => b.ActivePassiveSituation).HasDefaultValue(true);
            builder.Property(b => b.CreationDate).HasDefaultValue(DateTime.Now);

            builder.HasData
                (
                    new User() { Name = "Ahmet", Surname = "Yılmaz", Email = "ahmetyilmaz@yilmaz.com", Password = "AaBb12.,", Gender = Gender.Male, BirthDate = Convert.ToDateTime(2000 / 01 / 01), Height = 1.82, Weight = 103, BodyMassIndex = 31.1, SpecificQuestion = "En Sevdiğin Programlama Dili?", QuestionAnswer = "C#", LifeStyleId = LifeStyleType.Low },
                    new User() { Name = "Ayşe", Surname = "Sevgi", Email = "ayşesevgi@sevgi.com", Password = "AaBb12.,", Gender = Gender.Female, BirthDate = Convert.ToDateTime(1990 / 01 / 01), Height = 1.55, Weight = 55, BodyMassIndex = 21.3, SpecificQuestion = "En Sevdiğin Programlama Dili?", QuestionAnswer = "Java", LifeStyleId = LifeStyleType.Middle }
                );
        }
    }
}
