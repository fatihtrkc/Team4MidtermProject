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
        public Unit()
        {
            AddedFoods = new List<AddedFood>();
        }
        public int UnitId { get; set; }
        public UnitType UnitType { get; set; }
        public ICollection<AddedFood> AddedFoods { get; set; }
    }
}
