-- The Alpine Inventory database 
-- Pantskalashvili, Lana (823358842)
-- COMPE561 Assignment 4 (SQL)

-- USE statement
USE master
GO

IF EXISTS(SELECT * from sys.databases WHERE name='AlpineInventory ')  
BEGIN  
    DROP DATABASE AlpineInventory;  
END  

CREATE DATABASE AlpineInventory;  

USE AlpineInventory 
GO

-- Table drops
DROP TABLE IF EXISTS alp_orders
DROP TABLE IF EXISTS alp_item;
DROP TABLE IF EXISTS alp_backorder;
DROP TABLE IF EXISTS alp_customer;
DROP TABLE IF EXISTS alp_color;
DROP TABLE IF EXISTS alp_inventory;
DROP TABLE IF EXISTS alp_ordersource;
DROP TABLE IF EXISTS alp_shipping;
DROP TABLE IF EXISTS alp_orderline;


CREATE TABLE alp_orders
(
order_id INTEGER IDENTITY(1, 1) PRIMARY KEY,
order_date DATETIME NOT NULL,
payment VARCHAR(50) NOT NULL,
cust_id INT NOT NULL,
alp_ordersource VARCHAR(50) NOT NULL
);

CREATE TABLE alp_item
(
item_id INTEGER IDENTITY(1, 1) PRIMARY KEY,
descriptions VARCHAR(50) NOT NULL,
category VARCHAR(50) NOT NULL
);

CREATE TABLE alp_backorder
(
backorder_id INTEGER IDENTITY(1, 1) PRIMARY KEY,
ship_id INT NOT NULL,
inv_id INT NOT NULL,
date_exp DATETIME NOT NULL,
qty_exp SMALLINT NOT NULL,
date_rec DATETIME,
qty_rec SMALLINT
);

CREATE TABLE alp_customer
(
cust_id INTEGER IDENTITY(1, 1) PRIMARY KEY,
lastname VARCHAR(50) NOT NULL,
firstname VARCHAR(50) NOT NULL,
mi VARCHAR(50),
addresss VARCHAR(50) NOT NULL,
city VARCHAR(50) NOT NULL,
states VARCHAR(50) NOT NULL,
zip VARCHAR(50) NOT NULL,
phone VARCHAR(50) NOT NULL,
email VARCHAR(50) NOT NULL
);

CREATE TABLE alp_color
(
alp_color VARCHAR(50) PRIMARY KEY
);

CREATE TABLE alp_inventory
(
inv_id INTEGER IDENTITY(1, 1) PRIMARY KEY,
item_id INT NOT NULL,
item_size VARCHAR(50),
alp_color VARCHAR(50),
price DECIMAL(6, 2) NOT NULL,
quantity_on_hand INT NOT NULL
);

CREATE TABLE alp_ordersource
(
alp_ordersource VARCHAR(50) PRIMARY KEY
);

CREATE TABLE alp_shipping
(
ship_id INT NOT NULL,
inv_id INT NOT NULL,
date_exp DATETIME NOT NULL,
qty_exp SMALLINT NOT NULL,
date_rec DATETIME,
qty_rec SMALLINT,
PRIMARY KEY(ship_id, inv_id)
);

CREATE TABLE alp_orderline
(
order_id INT NOT NULL,
inv_id INT NOT NULL,
order_price DECIMAL(6, 2) NOT NULL,
qty SMALLINT NOT NULL,
PRIMARY KEY(order_id, inv_id)
);



INSERT INTO alp_item
VALUES('Women''s Hiking Shorts', 'Women''s Clothing');

INSERT INTO alp_item
VALUES('Women''s Fleece Pullover', 'Women''s Clothing');

INSERT INTO alp_item
VALUES('Children''s Beachcomber Sandals', 'Children''s Clothing');

INSERT INTO alp_item
VALUES('Men''s Expedition Parka', 'Men''s Clothing');

INSERT INTO alp_item
VALUES('3-Season Tent', 'Outdoor Gear');


INSERT INTO alp_orders
VALUES('2007-10-10', 'CC', 1, '152');

INSERT INTO alp_orders
VALUES('2007-10-31', 'CC', 2, 'WEBSITE');

INSERT INTO alp_orders
VALUES('2007-11-22', 'CHECK', 3, '152');

INSERT INTO alp_orders
VALUES('2007-11-29', 'CC', 3, '153');

INSERT INTO alp_orders
VALUES('2007-12-12', 'CC', 5, 'WEBSITE');

INSERT INTO alp_orders
VALUES('2007-12-24', 'CC', 5, 'WEBSITE');


INSERT INTO alp_ordersource
VALUES('122');

INSERT INTO alp_ordersource
VALUES('123');

INSERT INTO alp_ordersource
VALUES('145');

INSERT INTO alp_ordersource
VALUES('146');

INSERT INTO alp_ordersource
VALUES('151');

INSERT INTO alp_ordersource
VALUES('152');

INSERT INTO alp_ordersource
VALUES('153');

INSERT INTO alp_ordersource
VALUES('211');

INSERT INTO alp_ordersource
VALUES('99');

INSERT INTO alp_ordersource
VALUES('WEBSITE');


INSERT INTO alp_color
VALUES('Blue');

INSERT INTO alp_color
VALUES('Brown'); 

INSERT INTO alp_color
VALUES('Coral');

INSERT INTO alp_color
VALUES('Forest');

INSERT INTO alp_color
VALUES('Green'); 

INSERT INTO alp_color
VALUES('Khaki');

INSERT INTO alp_color
VALUES('Navy');

INSERT INTO alp_color
VALUES('Olive'); 

INSERT INTO alp_color
VALUES('Red');

INSERT INTO alp_color
VALUES('Sienna');

INSERT INTO alp_color
VALUES('Teal'); 


INSERT INTO alp_customer
VALUES('Jones', 'Cindy', 'E', '1156 Water Street Apt. 3', 'Osseo', 'WI', '54705', '7155558943', '..s@hotmail.com');

INSERT INTO alp_customer
VALUES('Edwards', 'Mitch', 'M', '4204 Garner Street', 'Washburn', 'WI', '54891', '7155558243', '..s@gmail.com');

INSERT INTO alp_customer
VALUES('Sorenson', 'Betty', 'H', '2211 Pine Drive', 'Radisson', 'WI', '54867', '7155558332', '..1@yahoo.com');

INSERT INTO alp_customer
VALUES('Miller', 'Lee', null, '699 Pluto St. NE', 'Silver Lake', 'WI', '53821', '7155554978', '..r@gmail.com');

INSERT INTO alp_customer
VALUES('White', 'Alissa', 'R', '987 Durham Rd.', 'Sister Bay', 'WI', '54234', '7155557651', '..e@hotmail.com');


INSERT INTO alp_inventory
VALUES(5, null, 'Sienna', 274.99, 14);

INSERT INTO alp_inventory
VALUES(5, null, 'Forest', 274.99, 8);

INSERT INTO alp_inventory
VALUES(1, 'S', 'Khaki', 32.95, 57);    

INSERT INTO alp_inventory
VALUES(1, 'M', 'Khaki', 32.95, 89);

INSERT INTO alp_inventory
VALUES(1, 'L', 'Khaki', 32.95, 0);

INSERT INTO alp_inventory
VALUES(1, 'S', 'Olive', 32.95, 110);    

INSERT INTO alp_inventory
VALUES(1, 'M', 'Olive', 32.95, 51);

INSERT INTO alp_inventory
VALUES(1, 'L', 'Olive', 32.95, 23);

INSERT INTO alp_inventory
VALUES(2, 'S', 'Teal', 64.95, 112);    

INSERT INTO alp_inventory
VALUES(2, 'M', 'Teal', 64.95, 37);

INSERT INTO alp_inventory
VALUES(2, 'L', 'Teal', 64.95, 125);

INSERT INTO alp_inventory
VALUES(2, 'S', 'Coral', 64.95, 0);    

INSERT INTO alp_inventory
VALUES(2, 'M', 'Coral', 64.95, 86);

INSERT INTO alp_inventory
VALUES(2, 'L', 'Coral', 64.95, 140);

INSERT INTO alp_inventory
VALUES(3, '10', 'Blue', 15.99, 78);    

INSERT INTO alp_inventory
VALUES(3, '11', 'Blue', 15.99, 86);

INSERT INTO alp_inventory
VALUES(3, '12', 'Blue', 15.99, 23);    

INSERT INTO alp_inventory
VALUES(3, '6', 'Blue', 15.99, 89);

INSERT INTO alp_inventory
VALUES(3, '10', 'Red', 15.99, 56);    

INSERT INTO alp_inventory
VALUES(3, '11', 'Red', 15.99, 35);

INSERT INTO alp_inventory
VALUES(3, '12', 'Red', 15.99, 84);    

INSERT INTO alp_inventory
VALUES(3, '6', 'Red', 15.99, 0);

INSERT INTO alp_inventory
VALUES(4, 'S', 'Green', 199.95, 92);    

INSERT INTO alp_inventory
VALUES(4, 'M', 'Green', 199.95, 17);

INSERT INTO alp_inventory
VALUES(4, 'L', 'Green', 209.95, 0);    

INSERT INTO alp_inventory
VALUES(4, 'XL', 'Green', 209.95, 12);


INSERT into alp_orderline
VALUES(1, 1, 274.99, 1);

INSERT into alp_orderline
VALUES(1, 6, 32.95, 2);

INSERT into alp_orderline
VALUES(2, 10, 64.95, 1);

INSERT into alp_orderline
VALUES(3, 16, 15.99, 1);

INSERT into alp_orderline
VALUES(3, 18, 15.99, 1);

INSERT into alp_orderline
VALUES(4, 23, 199.95, 1);

INSERT into alp_orderline
VALUES(5, 21, 15.99, 2);

INSERT into alp_orderline
VALUES(5, 7, 32.95, 1);

INSERT into alp_orderline
VALUES(6, 10, 64.95, 1);

INSERT into alp_orderline
VALUES(6, 26, 209.95, 1);


INSERT INTO alp_backorder
VALUES(9, 24, '2008-07-21', 30, null, null);

INSERT INTO alp_backorder
VALUES(10, 25, '2008-07-21', 30, null, null);


INSERT INTO alp_shipping
VALUES(1, 1, '2008-06-18', 10, null,null);

INSERT INTO alp_shipping
VALUES(1, 2, '2008-06-18', 10, null,null);

INSERT INTO alp_shipping
VALUES(2, 5, '2008-07-10', 50, null,null);

INSERT INTO alp_shipping
VALUES(3, 12, '2008-08-19', 50, null,null);

INSERT INTO alp_shipping
VALUES(4, 20, '2008-09-25', 50, null,null);

INSERT INTO alp_shipping
VALUES(4, 22, '2008-09-25', 50, null,null);

INSERT INTO alp_shipping
VALUES(5, 8, '2008-10-31', 30, null,null);

INSERT INTO alp_shipping
VALUES(6, 17, '2008-11-05', 20, null,null);

INSERT INTO alp_shipping
VALUES(7, 14, '2008-05-18', 50, '2008-05-18', 50);

INSERT INTO alp_shipping
VALUES(8, 11, '2008-05-29', 50, '2008-05-29', 50);

INSERT INTO alp_shipping
VALUES(9, 24, '2008-05-30', 30, '2008-05-30', 0);

INSERT INTO alp_shipping
VALUES(10, 25, '2008-05-30', 30, '2008-05-30', 0);