SELECT au_id,au_fname, au_lname, phone, [address]
FROM dbo.authors
ORDER by au_id

SELECT COUNT (*)
FROM dbo.authors