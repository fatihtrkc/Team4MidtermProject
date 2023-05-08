using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Food
    {
        public Food()
        {
            AddedFoods = new List<AddedFood>();
        }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public decimal CaloryPerUnit { get; set; }


        public int CategoryId { get; set; }
        public int UnitId { get; set; }




        public Category Category { get; set; } 
        public Unit Unit { get; set; }

        public ICollection<AddedFood> AddedFoods { get; set; }
    }
}
