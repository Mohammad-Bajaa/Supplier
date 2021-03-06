﻿using Supplier.Models;
using Supplier.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supplier.Services
{


    public class CategoryService : ICategoryServices
    {
        private readonly SupplierDbContext _context;

        public CategoryService(SupplierDbContext context)
        {
            _context = context;
        }

      public  Task<Category> Add(object entity)
        {
            _context.Categories.Add((Category)entity);
            _context.SaveChanges();
            return (Task<Category>)entity;
        }

        public Task<Category> Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public  Task<Category> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category id)
        {
            throw new NotImplementedException();
        }

        public object Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<object> List()
        {
            throw new NotImplementedException();
        }

        public List<object> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(object entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        void ICategoryServices.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Category ICategoryServices.Find(int id)
        {
            throw new NotImplementedException();
        }

        IList<Category> ICategoryServices.List()
        {
            throw new NotImplementedException();
        }

        List<Category> ICategoryServices.Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
