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
                    new User() { Id = 1, Name = "AHMET", Surname = "YILMAZ", Email = "ahmetyilmaz@yilmaz.com", Password = "AaBb12.,", BirthDate = Convert.ToDateTime("2000.05.01"), Gender = Gender.Male, Height = 182, Weight = 113, GoalTypeId = GoalType.Zayıflamak, SpecificQuestion = "En Sevdiğin Programlama Dili?", QuestionAnswer = "C#", LifeStyleId = LifeStyleType.Low, },
                    new User() { Id = 2, Name = "AYŞE", Surname = "SEVGİ", Email = "ayşesevgi@sevgi.com", Password = "AaBb12.,", BirthDate = Convert.ToDateTime("1997.07.05"), Gender = Gender.Female, Height = 185, Weight = 55, GoalTypeId = GoalType.HızlıKiloAlmak, SpecificQuestion = "En Sevdiğin Programlama Dili?", QuestionAnswer = "JAVA", LifeStyleId = LifeStyleType.Middle }
                );
        }
    }
}
