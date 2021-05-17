 

--insert data in product table
INSERT INTO Product(ProductName ,
				ProductCode ,
				BrandName ,
				CostPrice,
				SellingPrice ) 
    VALUES ('Butter','btr','Amul',256.2 , 238.00),
	       ('Pencil','Pen','Natraj',20.53 , 33.00),
	       ('Pen','Pn','Cello',50.00 , 60.02),
		   ('Butter','bitr','Amul',256.2 , 238.00),
	       ('Pencil','Penc','Natraj',20.53 , 33.00),
	       ('Pen','Pnc','Cello',50.00 , 60.02);


 



INSERT INTO Category ( CategoryName,CategoryCode ) 
VALUES ('Dairy','mil'),
       ('Transport','Tra'),
	   ('Stationary','stat'),
	    ('Dairy','Dai'),
       ('Transport','Tra'),
	   ('Stationary','stat');
	   

 


 


--insert data in category product junction table
INSERT INTO productcategory(ProdId ,CategoryId )
VALUES(1,1),(1,2),(2,1),(2,2);

 


--insert data in inventory table
INSERT INTO Inventory (ProdId ,CategoryId ,ProductQuantity ,Stock  ) 
VALUES(1,1,3,'T'),(1,1,2,'F'),(3,3,4,'T');

 


--insert data in supplier table
INSERT INTO Supplier (SupplierId ,
					  SupplierName ,
					  SupplierPhone_no,
					  SupplierEmail,
					  SupplierCity ,
					  SupplierState,
					  SupplyDate ) 
VALUES (1,'Rohit',9670123,'Rohit@gmail.com','Noida','up','2021-09-10'),
        (2,'Yash',9670433,'yash@gmail.com','delhi','up','2020-10-12');
        
        
--insert data in supplier-product table
INSERT INTO SupplierProduct(ProdId,SupplierId)
VALUES (1,2),(2,1),(3,1),(1,2);

 


--insert data in purchase-order table
INSERT INTO PurchaseOrder (OrderId, 
							SupplierId,
							ProdId,
							OrderedProductName,
							PurchaseDate ,
							PurchaseQty  )
VALUES (1,2,1,'Book','2021-10-12',12)
,(2,1,2,'Cheese','2021-10-02',30);

 


--insert data in department (for staff) table
INSERT INTO Department ( DepName ) 
           VALUES ('AccountManagement'),
                  ('InventoryManagement'),
				   ('OrderManagement');

 


--insert data in staff table
INSERT INTO Employee(EmployeeName,
					 EmployeePhoneNo,
					 DepId)
             VALUES('Peter',734672,1),
			 ('Staphen',873432,2),
			 ('Paul',635458,3)

 
 



 

--Employee Using Name and PhoneNumber Query-1    
SELECT * from Employee
WHERE EmployeePhoneNo = '734672';
    
SELECT * from Employee
WHERE EmployeName = 'Peter';

 


--Employee Using Role Query     
SELECT * from Employee
WHERE DepId IN
(SELECT DepId from Department
WHERE DepName = 'AccountManagement' );

 


--Query On Product
--A.

SELECT * from Product
WHERE ProdName='Milk';

--B.
 
SELECT * from product
WHERE selling_price>2;

--C. 

SELECT * from Product
WHERE CostPrice<900;

--D 

SELECT * from Product
WHERE ProdId IN
(SELECT ProdId from Inventory
WHERE Stock='T');

 

SELECT * from Product
WHERE ProductId IN
(SELECT ProdId from Inventory
WHERE Stock='F');

 


SELECT p.ProdName,c.CategoryName
from product p
INNER JOIN ProductCategory pc ON p.ProdId = pc.ProdId
INNER JOIN category c ON c.CategoryId = pc.CategoryId;

 


--Product Out of Stock Query
SELECT COUNT(STOCK='F')
FROM Inventory;

 


--Product within A category 
SELECT p.ProdId, p.ProdName,p.CostPrice,c.CategoryName
from Product p
INNER JOIN ProductCategory pc ON p.prodId = pc.ProdId
INNER JOIN Category c ON c.CategoryId = pc.CategoryId
WHERE c.CategoryName = 'Butter';

 


--Product categories Query
SELECT c.CategoryId,c.CategoryName,count(i.ProducTQuantity) AS TOTAL
from category c
INNER JOIN Inventory i
ON c.CategoryId = i.CategoryId
ORDER BY TOTAL DESC;

 


--List of Suppliers
SELECT * from Supplier
WHERE SupplierName = 'Yash';

 
--A
SELECT * from Supplier
WHERE SupplierPhoneNo = '9670123';

--B 

SELECT * from Supplier
WHERE SupplierEmail = 'yash@gmail.com';

--C 

SELECT * from Supplier
WHERE SupplierCity = 'noida';

 
--D
SELECT * from supplier
WHERE SupplierState = 'up';

 

 

--list of product with different criteria
SELECT pc.OrderId,p.ProdName,p.Prodcode,s.SupplierName,s.SupplyDate
from PurchaseOrder pc
INNER JOIN Product p ON pc.ProdId = p.ProdId
INNER JOIN supplier s ON s.SupplierId = pc.SupplierId
WHERE p.ProdName='Milk';

 
--A

SELECT pc.OrderId,p.ProdName,p.Prodcode,s.SupplierName,s.SupplyDate
from PurchaseOrder pc
INNER JOIN Product p ON pc.ProdId = p.ProdId
INNER JOIN inventory i ON i.ProdId = p.ProdId
INNER JOIN supplier s ON s.SupplierId = pc.SupplierId
WHERE i.ProductQuantity > 1;

 
--B

SELECT pc.OrderId,p.ProdName,p.Prodcode,s.SupplierName,s.SupplyDate
from PurchaseOrder pc
INNER JOIN Product p ON pc.ProdId = p.ProdId
INNER JOIN supplier s on s.SupplierId = pc.SupplierId
WHERE s.SupplierName='Rohit';

 
--C

SELECT pc.OrderId,p.ProdName,p.Prodcode,s.SupplierName,s.SupplyDate
from PurchaseOrder pc
INNER JOIN Product p ON pc.ProdId = p.ProdId
INNER JOIN supplier s ON s.SupplierId = pc.SupplierId
WHERE p.ProdCode='mil';

 

--D

SELECT pc.OrderId,p.ProdName,p.Prodcode,s.SupplierName,s.SupplyDate
from PurchaseOrder pc
INNER JOIN Product p ON pc.ProdId = p.ProdId
INNER JOIN supplier s ON s.SupplierId = pc.SupplierId
WHERE s.SupplyDate>'2021-10-02';

 
--E

SELECT pc.OrderId,p.ProdName,p.Prodcode,s.SupplierName,s.SupplyDate
from PurchaseOrder pc
INNER JOIN Product p ON pc.ProdId = p.ProdId
INNER JOIN supplier s on s.SupplierId = pc.SupplierId
WHERE s.SupplyDate<'2021-10-12';