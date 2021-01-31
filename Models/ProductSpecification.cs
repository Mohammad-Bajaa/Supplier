using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supplier.Models
{
    public class ProductSpecification 
    {
        public int Id { get; set; }

        public string name { get; set; }
        public string value { get; set; }
         
        public int ProductId { get; set; }
         
        public Product Product { set; get; }
    }
}
