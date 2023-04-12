INSERT INTO orders_archived ()
-- using select statement as a subquery in an insert statement 
SELECT *
FROM orders 
WHERE order_date < '2019-01-01'

-- table was truncated before data was put in 