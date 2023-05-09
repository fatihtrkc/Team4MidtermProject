using EntityLayer.Entities;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Entities
{
    public class AddedFood
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double TotalCalory { get; set; }
        public double TargetCaloryPerDay { get; set; }
        public DateTime CreationDate { get; set; }

        //Relations
        public int UserId { get; set; }
        public User User { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        [ForeignKey("Meal")]
        public MealType MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
