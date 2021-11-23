

use mydb;
create table child(id int primary key identity(1,1) , fname varchar(10) , lname varchar(10) , age int);
insert into child(fname,lname)values('miki' , 'sharma' , 15);
select * from child;
