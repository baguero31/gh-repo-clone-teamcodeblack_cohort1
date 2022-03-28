SELECT au_id, au_lname, au_fname, [address], phone from dbo.authors
order by au_id asc
Select count(au_id) from dbo.authors
