USE AlpineInventory 
GO

-- 1.
SELECT descriptions, category
FROM alp_item;

-- 2.
SELECT item_id, item_size, price, quantity_on_hand 
FROM alp_inventory
WHERE price < 100;

-- 3.
SELECT item_id, quantity_on_hand, price
FROM alp_inventory
WHERE quantity_on_hand > 30;

-- 4.
SELECT lastname, firstname, mi, city
FROM alp_customer
WHERE city = N'Washburn' OR city = N'Silver Lake';

-- 5.
SELECT DISTINCT price
FROM alp_inventory;

-- 6.
SELECT item_id, quantity_on_hand, price
FROM alp_inventory
WHERE quantity_on_hand != 0;

-- 7.
SELECT order_id, order_date
FROM alp_orders
WHERE order_date < '2007-11-01';

-- 8.
SELECT item_id, quantity_on_hand
FROM alp_inventory
WHERE (alp_color = N'Coral' OR alp_color = N'Olive') AND quantity_on_hand < 105;

-- 9.
SELECT item_id, descriptions, category
FROM alp_item
WHERE descriptions LIKE '%Fleece%';

-- 10.
SELECT inv_id, item_id, price
FROM alp_inventory
WHERE (item_size IS NULL) OR (alp_color IS NULL);

-- 11.
SELECT COUNT(order_id)
FROM alp_orders
WHERE order_date = '2007-10-10';

-- 12.
SELECT order_id, inv_id, order_price * qty AS ext_price 
FROM alp_orderline;

-- 13.
SELECT order_id, COUNT(DISTINCT inv_id) AS NumOfItems
FROM alp_orderline
GROUP BY order_id;

-- 14.
SELECT cust_id, COUNT(order_id) AS NumOfOrders
FROM alp_orders
GROUP BY cust_id
HAVING COUNT(order_id) > 1;

-- 15.
SELECT order_id AS Order_ID, SUM(qty*order_price) AS Order_Total
FROM alp_orderline
GROUP BY order_id
HAVING SUM(qty*order_price) > 100
ORDER BY Order_Total ASC;

-- 16.
SELECT MAX(price) AS Most_Expensive, MIN(price) AS Least_Expensive, AVG(price) AS Average
FROM alp_inventory;

-- 17.
SELECT *
FROM alp_inventory
WHERE price > (SELECT AVG(I.price) FROM alp_inventory AS I);
