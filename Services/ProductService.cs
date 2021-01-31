using Microsoft.AspNetCore.Mvc;
using Supplier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supplier.Services.IServices
{
    public class ProductService
    {
        private readonly SupplierDbContext _context;

        public ProductService(SupplierDbContext context)
        {
            _context = context;
        }
        public void Add(Product product1)
        {
            _context.Products.Add(product1);
            _context.SaveChanges();
        }
    }
}
