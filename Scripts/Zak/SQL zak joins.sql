select * 
From authors AU
INNER JOIN titleauthor ta 
on AU.au_id = ta.au_id

select * 
from titleauthor ta
right join titles ti 
on ta.title_id = ti.title_id
where ta.title_id is null

select * 
From employee em
left join publishers pb
on em.pub_id = pb.pub_id
where em.pub_id is null

select * 
from authors
cross join stores



