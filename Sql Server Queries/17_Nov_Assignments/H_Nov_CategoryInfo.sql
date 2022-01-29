

use CodeFirstDB;

create table categoryinfo (Id int primary key  identity (10,1), catname  varchar(20) unique check (catname in ('Soap','Shampoo','detergent','oil','handwash', 'grain','biscuit', 'edible oil'))); 

select * from categoryinfo;

insert into categoryinfo (catname)values('Soap');
insert into categoryinfo (catname)values('Shampoo');
insert into categoryinfo (catname)values('detergent');
insert into categoryinfo (catname)values('oil');
insert into categoryinfo (catname)values('handwash');
insert into categoryinfo (catname)values('oil');
insert into categoryinfo (catname)values('edible oil');
