using AutoMapper;
using DepartmentalStore.Data.Model;
using DepartmentalStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDepartmentalStore.Data
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            this.CreateMap<Product, ProductModel>();
            this.CreateMap<Staff, StaffModel>();
            this.CreateMap<Address, AddressModel>();
            this.CreateMap<Role, RoleModel>();
        }
    }
}
