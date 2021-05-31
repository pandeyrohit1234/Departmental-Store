using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Data.Model
{
   public  class AddressModel
    {
        public string AddressLine1 { get; set; }
        public long Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
