using ProductContext;
using ProductTable;
using System;
using ProductTable;
using System.Linq;
using System.Collections.Generic;
using OperationOnDatabase;

namespace ProductCatalog
{
     class Program
    {

        public static DepartmentalContext context = new DepartmentalContext();



        static void Main(string[] args)
        {





            Console.WriteLine("You Can Perform Below Query Operation");
            Console.WriteLine("1.Staff Query");
            Console.WriteLine("");
            Console.WriteLine("3.Product Query");
            Console.WriteLine("4.");
            Console.WriteLine("5.");
            Console.WriteLine("6");
            Console.WriteLine("7.");
            Console.WriteLine("8.");
            //Console.ReadLine();
          //  while()
            //Operation.StaffQuery();
            //Operation.ProductQuery();
            Operation.SupplierQuery();
            //Console.WriteLine("helloe");
            // string name = "Bill";





            //AddRole();
            //AddAddress();
            //AddStaff();
            //AddProduct();
            //AddInventory();
            //AddSupplier();
            //AddCategory();
            //AddProductCategory();

        }
        private static void AddRole()
        {
            //var role = new Role { RoleName = "Accountant", Description = "Manages Biling" };
            //var role1 = new Role { RoleName = "Product Keeper", Description = "Manages the products" };
            //var role2 = new Role { RoleName = "Product Keeper", Description = "Manages the products" };
            //context.Add(role1);
            //context.Add(role2);
            //context.SaveChanges();

        }
            private  static void AddAddress()
            {
                var Address1 = new Address { AddressLine1 = "23/343", AddressLine2 = "Avas Vikas", City = "Ballia", State = "Uttar Pradesh", Pincode = 277201};
                var Address2 = new Address { AddressLine1 = "Darhara", AddressLine2 = "Sukhpura Rode", City = "Ghaziabad", State = "Uttar Pradesh", Pincode = 2001003 };
                var Address3 = new Address { AddressLine1 = "Fortis Hospital", AddressLine2 = "Noida", City = "Noida", State = "Uttar Pradesh", Pincode = 277301 };
                var Address4 = new Address { AddressLine1 = "1B", AddressLine2 = "Govind Palace", City = "Agra", State = "Uttar Pradesh", Pincode = 283202 };
                context.Add(Address1);
                context.Add(Address2);
                context.Add(Address3);
                context.Add(Address4);
                context.SaveChanges();
            }



        private static void AddStaff()
        {
            var Staff = new Staff { FirstName = "Abhishek", LastName = "Pandey", PhoneNumber = "9876545556", Gender = "M", Salary = 10000, AddressId = 1, RoleId = 1 };
            var Staff1 = new Staff { FirstName = "Deep", LastName = "Khurana", PhoneNumber = "9873330556", Gender = "M", Salary = 19000, AddressId = 2, RoleId = 1 };
            var Staff2 = new Staff { FirstName = "Ritik", LastName = "Pandey", PhoneNumber = "8343735343", Gender = "M", Salary = 20000, AddressId = 3, RoleId = 2 };
            var Staff3 = new Staff { FirstName = "Vikas", LastName = "Raj", PhoneNumber = "5343534534", Gender = "M", Salary = 20000, AddressId = 3, RoleId = 2 };
            var Staff4 = new Staff { FirstName = "Abhilasha", LastName = "Pachuari", PhoneNumber = "8782352355", Gender = "F", Salary = 34000, AddressId = 4, RoleId = 3 };
            var Staff5 = new Staff { FirstName = "Rani", LastName = "Singh", PhoneNumber = "9670156010", Gender = "F", Salary = 70000, AddressId = 1, RoleId = 3 };
            context.Add(Staff);
            context.Add(Staff1);
            context.Add(Staff2);
            context.Add(Staff3);
            context.Add(Staff4);
            context.Add(Staff5);
            context.SaveChanges();
        }



        public static void AddProduct()
        {
            var data1 = new Product { ProductName = "Bike", ProductCode = "bk", ManuFacturer = "Honda", CostPrice = 150000, SellingPrice = 128000 };
            var data2 = new Product { ProductName = "Bus", ProductCode = "bs", ManuFacturer = "Tata", CostPrice = 240000, SellingPrice = 260000 };
            var data3 = new Product { ProductName = "Butter", ProductCode = "but", ManuFacturer = "Amul", CostPrice = 230, SellingPrice = 620 };
            var data4 = new Product { ProductName = "Car", ProductCode = "car", ManuFacturer = "Audi", CostPrice = 600000, SellingPrice = 700000 };
            var data5 = new Product { ProductName = "Plane", ProductCode = "pln", ManuFacturer = "Kingfisher", CostPrice = 2323093, SellingPrice = 3232434 };
            var data6 = new Product { ProductName = "Milk", ProductCode = "mil", ManuFacturer = "Amul", CostPrice = 110, SellingPrice = 120 };



            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5); context.Add(data6);
            context.SaveChanges();
        }





        public static void AddInventory()
        {
            var data1 = new Inventory { InventoryQuantity = 23, InStock = true, ProductId = 1 };
            var data2 = new Inventory { InventoryQuantity = 12, InStock = true, ProductId = 3 };
            var data3 = new Inventory { InventoryQuantity = 1, InStock = true, ProductId = 2 };
            var data4 = new Inventory { InventoryQuantity = 0, InStock = false, ProductId = 4 };
            var data5 = new Inventory { InventoryQuantity = 10, InStock = true, ProductId = 5 };



            context.Add(data1); context.Add(data2); context.Add(data3); context.Add(data4); context.Add(data5);
            context.SaveChanges();
        }








        public static void AddSupplier()
        {
            var supplier1 = new Supplier { SupplierName = "Yash", SupplierPhoneNo = "9836345312", Email = "yash@gmail.com", City = "Ballia", State = "UttarPradesh", Gender = "M" };
            var supplier2 = new Supplier { SupplierName = "Prateek", SupplierPhoneNo = "9836454554", Email = "Prateek@gmail.com", City = "Raipur", State = "UttarPradesh", Gender = "M" };
            var supplier3 = new Supplier { SupplierName = "Harshit", SupplierPhoneNo = "7787878787", Email = "Harshit@gmail.com", City = "Noida", State = "UttarPradesh", Gender = "M" };
            var supplier4 = new Supplier { SupplierName = "Ram", SupplierPhoneNo = "9982230909", Email = "Ram@hgmail.com", City = "Delhi", State = "Delhi", Gender = "M" };
            context.AddRange(supplier1, supplier2, supplier3, supplier4);

            context.SaveChanges();
        }


        public static void AddCategory()
        {
            var data1 = new Category { CategoryName = "Automobile", CategoryCode = "Aut" };
            var data2 = new Category { CategoryName = "Grocery", CategoryCode = "gro" };
            var data3 = new Category { CategoryName = "Dairy", CategoryCode = "dai" };
            var data4 = new Category { CategoryName = "Two Wheeler", CategoryCode = "Tw" };
            



            context.Add(data1); 
            context.Add(data2);
            context.Add(data3);
            context.Add(data4); 
            context.SaveChanges();
        }
        public static void AddProductCategory()
        {
            // var productcategory = new ProductCategory { ProductId = 1, CategoryId = 2 };
            //var productcategory1 = new ProductCategory { ProductId = 2, CategoryId = 1 };
        
            var productcategory2 = new ProductCategory { ProductId = 3, CategoryId = 2 };
            context.Add(productcategory2);
            context.SaveChanges();
            //var productcategory3 = new ProductCategory { ProductId = 4, CategoryId = 3 };
            //var productcategory4 = new ProductCategory { ProductId = 2, CategoryId = 2 };
            //var productcategory5 = new ProductCategory { ProductId = 3, CategoryId = 3 };
            //var productcategory6 = new ProductCategory { ProductId = 3, CategoryId = 2 };
            //context.AddRange(productcategory, productcategory1, productcategory2, productcategory3, productcategory4, productcategory5, productcategory6);
            //context.SaveChanges();

        }






        //Console.WriteLine(role2.Description);
    }
}


