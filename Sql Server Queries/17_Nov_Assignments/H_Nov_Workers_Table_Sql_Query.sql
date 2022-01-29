


use myDB;
create table workers(Id int primary key identity(110, 1), WorkerId varchar(7) unique , Worker_Name varchar(30)not null , Wages decimal(10,2) check (Wages in(200 , 600 , 1000 )) , Permanent bit , DOJ date);
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W101','Nikita',200,1,'1/02/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W102','Nikhil',600,2,'3/02/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W103','Arjun',200,0,'4/02/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W104','Pushpa',1000,1,'5/02/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W105','Rani',200,3,'6/02/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W106','Daizy',600,4,'7/02/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W107','Prachi',1000,5,'1/03/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W108','Anmol',200,6,'1/04/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W109','Zhakhir',600,1,'1/02/2022');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W1010','Aman',1000,0,'7/04/2021');
insert into workers(WorkerId,Worker_Name,Wages,Permanent,DOJ)values('W1011','Nilesh',200,1,'5/03/2022');

select * from workers where DOJ  between '2021-02-7' and '2022-03-5'; 

select * from workers where permanent=1;

select * from workers where permanent=0;

select distinct DOJ as 'Date of Joining' from workers;

select Worker_Name,DOj from workers where DOJ not between '2021-05-1' and '2021-03-1';

select Worker_Name,DOJ from workers where DOj in('7-03-21','1-04-2021'); 

select * from workers where DOJ<'2021-10-18';

select * from workers where year(DOJ)<2021; 

select * from workers where year(DOJ)>2018;   

select * from workers where month(DOJ)=5; 

select * from workers;


  


