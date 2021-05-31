using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Data.Model
{
    public class ProductModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ManuFacturer { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string CategoryName { get; set; }
    }
}
