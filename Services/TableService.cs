using RestorantManagement.Models;
using RestorantManagement.Repositories.Interfaces;
using RestorantManagement.Services.Interfaces;
using RestorantManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Services
{
    public class TableService: ITableService
    {
        private readonly ITableRepository tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            this.tableRepository = tableRepository;
        }

        public void Close(int tableId)
        {
            var table = tableRepository.GetById(tableId);
            if (table != null)
            {
                table.IsTaken = false;
                tableRepository.Update(table);
            }
        }

        public List<Table> GetAll()
        {
            return tableRepository.GetAll();
        }

        public Table GetById(int tableId)
        {
            return tableRepository.GetById(tableId);
        }

        public void TakeTable(int tableId)
        {
            var table = tableRepository.GetById(tableId);
            if (table != null)
            {
                table.IsTaken = true;
                tableRepository.Update(table);
            }

        }
    }
}
