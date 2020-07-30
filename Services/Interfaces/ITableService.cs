using RestorantManagement.Models;
using RestorantManagement.ViewModels;
using System.Collections.Generic;

namespace RestorantManagement.Services.Interfaces
{
    public interface ITableService
    {
        List<Table> GetAll();
        void TakeTable(int tableId);
        Table GetById(int tableId);
        void Close(int tableId);
        void AddProductsToTable(int tableId, List<AddToTableProductViewModel> products);
    }
}
