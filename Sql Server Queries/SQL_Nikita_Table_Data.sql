use myDB;
create table nikita(id int , fname varchar(10) , lname varchar(10) , age int );  
insert into  nikita values (101, 'Niki' , 'Bhoyar' , 34);
insert into nikita values (102 , 'Prachi' , 'Kale' , 45);
select  fname+ ' ' +lname ,age as 'Fullname' from nikita;
select age from nikita  where id=101;
select count(*) as 'Total Records' from Biodata;

alter table dbo.nikita
add salary decimal(10,2);

alter table nikita
add rollno  int;

insert into nikita(rollno) values(34);
update nikita set salary=2344 where age=34;
update nikita set salary=1200 where id=102;
update nikita set rollno=12 where id=101;
update nikita set rollno=13 where id=102;

alter table nikita add gender varchar(10);
update nikita set gender='female' where id=101;
update nikita set gender='female' where id=102;
select count(*) as 'Total Records' from nikita;

alter table nikita drop column rollno;
alter table nikita drop column gender;
select * from nikita;

