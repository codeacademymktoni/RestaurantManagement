using System.Collections.Generic;

namespace RestorantManagement.ViewModels
{
    public class AddToTableViewModel
    {
        public int TableId { get; set; }
        public List<AddToTableProductViewModel> Products { get; set; }
    }
}
