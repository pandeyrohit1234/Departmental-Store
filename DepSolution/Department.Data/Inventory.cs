using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Inventory
    {

        public long InventoryId { get; set; }
        public int InventoryQuantity { get; set; }
        public bool InStock { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
