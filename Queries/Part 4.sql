USE AlpineInventory 
GO

DROP PROCEDURE IF EXISTS sp_UpdateInventory;
DROP PROCEDURE IF EXISTS sp_InsertOrder;
DROP PROCEDURE IF EXISTS sp_UpdateColor;
DROP PROCEDURE IF EXISTS sp_CancelOrder;
DROP PROCEDURE IF EXISTS sp_CalcOrderTotal1; -- VERSION 1 with OUTPUT
DROP PROCEDURE IF EXISTS sp_CalcOrderTotal2; -- VERSION 2 without OUTPUT
DROP TRIGGER IF EXISTS tr_updateInventory;


-- Procedure 1:
Create PROCEDURE sp_UpdateInventory (@inv_id INT, @qty INT)
AS 
BEGIN
UPDATE [alp_inventory]
SET quantity_on_hand = @qty + quantity_on_hand
WHERE inv_id = @inv_id;
END

SELECT inv_id, quantity_on_hand FROM alp_inventory WHERE inv_id = 2 -- BEFORE proc
EXEC sp_UpdateInventory @inv_id = 2, @qty = 2 -- proc
SELECT inv_id, quantity_on_hand FROM alp_inventory WHERE inv_id = 2 -- AFTER proc


-- Procedure 2:
Create PROCEDURE sp_InsertOrder (@order_date DATETIME, @payment VARCHAR(50), @cust_id INT, @alp_ordersource VARCHAR(50))
AS 
BEGIN
INSERT INTO alp_orders(order_date, payment, cust_id, alp_ordersource)
VALUES (@order_date, @payment, @cust_id, @alp_ordersource)
END

SELECT * FROM alp_orders -- BEFORE proc
EXEC sp_InsertOrder @order_date = '20210403', @payment = 'CASH', @cust_id = 3, @alp_ordersource = 'WEBSITE' -- proc
SELECT * FROM alp_orders -- AFTER proc


-- Procedure 3:
Create PROCEDURE sp_UpdateColor (@old_color VARCHAR(50), @alp_color VARCHAR(50))
AS 
BEGIN
UPDATE [alp_inventory]
SET alp_color = @alp_color
WHERE alp_color = @old_color;
END

SELECT * FROM alp_inventory -- BEFORE proc
EXEC sp_UpdateColor @old_color = 'Coral', @alp_color = 'Pink' -- proc
SELECT * FROM alp_inventory -- AFTER proc


-- Procedure 4: (deletes rows based on order id)
Create PROCEDURE sp_CancelOrder (@order_id INT)
AS 
DELETE FROM alp_orders
WHERE order_id = @order_id

SELECT * FROM alp_orders -- BEFORE proc
EXEC sp_CancelOrder @order_id = 3 -- proc
SELECT * FROM alp_orders -- AFTER proc


-- Procedure 5: 
Create PROCEDURE sp_CalcOrderTotal1 (@order_id INT, @total DECIMAL(6, 2) OUTPUT)
AS 
BEGIN
SELECT @total = SUM(order_price * qty)
FROM alp_orderline
WHERE order_id = @order_id
END

DECLARE @o_total DECIMAL(6, 2)
EXEC sp_CalcOrderTotal1 @order_id = 2, @total = @o_total OUTPUT
PRINT 'Order total is $' + CAST(@o_total AS VARCHAR(50));

-- VERSION 2 without OUTPUT keyword
Create PROCEDURE sp_CalcOrderTotal2 (@order_id INT)
AS 
BEGIN
SELECT SUM(order_price * qty) AS order_total
FROM alp_orderline
WHERE order_id = @order_id
END

EXEC sp_CalcOrderTotal2 @order_id = 2


-- Trigger 1:
CREATE TRIGGER tr_updateInventory
ON alp_inventory
AFTER UPDATE
AS
BEGIN
DECLARE @inv_id INT, @quantity_on_hand INT, @ship_id INT
SET @inv_id = (SELECT inv_id FROM inserted)
SET @ship_id = (SELECT MAX(ship_id) FROM alp_shipping) + 1
SET @quantity_on_hand = (SELECT quantity_on_hand FROM inserted)
IF(UPDATE(quantity_on_hand))
BEGIN
IF (@quantity_on_hand) < 5
INSERT INTO alp_shipping (ship_id, inv_id, date_exp, qty_exp, date_rec, qty_rec)
VALUES(@ship_id, @inv_id, DATEADD(week, 1, GETDATE()), @quantity_on_hand, GETDATE(), @quantity_on_hand)
END
END

SELECT * FROM alp_shipping -- BEFORE
UPDATE alp_inventory SET quantity_on_hand = 1 WHERE inv_id = 22;
UPDATE alp_inventory SET quantity_on_hand = 4 WHERE inv_id = 12;
SELECT * FROM alp_shipping -- AFTER
