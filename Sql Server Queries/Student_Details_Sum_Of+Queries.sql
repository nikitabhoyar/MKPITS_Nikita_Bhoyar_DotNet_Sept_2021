use myDB;

create table student1(id int primary key identity(1,1), firstname varchar(20), lastname varchar(20), English int, Maths int, Science int);
insert into student1 (firstname,lastname,English,Maths,Science)values( 'nikita' , 'bhoyar' , 10 , 20, 30);
insert into student1 (firstname,lastname,English,Maths,Science)values( 'prachi' , 'patil' , 20 , 40, 40);
insert into student1 (firstname,lastname,English,Maths,Science)values( 'Natasha' , 'Kukreja' , 40 , 50, 60);
insert into student1 (firstname,lastname,English,Maths,Science)values( 'Shreyash' , 'sormare' , 50 , 70, 90);
insert into student1 (firstname,lastname,English,Maths,Science)values( 'Akash' , 'Narwade' , 40 , 10, 20);

update student1 set lastname='sharma' where id=1;
update student1 set lastname='Kohli' where id=3;
update student1 set English=30 where id=4;
update student1 set firstname='Prerna' where id=5;
update student1 set Maths=10 where id=8;
update student1 set Science=25 where id=2;


select * from student1;
select * from student1 where lastname='sharma';            --By Running this command we get all the details  of the student row  whose surname is bhoyar.
select * from student1 where Science>40;                   -- By Running this command we get all the details of the student row whose marks is 40;
select firstname from student1 where lastname like '%a%' ;
select * from student1 where maths<40;
select * from student1 where Science=30;
select * from student1 where English>=10;
select id , firstname+ '  ' +lastname as "Full name" from student1;
select count(*) as 'Total Records' from student1;
select count(*) as 'Total Records' from student1 where Science<=40;
select max (Maths) as 'Max Maths Marks' from student1;
select max (Science) as 'Max Science Marks' from student1;
select max(English)as 'Max English Marks' from student1;

select min (Maths) as 'Min Maths Marks' from student1;
select min (Science) as 'Min Science Marks' from student1;
select min(English)as 'Min English Marks' from student1;
select firstname+ ' ' +lastname as 'FullName', Maths as 'Topper in Maths 'from  student1 where Maths = (Select max(Maths) from student1);
select firstname+ ' ' +lastname as 'FullName', English as 'Highest Marks in English 'from  student1 where English = (Select max(English) from student1);
select firstname+ ' ' +lastname as 'FullName', Science as 'Topper in Science 'from  student1 where Science = (Select max(Science) from student1);


select avg(Maths)as 'Avg Maths Marks' from student1;
select avg(Science)as 'Avg Science Marks' from student1;
select avg(English)as 'Avg English Marks' from student1;

select * from student1 where science<40 and Maths<40;













   
