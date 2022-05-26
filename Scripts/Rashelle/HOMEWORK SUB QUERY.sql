USE pubs;

INSERT INTO [HWTABLE2]
	([StoreName],[StoreAddress],[StoreCity],[StoreState],[SalesQuantity],[Discount],[EmployeeID],[JobLevel],[HireDate],[JobDescription])
SELECT StoreName, StoreAddress, StoreCity, StoreState, SalesQuantity, Discount, EmployeeID, JobLevel, HireDate,JobDescription
FROM(
		SELECT stor_name StoreName,
	           stor_address StoreAddress,
	           [city] StoreCity,
	           [state] StoreState,
	           qty SalesQuantity,
	           discount Discount
		FROM stores ST

	INNER JOIN sales SA ON SA.stor_id = ST.stor_id
	INNER JOIN discounts DC on DC.stor_id = SA.stor_id
)SubQ1	
INNER JOIN(
		SELECT emp_id EmployeeID,
	           job_lvl JobLevel,
	           hire_date HireDate,
	           job_desc JobDescription
		FROM employee EP
	INNER JOIN jobs JB on JB.job_id = EP.job_id
)SubQ2 on EmployeeID = StoreName

