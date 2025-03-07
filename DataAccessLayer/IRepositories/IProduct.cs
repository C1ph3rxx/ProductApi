using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories
{
    public interface IProduct
    {

        /// <summary>
        /// Gets a Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product Get(int id);

        /// <summary>
        /// Gets all the Products
        /// </summary>
        /// <returns></returns>
        List<Product> Get();

        /// <summary>
        /// Deletes Product
        /// </summary>
        /// <param name="product"></param>
        void Delete(Product product);

        /// <summary>
        /// Creates Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product Create(Product product);

        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product Update(Product product);
    }
}
