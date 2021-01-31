﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supplier.Models
{
    public class CategorySpecification 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isValued { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<Specification> Specifications { get; set; }


    }
}
