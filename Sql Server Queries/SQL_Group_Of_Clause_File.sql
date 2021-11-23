select * from Products;
select count(*) from products where catid=10; 

select sum(price)from products group by catid;
select avg(price)from products group by catid;