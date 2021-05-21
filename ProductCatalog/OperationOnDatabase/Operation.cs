using Microsoft.EntityFrameworkCore;
using ProductContext;
using ProductTable;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OperationOnDatabase
{
    public class Operation
    {
        public static void StaffQuery()
        {
            //Query 1


            //A



            //Staffby Phonenumber or name
            var context = new DepartmentalContext();
            List<Staff> staffs = context.Staff.Where(s => s.PhoneNumber == "9670156010" || s.FirstName == "Abhishek").ToList();
            staffs.ForEach((i) =>
                {
                    //Console.WriteLine($"{i.FirstName},{i.LastName},{i.RoleId},{i.Salary}");
                });


            //B


            ////Staffby Name
            List<Staff> staff = context.Staff.Where(s => s.FirstName == "Abhishek").ToList();
            staff.ForEach((i) =>
            {
                //Console.WriteLine($"{i.FirstName},{i.LastName},{i.RoleId},{i.Salary}");
            });





            //Query2

            //Staff by their Role
            Console.WriteLine("Query2 : Query on Staff - using Role");
            var res = context.Staff.Join(context.Role,
                             e1 => e1.StaffId,
                             e3 => e3.RoleId,
                             (e1, e3) => new
                             {
                                 name = e1.FirstName,
                                 role = e3.RoleName
                             });
            Console.WriteLine("Name" + "\t\t" + "DepartmentName \n");
            foreach (var i in res)
            {
                Console.WriteLine($"{i.name} \t\t {i.role}");
            }





        }





        public static void ProductQuery()
        {

            //Query -3
            
            //Query by Name
            var context = new DepartmentalContext();
            List<Product> product = context.Product.Where(s => s.ProductName == "Bike").ToList();
            product.ForEach((i) =>
                {
                    Console.WriteLine($"{i.ProductId},{i.ProductName},{i.ProductSuppliers},{i.CostPrice},{i.ProductCode}");

                });


            //Query by 

            //List<Product> productop = context.Product.Where(s => s.ProductName == "Butter").ToList();
            //productop.ForEach((i) =>
            //{
            //    Console.WriteLine($"{i.ProductName},{i.ProductCode},{i.ProductSuppliers}");
            //});


            //var pro = context.Product.Include(s => s.ProductCategory).ThenInclude(s => s.Category)
            //   .Where(s => s.ProductCategory.Any(c => c.Category.CategoryName == "Shopping Goods")).ToList();
            //foreach (var i in pro)
            //{
            //    Console.WriteLine($"{i.ProductId} {i.ProductName} {i.ProductCode} {i.ProductCategory[0].Category.CategoryName}");
            //}
            //var productbycategory = from p in context.Product
            //                        join pc in context.ProductCategory on p.ProductId equals pc.ProductId
            //                        join cat in context.Category on pc.CategoryId equals cat.categoryId
            //                        select new { p.ProductName, cat.CategoryName };





            //foreach (var val in productbycategory)
            //{
            //    Console.WriteLine("Product Name: {0} \t Category Name: {1}", val.ProductName, val.CategoryName);
            //}







            //Console.WriteLine("Query3 b) : List of Products - Using Category ");
            //    var res = context.Product.Join(context.Category,e1 => e1.ProductId,e3 => e3.CategoryId,
            //       (e1, e3) => new {pname = e1.ProductName,cname = e3.CategoryName});
            //    Console.WriteLine("Name" + "\t\t" + "Category \n");
            //    foreach (var i in res)
            //    {
            //        Console.WriteLine($"{ i.pname} \t\t { i.cname}");
            //    }






        }















        //List<Staff> staffoperation = context.Staff.Where(s => s.FirstName == "Abhishek").ToList();
        //staffoperation.ForEach((i) =>
        //{
        //    Console.WriteLine($"{i.FirstName},{i.LastName},{i.RoleId},{i.Salary}");
        //});




        //var context = new DepartmentalContext();
        //var product = context.Product.ToList();
        //product.ForEach((i) =>
        //    {
        //        Console.WriteLine($"{i.ProductId},{i.ProductName},{i.ProductSuppliers},{i.CostPrice},{i.ProductCategories},{i.ProductCode}");
        //    });


        public static void SupplierQuery()
        {
            var context = new DepartmentalContext();
            var sup = context.Supplier.Where(s => s.SupplierName == "Yash").ToList();
            foreach (var i in sup)
            {
                Console.WriteLine($"{i.SupplierName} {i.SupplierPhoneNo} {i.Email}");
            }

            var s1 = context.Supplier.Where(s => s.SupplierPhoneNo == "9836454554").ToList();
            foreach (var i in s1)
            {
                Console.WriteLine($"{i.SupplierName} {i.SupplierPhoneNo} {i.Email}");
            }


            var s2 = context.Supplier.Where(s => s.Email == "yash@gmail.com").ToList();
            foreach (var i in s2)
            {
                Console.WriteLine($"{i.SupplierName} {i.SupplierPhoneNo} {i.Email}");
            }




           
            List<Supplier> staffs = context.Supplier.Where(s => s.SupplierPhoneNo == "9836454554" || s.SupplierName == "Yash").ToList();
            staffs.ForEach((i) =>
            {
                Console.WriteLine($"{i.SupplierName},{i.SupplierPhoneNo},{i.Email}");
            });
        }
    }
}
