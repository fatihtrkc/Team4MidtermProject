using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Entities
{
    public class User : PersonBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string SpecificQuestion { get; set; }
        public string QuestionAnswer { get; set; }
        public bool ActivePassiveSituation { get; set; }

        //Relations
        [ForeignKey("LifeStyle")]
        public LifeStyleType LifeStyleId { get; set; }
        public LifeStyle LifeStyle { get; set; }

        [ForeignKey("Goal")]
        public GoalType GoalTypeId { get; set; }
        public Goal Goal { get; set; }
        public ICollection<AddedFood> AddedFoods { get; set; }
    }
}
