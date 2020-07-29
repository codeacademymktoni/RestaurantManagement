using RestorantManagement.Models;
using RestorantManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Services.Interfaces
{
    public interface ITableService
    {
        List<Table> GetAll();
        void TakeTable(int tableId);
        Table GetById(int tableId);
        void Close(int tableId);
    }
}
