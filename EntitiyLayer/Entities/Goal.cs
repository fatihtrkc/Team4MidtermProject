using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Entities
{
    public class Goal
    {
        [Key]
        public GoalType GoalType { get; set; }
        public string Description { get; set; }
    }
}
