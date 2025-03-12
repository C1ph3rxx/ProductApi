using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories
{
    public interface ICategory
    {
        /// <summary>
        /// Gets a Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Category? Get(int id);

        /// <summary>
        /// Returns all the Categories
        /// </summary>
        /// <returns></returns>
        List<Category> Get();

        /// <summary>
        /// Deletes a category
        /// </summary>
        /// <param name="category"></param>
        void Delete(Category category);

        /// <summary>
        /// Creates a Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Category Create(Category category);

        /// <summary>
        /// Updates a Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>

        Category? Update(Category category);
    }
}
