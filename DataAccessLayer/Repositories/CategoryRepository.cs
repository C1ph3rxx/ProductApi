using DataAccessLayer.Data;
using DataAccessLayer.IRepositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategory

    {
         ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Category Create(Category category)
        {
             _applicationDbContext.Categories.Add(category);
            _applicationDbContext.SaveChanges();
            return category;
        }

        public void Delete(Category category)
        {
             _applicationDbContext.Categories.Remove(category);
        }

        public Category? Get(int id)
        {
            return _applicationDbContext.Categories.Find(id);
        }

        public List<Category> Get()
        {
            return _applicationDbContext.Categories.ToList();
        }

        public Category Update(Category category)
        {
            _applicationDbContext.Categories.Update(category);
            _applicationDbContext.SaveChanges();
            return category;
        }
    }
}
