use myDB;

create table worker(ID int primary key identity(1,1), workerId varchar(7) unique, workername varchar(10)not null , Wages decimal(12,2) check (wages in (200,600, 1000)) , permanent bit , DOJ date ); 
select * from worker;
drop table worker;

