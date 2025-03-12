using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ProductService : IProductService
    {
        IProduct _productRepository;

        public ProductService(IProduct productRepository)
        {
            _productRepository = productRepository;
        }
        public Product CreateProduct(Product product)
        {
            return _productRepository.Create(product);
        }

        public void DeleteProduct(Product product)
        {
            _productRepository.Delete(product);

        }

        public List<Product> GetAllProduct()
        {
            return _productRepository.Get();
        }

        public Product GetProduct(int id)
        {
            return _productRepository.Get(id);
        }

        public Product? UpdateProduct(Product product)
        {
            Product? existingProduct = _productRepository.Get(product.Id);
            if(existingProduct == null)
            {
                return null;

            }

            return _productRepository.Update(product); 
        }
    }
}
