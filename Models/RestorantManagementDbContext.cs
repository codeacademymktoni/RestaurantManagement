using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RestorantManagement.Models
{
    public class RestorantManagementDbContext : IdentityDbContext<ApplicationUser>
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
