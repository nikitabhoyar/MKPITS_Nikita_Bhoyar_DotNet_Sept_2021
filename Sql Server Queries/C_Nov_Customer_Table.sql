use myDB;
--create table Customer(id int  , firstname varchar(20) , lastname varchar(20) , age int);         --this command is used for creating the table in the  database--
insert into Customer values (13, 'nikita' , 'Bhoyar'  , 15 );                                    --this command is used for inserting the data in the table of  database--
insert into Customer values (15, 'Prachi' , 'Sharma' , 20 );
insert into Customer values (20 , 'Nikhat' , 'Kale' , 35);                                       --One way to insert the records in the table --
insert into Customer (id , firstname,lastname, age )values(16, 'Piyush' , 'Sjdeva' , '20' ); 
insert into Customer (id, firstname,lastname,age)values(18,'niki','Das', '23');                                                                                           --Another way to insert the data in the table--
select * from Customer;
drop table Customer;--

create table Biodata(fname varchar(10), lname varchar(10) , age int , Education varchar(10));  --field is here is fname , feild is lname , values here is 22 , lokhande , nikita';
insert  into Biodata values('prachi' , 'Bhoyar' , '22' , 'BE' );
insert into Biodata values('Suyash' , 'Lokhande' , '23' , 'BE');
update Biodata set age=23 where fname='prachi';
update Biodata set lname='sharma' where age=23;
update Biodata set fname='Nikita' where Education='BE';
update Biodata set age=22 where fname='Nikita';
select age,fname+ ' ' +lname as 'Fullname' from Biodata;

select * from Biodata;
delete  from Biodata where age=22;

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

