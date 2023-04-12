USE sql_store;

INSERT INTO customers (
	first_name, 
    last_name, 
    birth_date,
    address,
    city,
    state
    )    
VALUE (
    'John', 
    'Smith', 
    '1990-01-01',
    'address',
    'city',
    'CA'
    )
