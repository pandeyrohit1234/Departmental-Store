

 
--------------------------------------------------------------------create Employee table

 

CREATE TABLE Employee(

 

    EmployeeId SERIAL NOT NULL PRIMARY KEY,
    EmployeeName VARCHAR(50) NOT NULL,
    EmployeePhoneNo INT,
    DepId INT REFERENCES Department(DepId) NOT NULL
);

 

---------------------------------------------------------------------create Employee department table

 

CREATE TABLE Department(
    
    DepId SERIAL NOT NULL PRIMARY KEY,
    DepName VARCHAR(50) NOT NULL
);

 


---------------------------------------------------------------------------create product table

 

CREATE TABLE Product(
 
    ProdId SERIAL NOT NULL PRIMARY KEY,
    ProdName VARCHAR(50) NOT NULL,
    ProdCode VARCHAR(50) NOT NULL UNIQUE,
    BrandName VARCHAR(50) NOT NULL,
    CostPrice NUMERIC(20,2) NOT NULL,
    SellingPrice NUMERIC(20,2) NOT NULL
);

 

-----------------------------------------------------------------------------create category table

 

CREATE TABLE Category(
    
    CategoryId SERIAL NOT NULL PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL,
    CategoryCode VARCHAR(50) NOT NULL UNIQUE
);

 

-------------------------------------------------------------create category-product junction table

 

CREATE TABLE ProductCategory(
    ProdId INT REFERENCES Product(ProdId) NOT NULL,
    CategoryId INT REFERENCES Category(CategoryId) NOT NULL
);

 

-------------------------------------------------------------------------create Inventory table

 

CREATE TABLE Inventory(
    
    InventoryId SERIAL NOT NULL PRIMARY KEY,
    ProdId INT REFERENCES product(ProdId) NOT NULL,
    CategoryId INT REFERENCES Category(CategoryId) NOT NULL,
    ProductQuantity INT ,
    Stock CHAR(1) NOT NULL
);

 

----------------------------------------------------------------create supplier table

 

CREATE TABLE Supplier(
    
    SupplierId SERIAL NOT NULL PRIMARY KEY,
    SupplierName VARCHAR(50) NOT NULL,
    SupplierPhone_no INT NOT NULL,
    SupplierEmail VARCHAR(50) NOT NULL,
    SupplierCity VARCHAR(30) NOT NULL,
    SupplierState VARCHAR(30) NOT NULL,
    SupplyDate DATE
);

 

--------------------------------------------------------------create supplierproduct junction table

 

CREATE TABLE supplierproduct(
    
    ProdId INT REFERENCES Product(ProdId) NOT NULL,
    SupplierId INT REFERENCES Supplier(SupplierId) NOT NULL
);

 

----------------------------------------------------------------create purchase_order table

 

CREATE TABLE PurchaseOrder(

 

    OrderId SERIAL NOT NULL PRIMARY KEY,
    SupplierId INT REFERENCES Supplier(SupplierId) NOT NULL,
    ProdId INT REFERENCES Product(ProdId) NOT NULL,
    OrderedProductName VARCHAR(50) NOT NULL,
    PurchaseDate DATE NOT NULL,
    PurchaseQty INT NOT NULL        
);
