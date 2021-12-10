



my DB;

create table StudentDetails(Student_Name varchar(20) , DOA datetime  , Branch varchar(20) , Dept_no int , Fees int);
insert into StudentDetails values( 'Nikita' , 2021-01-11 , 'CSE' , 1,'5000');
insert into StudentDetails values( 'Sakshi' , 2021-02-12 , 'CSE' , 1,'6000');
insert into StudentDetails values( 'Prachi' , 2023-03-9 , 'CSE' , 1,'7000');
insert into StudentDetails values( 'Suyash' , 2024-04-10, 'CSE' , 1,'8000');
insert into StudentDetails values( 'Nilesh' , 2025-05-11 , 'CSE' , 1,'9000');

select * from StudentDetails;

select Student_Name,DOA,Branch,Dept_no from StudentDetails order by DOA;

select Dept_no , Fees from StudentDetails group by Dept_no;

select Dept_no Fees from StudentDetails group by Dept_no having max(Fees)>1000;

select  Dept_no Student_Name from StudentDetails group by Dept_no having max(Fees)>1000;
