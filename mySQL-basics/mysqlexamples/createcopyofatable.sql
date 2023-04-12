USE sql_invoicing;

CREATE TABLE invoices_archive AS 
SELECT 
	cl.name,
    inv.payment_date
FROM invoices inv
JOIN clients cl 
	USING (client_id)
WHERE payment_date IS NOT NULL 
-- when run again it won't work b/c table already exists