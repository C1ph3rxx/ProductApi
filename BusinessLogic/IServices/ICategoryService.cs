using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices
{
    public interface ICategoryService
    {

        /// <summary>
        /// Gets a Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Category? GetCategory(int id);

        /// <summary>
        /// Returns all the Categories
        /// </summary>
        /// <returns></returns>
        List<Category> GetAllCategory();

        /// <summary>
        /// Deletes a category
        /// </summary>
        /// <param name="category"></param>
        bool DeleteCategory(int id);

        /// <summary>
        /// Updates a Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Category? UpdateCategory(Category category);

        /// <summary>
        /// Creates a Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Category? CreateCategory(Category category);
    }
}

