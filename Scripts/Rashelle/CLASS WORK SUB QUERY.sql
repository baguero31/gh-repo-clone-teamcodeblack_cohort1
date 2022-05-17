use pubs
SELECT AuthorFName, AuthorLName, AuthorAddress, AuthorPhone, BookTitle, EmpFName, EmpLName, Publisher
FROM
(
-- FIRST QUERY
SELECT	au_fname AuthorFName,
		au_lname AuthorLName, 
		[address] AuthorAddress, 
		phone AuthorPhone,
		Title BookTitle,
		TS.pub_id TitlePubID
	from authors au
	inner join titleauthor TA on TA.au_id = AU.au_id
	inner join titles TS on ts.title_id = TA.title_id 
) SUBQ1

INNER JOIN (
-- second query
 
select	fname EmpFName,
		lname EmpLName,
		pub_name Publisher,
		EP.pub_id PublisherID
from employee EP
inner join publishers PUB on pub.pub_id = EP.pub_id
) SUBQ2 on SUBQ2.PublisherID = SUBQ1.TitlePubID