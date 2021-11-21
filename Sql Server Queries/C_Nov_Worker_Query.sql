

use myDB;
create table Worker1(Id int primary key identity(10,1),WorkerId varchar(7) unique , Workername varchar(30) not null,
Wages decimal(12,2) check (Wages in (200,600,1000)), permanent bit , DOJ Date );
drop table Worker1;
insert into Worker1(WorkerId,Workername,Wages,permanent,DOj )values('A001' , 'Piyush' , 500 ,0 ,'2021-11-14' );
