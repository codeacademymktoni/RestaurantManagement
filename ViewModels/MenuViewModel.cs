using System.Collections.Generic;

namespace RestorantManagement.ViewModels
{
    public class MenuViewModel
    {
        public List<ProductViewModel> Products{ get; set; }
        public int TableId { get; set; }
    }
}
