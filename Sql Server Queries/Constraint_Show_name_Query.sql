


create table show(id int primary key identity(1,1) , firstname varchar(20)not null , lastname varchar(20) default('kumar'));
insert into show (firstname,lastname)values('miki');
select * from show;

--alter table show
--alter column firstname varchar(30);--