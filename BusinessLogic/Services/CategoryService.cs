using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Repositories;
using Domain.DTO;
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
        ICategory _categoryRepository;

        public CategoryService(ICategory categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category? CreateCategory(CreateRequestCategoryDto category, out string message)
        {
            Category newCategory = _categoryRepository.Create(category);
            if (newCategory is null )
            {
                message = "Error creating category";
                return null;
            }
            message = "Category created successfully";
            return newCategory;
        }

        public bool DeleteCategory(int id)
        {
            Category? category = _categoryRepository.Get(id);
            if(category is  null)
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

    
        public Category? UpdateCategory(Category category , out string message)
        {

            if (string.IsNullOrWhiteSpace(category.Name))
            {
                message = "invalid category name";
            }

            if ( String.IsNullOrWhiteSpace(category.Description))
            {
                message = "invalid category description";
            }

            Category? existingCategory = _categoryRepository.Get(category.Id);
            
            if(existingCategory is null )
            {
                message = "Category not found";
                return null;
            }

            message = "Category updated";
            return _categoryRepository.Update(category);
        }

        Category? ICategoryService.CreateCategory(Category category , out string message    )
        {
            throw new NotImplementedException();
        }

        Category? ICategoryService.GetCategory(int id, out string message)
        {
            if (id < 0)
            {
                message = "Category ID invalid";
            }

            Category? category = _categoryRepository.Get(id);
            if(category is null )
            {
                message = "Invalid Category Id";
                
            }
            message = "Get Category works";
            return category;
        }

        Category? ICategoryService.UpdateCategory(Category category, out string message )
        {
            throw new NotImplementedException();
        }
    }
}
