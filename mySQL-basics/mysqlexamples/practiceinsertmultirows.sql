USE sql_store;

INSERT INTO products (name,
					  quantity_in_stock,
                      unit_price
					 )

VALUE ('Product1', 13, 1.95),
      ('Product2', 63, 3.95),
      ('Product3', 26, 5.95)