USE sql_store;

UPDATE customers 
SET 
	-- using an expression to update points column 
	points = points + 50  
WHERE birth_date < '1990-01-01'
