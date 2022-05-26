use pubs;

--insert subquery inserts selected values into new table
INSERT INTO NewTable
    (EmployN
	,EmployLN
	,Employ_J_ID
	,employ_JD
	,logos
	,pub_pr)

        SELECT
        	EFirstName
            ,ELastName
            ,EMP_JID
            ,JD
			,loger
			,pr

            FROM(
            --begin first subq (because sql doesnt follow conventions im used to so mentally i have to mark it here)
            --Grab first name of employees, their j_id and job desc from tables employee and jobs
                SELECT DISTINCT
            	    employee.fname EFirstName
            		,employee.lname ELastName
            		,employee.job_id EMP_JID
            		,job_desc JD
					,employee.pub_id EMPID
            	FROM
            	    employee
            	INNER JOIN 
            	    jobs J 
            	        ON 
            	            J.job_id = employee.job_id
            	
            )SQ1 
			CROSS JOIN(
                --begin second subq
            	--you have no idea how much trouble this second query gave me
				--couldnt get the inner join because something to do with PUB.pub_id not being found
				--oh well, we can talk about it over class
                SELECT 
            	    logo loger
					,pr_info pr
					,PUB.pub_id
				FROM pub_info PUB
				INNER JOIN 
				    employee em
				ON 
				    PUB.pub_id = em.pub_id
            )SQ2
			   -- ON 
				 --   PUB.pub_id = EMPID
				 --left overs for posterity sake^
				 --yes im aware this spikes the number of inserts to like thousands of rows

--safe insert like we were taught

LEFT OUTER JOIN 

        NewTable
	ON

	    EmployN = EFirstName AND

	    EmployLN = ELastName AND

	    Employ_J_ID = EMP_JID

WHERE EmployN IS NULL
--not my prettiest work, but i understand the basics, subqueries are just sql functions that replace varibles that (represent lists of) data
--things to add if I didn't have to work weekends:
--regex for all the last names starting with "S"
--an inner join instead of a cross join
--cleaner operation: it keeps affecting zero rows then one row for some reason