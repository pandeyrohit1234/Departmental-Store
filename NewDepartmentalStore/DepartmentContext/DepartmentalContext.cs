using Microsoft.EntityFrameworkCore;

using ProductTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductContext
{
    public class DepartmentalContext : DbContext
    {

        public DbSet<Address> Address { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductSupplier> ProductSupplier { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;DataBase=ProductDepartment;Username=postgres;Password=1234");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder )
        {
            modelbuilder.Entity<Staff>().HasKey(r => r.StaffId);
            modelbuilder.Entity<Staff>().Property(r => r.FirstName).HasMaxLength(30).IsRequired(); ;
            modelbuilder.Entity<Staff>().Property(r => r.LastName).HasMaxLength(30);
            modelbuilder.Entity<Staff>().Property(r => r.Gender).HasMaxLength(1);
            modelbuilder.Entity<Staff>().Property(r => r.PhoneNumber).HasMaxLength(10);
            modelbuilder.Entity<Staff>().HasOne(f => f.Address).WithMany(a => a.Staff).HasForeignKey(x => x.AddressId);
            modelbuilder.Entity<Staff>().HasOne(f => f.Role).WithMany(a => a.Staff).HasForeignKey(x => x.RoleId);


            //configuring address
            modelbuilder.Entity<Address>().HasKey(r => r.AddressId);
            modelbuilder.Entity<Address>().Property(r => r.AddressLine1).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Address>().Property(r => r.AddressLine2).HasMaxLength(30);
            modelbuilder.Entity<Address>().Property(r => r.City).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Address>().Property(r => r.State).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Address>().Property(r => r.Pincode).HasMaxLength(6).IsRequired();

            //configuring Role
            modelbuilder.Entity<Role>().HasKey(r => r.RoleId);
            modelbuilder.Entity<Role>().Property(r => r.RoleName).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Role>().Property(r => r.Description).HasMaxLength(256).IsRequired();

            
            //configuring Product
            modelbuilder.Entity<Product>().HasKey(r => r.ProductId);
            modelbuilder.Entity<Product>().Property(r => r.ProductName).HasMaxLength(25).IsRequired();
            modelbuilder.Entity<Product>().Property(r => r.ProductCode).HasMaxLength(5);
            modelbuilder.Entity<Product>().Property(r => r.ManuFacturer).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Product>().Property(r => r.CostPrice).HasMaxLength(6).IsRequired();
            modelbuilder.Entity<Product>().Property(r => r.SellingPrice).HasMaxLength(6).IsRequired();




            //config Category
            modelbuilder.Entity<Category>().HasKey(r => r.CategoryId);
            modelbuilder.Entity<Category>().Property(r => r.CategoryName).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Category>().Property(r => r.CategoryCode).HasMaxLength(6).IsRequired();
            modelbuilder.Entity<ProductCategory>().HasKey(pc => new { pc.ProductId, pc.CategoryId });

            //config purchaseorder
            modelbuilder.Entity<PurchaseOrder>().HasKey(r => r.Id);      
            modelbuilder.Entity<PurchaseOrder>().Property(r => r.Quantity).HasMaxLength(30);
            modelbuilder.Entity<PurchaseOrder>().Property(r => r.Date).HasMaxLength(10);       
            modelbuilder.Entity<PurchaseOrder>().HasOne(f => f.Supplier).WithMany(a => a.PurchaseOrder).HasForeignKey(x => x.SupplierId);
            modelbuilder.Entity<PurchaseOrder>().HasOne(f => f.product).WithMany(a => a.PurchaseOrder).HasForeignKey(x => x.ProductId);




            //Config Supplier
            modelbuilder.Entity<Supplier>().HasKey(r => r.SupplierId);
            modelbuilder.Entity<Supplier>().Property(r => r.SupplierName).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Supplier>().Property(r => r.Gender).HasMaxLength(1).IsRequired();
            modelbuilder.Entity<Supplier>().Property(r => r.SupplierPhoneNo).HasMaxLength(10).IsRequired();
            modelbuilder.Entity<Supplier>().Property(r => r.Email).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Supplier>().Property(r => r.City).HasMaxLength(30).IsRequired();
            modelbuilder.Entity<Supplier>().Property(r => r.State).HasMaxLength(30).IsRequired();




            modelbuilder.Entity<ProductSupplier>().HasKey(pc => new { pc.ProductId, pc.SupplierId });






            //Config Inventory
            modelbuilder.Entity<Inventory>().HasKey(r => r.InventoryId);
            modelbuilder.Entity<Inventory>().Property(x => x.ProductId).HasMaxLength(128).IsRequired();
            modelbuilder.Entity<Inventory>().Property(x => x.InStock).HasMaxLength(20).IsRequired();
            modelbuilder.Entity<Inventory>().Property(x => x.InventoryQuantity).IsRequired();






            //Config PurchaseOrder




        }
    }
}
