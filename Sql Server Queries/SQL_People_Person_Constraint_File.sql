use myDB;
create table Peopleconstraint(id int primary key identity(10,1), firstname varchar(10) not null, lastname varchar(10) default ('Bhoyar'));
insert into Peopleconstraint(firstname)values('Mann');
select * from Peopleconstraint;

create table Personconstraint1(Id int primary key identity(11,2) , Firstname varchar(10) , Lastname varchar(20)not null , gender varchar(10) default('Female'), rollno int);
insert into  Personconstraint1(Firstname,Lastname,rollno)values('Piyush', 'Sharma',12);
select count(*) as 'Total Record' from Personconstraint1;
select * from Personconstraint1;