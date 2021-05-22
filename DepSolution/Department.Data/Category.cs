using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
