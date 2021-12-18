
my Db;

create table Constraints(Id int primary key identity(11,1) , Firstname varchar(20)not null , Lastname varchar(20)  default('Kumar'));
insert into Constraints  (Firstname , Lastname ) values ('Nikita','Kale');

delete from Constraints where Lastname = 'Kale';

insert into Constraints (Firstname) values('Pushpa');

alter table Constraints add DateHired datetime;

update  Constraints set DateHired = getdate() where Lastname = 'Kumar';

select * from Constraints;