use myDB;

create table Employee_Data(Emp_id int primary key identity(1,1), Emp_name varchar(20) , Emp_salary Decimal );
insert into Employee_Data values('Nikita', 2500);
insert into Employee_Data values('Piyush Bhagat', 3500);
insert into Employee_Data values('Nikhil Puri', 4500);
insert into Employee_Data values('Akansha Gedam', 5500);

insert into Employee_Data values('Vaishavni Nagmote', 6500);


select * from Employee_Data;