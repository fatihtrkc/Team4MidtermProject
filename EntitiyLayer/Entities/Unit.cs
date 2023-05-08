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
    public class Unit
    {
        [Key]
        public UnitType Name { get; set; }
        public string Description { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
