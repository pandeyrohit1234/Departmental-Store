using System;
using System.Collections.Generic;
using System.Text;

namespace ProductTable
{
    public class PurchaseOrder
    {
        public long Id { get; set; }
        public long ProductId {get; set;}
       
        public int Quantity { get; set;}
        public long SupplierId { get; set; }
        public DateTime Date { get; set; }
        public Product product { get; set; }
        public Supplier Supplier { get; set; }
        
    }
}
