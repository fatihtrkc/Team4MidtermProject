using EntitiyLayer.Entities;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CaloryPerUnit { get; set; }

        public string? Image { get; set; }
        //Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Unit")]
        public UnitType UnitId { get; set; }
        public Unit Unit { get; set; }
        public ICollection<AddedFood> AddedFoods { get; set; }

       
    }
}
