

create table showconstraint(id int primary key identity(1,1) , firstname varchar(20)not null , lastname varchar(20) default('kumar'));
insert into showconstraint (firstname,lastname)values('miki', 'kale');
insert into showconstraint (firstname,lastname)values('niki');
select * from showconstraint;


alter table showconstraint 
alter column firstname varchar (30);
alter table showconstraint add salary decimal (12,2);
alter table showconstraint alter column salary decimal(12,2)not null;


                                             --we can  write first primary key and identity key later on we can only write the alter key.--
create table mymath(a int , b int );
insert into mymath(a,b)values(2,4);
alter table mymath add constraint pk primary key ;
select * from mymath;


  create table showconstraints(id int primary key identity(1,1),firstname varchar(20)not null , lastname varchar(30) default ('kumar'), salary decimal(12,2));

