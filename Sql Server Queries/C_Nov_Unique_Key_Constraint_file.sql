  use myDB;
  create table School(id int primary key identity(5,1),fname varchar(10) unique , lname varchar(10));
  insert into School(fname,lname)values('Miki','Bhoyar');
  insert into School(fname,lname)values('Niki','Sharma');
  select * from School;

  create table CollegeStud(id int primary key identity(10,1), fname varchar(10)unique , lname varchar(10) not null ,
  collegename varchar(20) default('jit'), branch varchar(20)check (branch in ('CSE' , 'ETC' , 'ME' , 'Civil' ))); 

  insert into CollegeStud(fname,lname,branch)values('miki','bhansal','CSE');
  insert into CollegeStud(fname,lname,branch)values('niki','bhansal','ETC');
  select * from CollegeStud;
