using BusinessLogicLayer.IServices;
using DataAccessLayer.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public Category? CreateCategory(Category category)
        {
            return _categoryRepository.Create(category);
        }

        public bool DeleteCategory(int id)
        {
            Category? category = _categoryRepository.Get(id);
            if(category == null)
            {
                return false;
            }
            _categoryRepository.Delete(category);
            return true;
        }

        public List<Category> GetAllCategory()
        {
            return _categoryRepository.Get();
        }

        public Category? GetCategory(int id)
        {
            return _categoryRepository.Get(id);
        }

        public Category? UpdateCategory(Category category)
        {
            Category? existingCategory = _categoryRepository.Get(category.Id);

            if(existingCategory == null )
            {
                return null;
            }


            return _categoryRepository.Update(category);
        }
    }
}
