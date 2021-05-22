using Department.Data;
using DepartmentContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operations
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
                    Console.WriteLine($"{i.FirstName},{i.LastName},{i.RoleId},{i.Salary}");
                });


            //B


            ////Staffby Name
            List<Staff> staff = context.Staff.Where(s => s.FirstName == "Abhishek").ToList();
            staff.ForEach((i) =>
            {
                Console.WriteLine($"{i.FirstName},{i.LastName},{i.RoleId},{i.Salary}");
            });





            //Query2

            //Staff by their Role
            Console.WriteLine("Query2 : Query on Staff - using Role");
            var res = context.Staff.Join(context.Role, staff => staff.RoleId, role => role.RoleId, (staff, role) => new { fname = staff.FirstName, lname = staff.LastName, role = role.RoleName });
            Console.WriteLine("Name" + "\t\t" + "DepartmentName \n");
            foreach (var i in res)
            {
                Console.WriteLine($"{i.fname} \t\t {i.lname} \t\t {i.role}");
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
            ;








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




        public static void filterOnSellingPriceforProduct()
        {
            var context = new DepartmentalContext();
            Console.WriteLine("Greater Than");
            var data = context.Product.Where(x => x.SellingPrice > 190).ToList();
            foreach (var i in data)
            {
                Console.WriteLine(i.ProductId + " " + i.ProductName + " " + i.ManuFacturer + " " + i.ProductCode + " " + i.CostPrice + " " + i.SellingPrice);
            }
            Console.WriteLine("Less Than");
            var data1 = context.Product.Where(x => x.SellingPrice < 1965897).ToList();
            foreach (var j in data1)
            {
                Console.WriteLine(j.ProductId + " " + j.ProductName + " " + j.ManuFacturer + " " + j.ProductCode + " " + j.CostPrice + " " + j.SellingPrice);
            }

            Console.WriteLine("between");
            var data2 = context.Product.Where(x => x.SellingPrice > 9000 && x.SellingPrice < 20000).ToList();
            foreach (var j in data2)
            {
                Console.WriteLine(j.ProductId + " " + j.ProductName + " " + j.ManuFacturer + " " + j.ProductCode + " " + j.CostPrice + " " + j.SellingPrice);
            }
        }



        public static void NumberOfProductOutOfStock()
        {
            var context = new DepartmentalContext();

            var res = (from p in context.Product

                       join i in context.Inventory on p.ProductId equals i.ProductId

                       where i.InStock == false

                       select p).Count();

            Console.WriteLine("Number of Products That are Out of stock: " + res);

        }






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
        




        public static void NumberofProductswithinacategory()
        {
            var context = new DepartmentalContext();

            var result = (from p in context.Category join c in context.ProductCategory
                         
                          on p.CategoryId equals c.CategoryId
                          
                          group p by c.CategoryId into x
                          
                          select new
                          {
                              Count = x.Count<Category>(),
                              CategoryId = x.Key
                          }).ToList();


            foreach (var i in result)
            {
               
                Console.WriteLine("CategoryID : " + i.CategoryId + " " + "Count: " + i.Count);

            }
        }

        public static void filterProductBasedOnHighestToLowest()
        {
            var context = new DepartmentalContext();

            var res = (from p in context.Product
                                     
                                     join pc in context.ProductCategory on p.ProductId equals pc.ProductId
                                     
                                     join cat in context.Category on pc.CategoryId equals cat.CategoryId
                                    
                                     group p by pc.CategoryId into x
                                     
                                     orderby x.Count<Product>() descending
                                     
                                     select new
                                     {
                                         Count = x.Count<Product>(),Category_Id = x.Key

                                     }).ToList();

           
            foreach (var i in res)
            {
                Console.WriteLine("Category Id: {0} \t\t Count: {1}", i.Category_Id, i.Count);
            }
        }
    }
}
