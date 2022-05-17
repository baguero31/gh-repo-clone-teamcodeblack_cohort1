use pubs;
SELECT * FROM discounts
SELECT * FROM sales

SELECT * FROM discounts DI
INNER JOIN sales SA ON DI.stor_id = SA.stor_id

SELECT * FROM discounts DI
LEFT JOIN sales SA ON DI.stor_id = SA.stor_id

SELECT * FROM discounts DI
RIGHT JOIN sales SA ON DI.stor_id = SA.stor_id

SELECT * FROM discounts DI
CROSS JOIN sales


