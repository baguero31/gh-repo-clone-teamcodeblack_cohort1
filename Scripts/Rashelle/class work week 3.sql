USE PUBS;

SELECT * FROM authors
SELECT * FROM titleauthor

SELECT * FROM authors AU
INNER JOIN titleauthor TA on AU.au_id = TA.au_id