--00:00:00.243
select distinct * from TestDataTable 

--00:00:00.307
SELECT *
FROM (
	SELECT 
		ROW_NUMBER() OVER(PARTITION BY FirstName, LastName ORDER BY FirstName, LastName)
		as RowNum, ID, FirstName, LastName, EmailAddress, SomeDateTime
	FROM TestDataTable
) subQ
WHERE RowNum <= 1
ORDER BY ID ASC

