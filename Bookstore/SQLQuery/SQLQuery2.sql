USE master;  
GO  

IF EXISTS(SELECT * from sys.databases WHERE name='BookStore')  
BEGIN  
    DROP DATABASE BookStore;  
END  

CREATE DATABASE BookStore;  

USE BookStore 
GO

CREATE TABLE Book_T(
    BookID INTEGER IDENTITY(1, 1) PRIMARY KEY,
    Title NVARCHAR(30) NOT NULL,    
	Author NVARCHAR(40) NOT NULL,    
	ISBN NVARCHAR(20) NOT NULL,
	Price NVARCHAR(20) NOT NULL
);

CREATE TABLE Customer_T(    
    CustomerID INTEGER IDENTITY(1, 1) PRIMARY KEY,
    FirstName NVARCHAR(20) NOT NULL,    
	LastName NVARCHAR(40) NOT NULL,    
	Addresss NVARCHAR(60) NOT NULL,
	City NVARCHAR(20) NOT NULL,
	States NVARCHAR(20) NOT NULL,    
	Zip NVARCHAR(10) NOT NULL,
	Phone NVARCHAR(20) NOT NULL,
	Email NVARCHAR(30) NOT NULL
);

CREATE TABLE Order_T(    
    OrderID INTEGER IDENTITY(1, 1) PRIMARY KEY,    
    CustomerID INTEGER,   
	Subtotal NVARCHAR(20) NOT NULL,
	Tax NVARCHAR(20) NOT NULL,
	Total NVARCHAR(20) NOT NULL,    
	OrderDate NVARCHAR(20) NOT NULL
);

CREATE TABLE OrderDetail_T(    
    OrderID INTEGER,    
	BookID INTEGER IDENTITY(1, 1),    
	Quantity NVARCHAR(20),
	LinesTotal NVARCHAR(20) NOT NULL
);

INSERT INTO Book_T
VALUES ('The Grass is Always Greener', 'Jeffrey Archer', '1-86092-049-7', '109');

INSERT INTO Book_T
VALUES ('Happiness!', 'JArnold Bennett', '1-86092-012-8', '119');

INSERT INTO Book_T
VALUES ('A Boy at Seven', 'John Bidwell', '1-86092-022-5', '1099');

INSERT INTO Book_T
VALUES ('The Higgler', 'A. E. Coppard', '1-86092-010-1', '89');

INSERT INTO Book_T
VALUES ('The Open Boat', 'Stephen Crane', '1-86092-025-x', '59');

INSERT INTO Book_T
VALUES ('The Great Switcheroo', 'Roald Dahl', '1-86092-034-9', '199');

INSERT INTO Book_T
VALUES ('The Speckled Band', 'Sir Arthur Conan Doyle', '1-86092-003-9', '236');

ALTER TABLE Order_T
ALTER COLUMN OrderDate DateTime NOT NULL

