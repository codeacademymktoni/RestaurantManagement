using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        [Required]

        public int TableId { get; set; }
        public Table Table { get; set; }
        public List<ProductReceipt> ProductReceipts { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime? DateClosed { get; set; }

    }
}
