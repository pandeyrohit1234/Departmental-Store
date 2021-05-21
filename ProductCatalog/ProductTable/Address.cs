using System;
using System.Collections.Generic;
using System.Text;

namespace ProductTable
{
    public class Address
    {
        public long AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public long Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
