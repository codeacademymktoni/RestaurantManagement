using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.ViewModels
{
    public class TableDetailsViewModel
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public List<ProductReceiptViewModel> Products { get; set; }

    }
}
