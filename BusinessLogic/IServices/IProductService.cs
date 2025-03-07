using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices
{
    public interface IProductService
    {
        /// <summary>
        /// Gets a Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product GetProduct(int id);

        /// <summary>
        /// Gets all the Products
        /// </summary>
        /// <returns></returns>
        List<Product> GetAllProduct();

        /// <summary>
        /// Deletes Product
        /// </summary>
        /// <param name="product"></param>
        void DeleteProduct(Product product);

        /// <summary>
        /// Creates Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product CreateProduct(Product product);

        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product? UpdateProduct(Product product);
    }
}
