USE pubs;

--still messing with how i like to arrange syntax

--INNER JOIN
SELECT
    R.title_id
	,lorange
FROM 
    roysched R
	INNER JOIN titleauthor TA
        ON TA.title_id = R.title_id
ORDER BY R.lorange


--LEFT OUTTER JOIN
SELECT 
    PHONE 
	,[address] 
FROM 
    authors AU
    LEFT OUTER JOIN titleauthor TA 
	    ON AU.au_id = TA.au_id


--RIGHT OUTTER JOIN
SELECT 
    *
FROM 
	authors AU
    RIGHT OUTER JOIN titleauthor TA 
		ON AU.au_id = TA.au_id
    WHERE TA.au_id IS NOT NULL

--CROSS JOIN
SELECT 
    * 
FROM pub_info pubinf
        CROSS JOIN publishers
ORDER BY pubinf.pub_id

