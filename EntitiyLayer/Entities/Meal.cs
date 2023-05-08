﻿using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Meal
    {
        public Meal()
        {
            AddedFoods = new List<AddedFood>();
        }
        public int MealId { get; set; }
        public MealType MealType { get; set;}

        public ICollection<AddedFood> AddedFoods { get; set; }
    }
}
