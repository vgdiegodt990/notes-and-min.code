USE sql_store;

SELECT 
	prod.product_id,
    prod.name, 
    ordit.quantity
FROM products prod
LEFT JOIN order_items ordit
	ON prod.product_id = ordit.product_id
