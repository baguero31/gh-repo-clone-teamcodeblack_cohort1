Use pubs; 
SELECT * FROM discounts
SELECT * FROM sales

SELECT discount, stor_id 
FROM discounttype INNER JOIN sales on s.stor_id = s.stor_id 

SELECT discount, stor_id 
FROM discountype LEFT JOIN sales on s.stor_id = s.stor_id 

SELECT discount, stor_id 
FROM discounttype RIGHT JOIN sales on s.stor_id = S.stor_id 

SELECT discount, stor_id 
FROM discounttype CROSS JOIN sales on s.stor_id = S.stor_id 









SELECT * FROM discounttype
INNER JOIN sales SA ON DI.stor_id = SA.stor_id

SELECT * FROM discounts DI
LEFT JOIN sales SA ON DI.stor_id =SA.stor_id

SELECT * FROM discounts DI
RIGHT JOIN sales SA ON DI.stor_id = SA.stor_id

SELECT * FROM discounts DI
CROSS JOIN sales SA ON DI.stor_id = SA.stor_id
