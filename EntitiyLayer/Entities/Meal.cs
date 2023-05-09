using EntitiyLayer.Entities;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Meal
    {
        [Key]
        public MealType Name { get; set; }

        public ICollection<AddedFood> AddedFoods { get; set; }
    }
}
