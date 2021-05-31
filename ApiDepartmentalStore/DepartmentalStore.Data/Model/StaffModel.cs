using DepartmentalStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Data.Model
{
    public class StaffModel
    {
        public long StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }

        public AddressModel Address { get; set; }

        public RoleModel Role { get; set; }


    }
}
