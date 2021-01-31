using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Supplier.Models
{
    public class Category
    {
        public int Id { get; set;  }
        public string Description { get; set; }
        public string Name { get; set; }
        public List<CategoryProduct> Products { get; set; }
        public List<CategorySpecification> CategorySpecifications { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public List<Image> images { get; set; }



    }
}
