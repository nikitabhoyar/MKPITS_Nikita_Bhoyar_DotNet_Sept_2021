
use myDB;

create table People (id int identity(1,1) , firstname varchar(20) , lastname varchar(20), Datehired datetime );
insert into People(firstname,lastname)values('nikita' , 'bhoyar');
select * from People;

alter table dbo.People
add salary decimal(10,2);

--alter table People drop column salary;--
