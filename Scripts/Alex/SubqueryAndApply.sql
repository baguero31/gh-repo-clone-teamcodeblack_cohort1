use pubs;

--Insert statement is first part of the sub query
INSERT INTO [TESTTABLE2]
           ([ttAuthorFName],[ttAuthorLName],[ttAuthorAddr]
			,[ttAuthorPhone],[ttBookTitle],[ttEmpFName],[ttEmpLName]
			,[ttPublisher])
SELECT AuthFName, AuthLname, AuthAddr, 
		AuthPhone, BookTitle, EmpFName, 
		EmpLName, PubName, titleID
FROM(
	/*
		First subquery retrieves information from the 
		authors, titleauthor, and titles table
	*/
	SELECT T.pub_id titlePubID,
		   T.title_id tTitleID,
		   au_fname AuthFName, 
		   au_lname AuthLname, 
		   [address] AuthAddr, 
		   phone AuthPhone, 
		   title BookTitle from authors AU
	INNER JOIN titleauthor TA on ta.au_id = au.au_id
	INNER JOIN titles T ON T.title_id = ta.title_id 
)SubQ1
INNER JOIN(
	/*
		This subquery joins the first query together and gets 
		information from the publishers table as well as the employee
		table.
	*/
	SELECT p.pub_id pubID, 
		   fname EmpFName, 
		   lname EmpLName, 
		   pub_name PubName FROM employee E
	INNER JOIN publishers P on p.pub_id = e.pub_id
)SubQ2 ON pubID = titlePubID
/*
	This cross apply searches for the matching title id from the sales
	table that matches the title id in the first query
*/
CROSS APPLY (
	SELECT TOP 1 title_id titleID
	FROM SALES S
	WHERE s.title_id = tTitleID
) AS TESTcol
/*
	This is a 'safe insert' that ensures that duplicate rows are 
	not inserted into the table!  This should be done on the 
	key of the table to make sure you don't have issues.
*/
LEFT OUTER JOIN TESTTABLE2 ON
	ttAuthorFName = AuthFName AND
	ttAuthorLName = AuthLname AND
	ttAuthorAddr = AuthAddr
WHERE ttAuthorFName IS NULL
