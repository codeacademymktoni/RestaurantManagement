using RestorantManagement.Models;
using RestorantManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly RestorantManagementDbContext context;

        public ProductRepository(RestorantManagementDbContext context)
        {
            this.context = context;
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public void Update(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void Update(List<Product> products)
        {
            context.Products.UpdateRange(products);
            context.SaveChanges();
        }
    }
}
