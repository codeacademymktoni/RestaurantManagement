using RestorantManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Repositories.Interfaces
{
    public interface ITableRepository
    {
        List<Table> GetAll();
        Table GetById(int tableId);
        void Update(Table table);
    }
}
