using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Role
    {

        public long RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
