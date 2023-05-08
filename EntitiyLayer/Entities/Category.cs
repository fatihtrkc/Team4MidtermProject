﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        public Category()
        {
            AddedFoods = new List<AddedFood>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<AddedFood> AddedFoods { get; set; }

    }
}
