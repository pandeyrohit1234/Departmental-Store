using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class ProductCategory
    {

        public long ProductId { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public Product Product { get; set; }

    }
}
