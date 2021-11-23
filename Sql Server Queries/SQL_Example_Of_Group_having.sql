select * from Products;
select count(*) from products where catid=10; 
--group by clause of select query is used with aggregate functions to get sum, avg etc for specific category--

select catid , sum(price)from products group by catid;
select avg(price)from products group by catid;
--average price of soap--
select catid , sum(price) from products group by catid having catid=1;
--sum price of catid--

select catid , avg(price) from products group by catid having catid=17;
--avg price of catid--

select catid , max(price)from products group by catid;
--max price of catid--


select catid , min(price)from products group by catid;
--min price of catid--

select catid, count(*) as 'Total items' from Products group by catid having catid=15;
--Total Count of itesms of catid--

select catid , min(price) from Products group by catid having catid=18;
--Min  Price of catid--