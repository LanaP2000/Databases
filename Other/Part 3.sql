USE AlpineInventory 
GO

-- 1.
SELECT inv_id AS Inventory_ID, alp_color AS color
FROM alp_inventory
WHERE alp_color =
(SELECT alp_color
FROM alp_inventory
WHERE inv_id = 23
);

-- 2.
SELECT inv_id AS Inventory_ID, price AS Price
FROM alp_inventory
WHERE price >
(SELECT AVG(price)
FROM alp_inventory
);

-- 3.
SELECT N.inv_id AS Inventory_ID, I.descriptions AS "Item Description", N.item_size, N.alp_color, N.price
FROM alp_inventory AS N
JOIN alp_item AS I
ON N.item_id = I.item_id;

-- 4.
SELECT O.order_id AS Order_ID, O.order_date AS Order_Date, (C.firstname + ' ' + C.lastname) AS "Customer Name"
FROM alp_orders AS O
LEFT OUTER JOIN alp_customer AS C
ON O.cust_id = C.cust_id
WHERE O.order_id IS NOT NULL;

-- 5.
SELECT O.order_id AS Order_ID, O.order_date as Order_Date
FROM alp_Orders AS O
INNER JOIN alp_orderline AS OL
ON O.order_id = OL.order_id
INNER JOIN alp_inventory AS I
ON I.inv_id = OL.inv_id
WHERE item_id = 4;

-- 6. Decided to include items as well, for demonstration purposes
SELECT OL.inv_id AS Inventory_ID, order_price * qty AS "Extended Price", qty AS Qty, IT.descriptions AS Items
FROM alp_orderline AS OL
INNER JOIN alp_inventory AS I
ON I.inv_id = OL.inv_id
INNER JOIN alp_item AS IT
ON I.item_id = IT.item_id
WHERE order_id = 6;

-- 7. in stock - quantity-on hand - quantity sold (in table orderline)
-- Not sure about the formula, googled and got it
SELECT I.item_id AS Item_ID, SUM(I.quantity_on_hand)-SUM(OL.qty) AS "In-Stock"
FROM alp_inventory AS I
FULL OUTER JOIN alp_orderline AS OL
ON I.inv_id = OL.inv_id
GROUP BY item_id
ORDER BY item_id; -- ASC by default, so did not use it

-- 8.
SELECT I.inv_id AS "Inventory ID", SUM(OL.qty) AS "Number Sold"
FROM alp_inventory AS I
FULL OUTER JOIN alp_orderline AS OL
ON I.inv_id = OL.inv_id
GROUP BY I.inv_id
ORDER BY SUM(OL.qty) DESC;

-- 9.
SELECT O.order_id AS Order_ID, (C.firstname + ' ' + C.lastname) AS "Customer Name", SUM(OL.order_price * OL.qty) AS "Order Total"
FROM alp_customer AS C
INNER JOIN alp_orders AS O
ON C.cust_id = O.cust_id
INNER JOIN alp_orderline AS OL
ON O.order_id = OL.order_id
GROUP BY O.order_id, C.lastname, C.firstname;

-- 10.
SELECT *
FROM alp_inventory
LEFT JOIN alp_shipping
ON alp_inventory.inv_id = alp_shipping.inv_id
WHERE alp_shipping.inv_id IS NULL;

-- 11. 
SELECT *
FROM alp_inventory AS I
INNER JOIN alp_backorder AS B
ON I.inv_id = B.inv_id;

-- 12. There was only Alissa White, so I used SUM to sum up her costs
SELECT C.lastname AS "Customer Lastname", C.firstname AS "Customer Firstname", SUM(OL.order_price * OL.qty) AS "Order Total"
FROM alp_customer AS C
INNER JOIN alp_orders AS O
ON C.cust_id = O.cust_id
INNER JOIN alp_orderline AS OL
ON O.order_id = OL.order_id
GROUP BY O.order_id, C.lastname, C.firstname
HAVING O.order_id = 5;

-- 13.
SELECT I.inv_id, IT.descriptions, I.price, I.alp_color
FROM alp_inventory AS I
JOIN alp_item AS IT
ON I.item_id = IT.item_id
WHERE price = 
(SELECT MIN(price)
FROM alp_inventory
);

-- 14.
SELECT C.lastname AS "Customer Lastname", C.firstname AS "Customer Firstname", C.email AS "Email address", SUM(OL.order_price * OL.qty) AS "Order Total"
FROM alp_customer AS C
INNER JOIN alp_orders AS O
ON C.cust_id = O.cust_id
INNER JOIN alp_orderline AS OL
ON O.order_id = OL.order_id
GROUP BY C.lastname, C.firstname, C.email;

-- 15.
SELECT C.lastname AS "Customer Lastname", C.firstname AS "Customer Firstname", C.email AS "Email address", SUM(OL.order_price * OL.qty) AS "Order Total"
FROM alp_customer AS C
LEFT OUTER JOIN alp_orders AS O
ON O.cust_id = C.cust_id
FULL OUTER JOIN alp_orderline AS OL
ON O.order_id = OL.order_id
GROUP BY C.lastname, C.firstname, C.email;