use pubs; 
-- looking for pub_id on both publishers and pub_info tables--
SELECT * FROM publishers

SELECT * FROM pub_info
-- combine pub_id onto one table with both publishers and pub_info tables--
SELECT * FROM publishers PS
 INNER JOIN pub_info PB on PS.pub_id = PB.pub_id
 --combine same tables so from the left table and matching rows in the right table--
 SELECT * FROM publishers PS
 LEFT JOIN pub_info PB on PS.pub_id = PB.pub_id
 --combine same tables from rows from the right table and the matching rows in the left table--
  SELECT * FROM publishers PS
 RIGHT JOIN pub_info PB on PS.pub_id = PB.pub_id
 --combine same tables to cross reference --
 SELECT * FROM publishers PS
 CROSS JOIN pub_info PB
