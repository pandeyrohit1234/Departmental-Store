using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Supplier
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }

        public string SupplierPhoneNo { get; set; }
        public string Email { get; set; }

        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }


        public List<ProductSupplier> ProductSuppliers { get; set; }

    }
}
