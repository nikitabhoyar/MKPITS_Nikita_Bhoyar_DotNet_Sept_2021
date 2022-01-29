use myDB;
create Table employee1( id int primary key identity(1,1) , fname varchar(20) , lname varchar(20) ,
city varchar(20) , branch varchar(20) , salary decimal(12,2) );

insert into employee1 (fname,lname,city,branch,salary)values( 'nikita' , 'bhoyar' , 'mumbai' , 'CSE', '25000' );
insert into employee1 (fname,lname,city,branch,salary)values( 'prachi' , 'sajdeva' , 'delhi' , 'Electrical', '45000' );
insert into employee1 (fname,lname,city,branch,salary)values( 'ashish' , 'dongre' , 'nagpur' , 'ETC ', '55000' );
insert into employee1 (fname,lname,city,branch,salary)values( 'suyash' , 'mirase' , 'banglore' , 'Civil', '35000' );
insert into employee1 (fname,lname,city,branch,salary)values( 'natasha' , 'jain' , 'delhi' , 'ME', '75000' );


select * from employee1;
select * from employee1 where city like 'nagpur'; 

select fname,lname,city from employee1 where city like 'banglore' ;

select fname,lname,city from employee1 where city like 'MU%' ;

select fname,lname,city from employee1 where city like 'M%' ;

select *  from employee1 where city like '%el%' ;

select id,fname + ' ' +lname as "Full name" from employee1; 

select id as 'EmployeeId' , fname + ' ' +lname as 'Name' , salary as '$Salary' from employee1;


select * from employee1  where salary<45000;
select * from employee1 where salary>45000;
select * from employee1 where salary>35000 and salary <55000;


select fname,lname,salary from employee1 where  salary <>75000--not equal to (75,000);
select fname,lname,salary, city from employee1 where salary <75000 or city like 'delhi';
select fname,lname,salary, city from employee1 where salary <75000 and city like 'delhi';
select fname,lname,(salary+(salary*70/100+1200) as  'Gross Salary'  from employee1;


select count(*) as 'total records' from employee1;
select count(*) as 'total records' from employee1 where city like 'Delhi';
select count(*) as 'total records' from employee1 where salary  <=75000;
 
select max(salary)as 'Max Salary'  from employee1;
select min(salary)as 'Min Salary'  from employee1;
select avg(salary)as 'Avg Salary'  from employee1;
select Sum(salary)as 'Sum Salary'  from employee1;








