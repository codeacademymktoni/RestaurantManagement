using RestorantManagement.Models;
using System.Collections.Generic;

namespace RestorantManagement.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Update(Product product);
        void Update(List<Product> updatedProducts);
    }
}
