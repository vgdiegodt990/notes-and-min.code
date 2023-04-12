USE sql_invoicing;

SELECT 
	cli.client_id,
    cli.name,
    pay.date,
    pay.invoice_id,
    pay.amount,
    pay.payment_method,
    paymet.name
    
FROM clients cli
JOIN payments pay 
	ON pay.client_id = cli.client_id 
JOIN payment_methods paymet
	ON paymet.payment_method_id = pay.payment_method