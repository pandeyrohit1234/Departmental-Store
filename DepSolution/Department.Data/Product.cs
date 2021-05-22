using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ManuFacturer { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<ProductSupplier> ProductSuppliers { get; set; }
    }
}
