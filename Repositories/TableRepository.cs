using Microsoft.EntityFrameworkCore;
using RestorantManagement.Models;
using RestorantManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Repositories
{
    public class TableRepository : ITableRepository
    {
        private readonly RestorantManagementDbContext context;

        public TableRepository(RestorantManagementDbContext context )
        {
            this.context = context;
        }

        public List<Table> GetAll()
        {
            return context.Tables.ToList();
        }

        public Table GetById(int tableId)
        {
            return context.Tables
                .Include(x => x.Receipts)
                    .ThenInclude(x => x.ProductReceipts)
                        .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.Id == tableId);
        }

        public void Update(Table table)
        {
            context.Tables.Update(table);
            context.SaveChanges();
        }
    }
}
