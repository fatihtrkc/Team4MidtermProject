using EntitiyLayer.Entities;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Unit
    {
        public int Id { get; set; }
        public UnitType Name { get; set; }
        public ICollection<AddedFood> AddedFoods { get; set; }
    }
}
