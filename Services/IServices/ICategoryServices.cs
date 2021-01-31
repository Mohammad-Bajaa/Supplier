using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supplier.Models;
namespace Supplier.Services.IServices
{
   public interface ICategoryServices
    {
        Task<Category> Add(Category entity);
        IList<Category> List();
        Category Find(int id);
        

        void Update(Category entity);
        void Delete(int id);
        List<Category> Search(string term);
    }
}
