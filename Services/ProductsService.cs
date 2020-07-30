using RestorantManagement.Models;
using RestorantManagement.Repositories.Interfaces;
using RestorantManagement.Services.Interfaces;
using System.Collections.Generic;

namespace RestorantManagement.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository productRepository;

        public ProductsService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }
    }
}
