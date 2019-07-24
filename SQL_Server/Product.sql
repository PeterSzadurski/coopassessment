Create schema ProductsDB
GO
Create table ProductsDB.Product (ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name varchar(255) NOT NULL,
	Price float NOT NULL,
	Description varchar(255) NOT NULL
);
INSERT INTO ProductsDB.Product (Name, Price, Description) 
VALUES ('Dog Shampoo', 10.57, 'shampoo for long hair dogs');
INSERT INTO ProductsDB.Product (Name, Price, Description) 
VALUES ('WD Red 4 TB', 150.99, 'NAS hard drive');
INSERT INTO ProductsDB.Product (Name, Price, Description) 
VALUES ('2018 Nissan Mourano', 37866.99, 'Nissan Mourano AWD with Tech Package?');
-- copy entire table
-- source: https://www.w3schools.com/sql/sql_select_into.asp
SELECT *
INTO ProductsDB.Product_Copy 
FROM ProductsDB.productsAgain;
DELETE FROM ProductsDB.Product_Copy 
WHERE ID = 2;