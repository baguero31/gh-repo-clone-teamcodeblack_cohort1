use pubs

insert into newtable2
(nt_emp_fname
,nt_logo 
,nt_pr_info
,nt_city)

select 
 fname
, logo
, pr_info
, city

from( 

select fname 
, logo
, pr_info
, city

from employee
inner join pub_info on employee.pub_id = pub_info.pub_id 
inner join publishers on employee.pub_id = publishers.pub_id
)subq1


Select * from newtable2


	