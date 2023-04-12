USE sql_store;

SELECT * 
FROM order_items oi
LEFT JOIN order_item_notes oin
	ON oi.product_id = oin.product_id 
    AND oi.order_id = oin.order_id 