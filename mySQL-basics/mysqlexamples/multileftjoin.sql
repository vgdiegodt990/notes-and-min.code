USE sql_store;

SELECT 
	ord.order_id,
	ord.order_date,
    cus.first_name AS customer,
    ship.name AS shipper, 
    ordstat.name AS status
FROM orders ord 
JOIN customers cus 
	ON cus.customer_id = ord.customer_id 
LEFT JOIN shippers ship 
	ON ship.shipper_id = ord.shipper_id 
LEFT JOIN order_statuses ordstat
	ON ordstat.order_status_id = ord.status 
ORDER BY ship.name IS NULL DESC