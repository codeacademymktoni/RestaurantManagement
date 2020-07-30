using RestorantManagement.Models;
using System.Collections.Generic;

namespace RestorantManagement.Services.Interfaces
{
    public interface IProductsService
    {
        List<Product> GetAll();
    }
}
