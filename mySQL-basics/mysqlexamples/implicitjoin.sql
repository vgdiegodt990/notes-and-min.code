USE sql_invoicing;

SELECT 
	pay.date, 
    cli.name AS client,
    pay.amount,
    paymet.name as payment_method
    
FROM payments pay
JOIN clients cli 
	USING (client_id) 
JOIN payment_methods paymet
	ON paymet.payment_method_id = pay.payment_method
    