using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Models
{
    public class Table
    {
        public int Id { get; set; }
        [Required]
        public string TableName { get; set; }
        [Required]
        public bool IsTaken { get; set; }
        public List<Receipt> Receipts { get; set; }

    }
}
