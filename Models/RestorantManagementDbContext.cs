using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Models
{
    public class RestorantManagementDbContext :DbContext
    {
        public RestorantManagementDbContext(DbContextOptions<RestorantManagementDbContext> options) :base(options)
        {

        }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ProductReceipt> ProductReceipts { get; set; }

    }
}
