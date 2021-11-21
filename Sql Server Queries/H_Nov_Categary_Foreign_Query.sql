use myDB;
create table Categary(id int primary key identity(10,1),catname varchar(20) unique check(catname in ('Soap', 'Shampoo' , 'Detergent' ,'oil',
'Handwash', 'grains', 'biscuit' , 'pulses' , 'edible oil' )));

insert into Categary(catname)values('Soap');
insert into Categary(catname)values('Shampoo');
insert into Categary(catname)values('Detergent');
insert into Categary(catname)values('oil');
insert into Categary(catname)values('Handwash');
insert into Categary(catname)values('Grains');
insert into Categary(catname)values('Biscuit');
insert into Categary(catname)values('Pulses');
insert into Categary(catname)values('Edible Oil');
insert into Categary(catname)values('Soap');
insert into Categary (catname)values(null);
delete from categary where catname=Null;
select * from Categary order by id;

create table Products(id int primary key identity(10,1),productname varchar(20) , price decimal(10,2) check (price>0.0), mfd date ,
catId int foreign key references categary (Id));

insert into Products(productname,price,mfd,catid) values ('Lux',40,getdate(),10)
insert into Products(productname,price,mfd,catid) values ('Grains',40,'2021-11-21',15);
insert into Products(productname,price,mfd,catid) values ('pulses',60,'2021-11-15',17);
insert into Products(productname,price,mfd,catid) values ('Soap',40,'2021-11-11',10)
insert into Products(productname,price,mfd,catid) values ('Star',40,'2021-11-13',15);
insert into Products(productname,price,mfd,catid) values ('Nirma',40,'2021-11-17',18)
insert into Products(productname,price,mfd,catid) values ('Lifeboy',40,'2021-11-18',16);
insert into Products(productname,price,mfd,catid) values ('Godrej',40,'2021-11-12',13)
insert into Products(productname,price,mfd,catid) values ('Cynthol',40,'2021-11-19',10);
insert into Products(productname,price,mfd,catid) values ('Shampoo',125,'2021-11-1',11);
insert into Products(productname,price,mfd,catid) values ('Edible Oil',140,'2021-11-2',21);
insert into Products(productname,price,mfd,catid) values ('Parle Biscuit',10,'2021-11-23',20);
insert into Products(productname,price,mfd,catid) values ('Dettol Handwash',120,'2021-11-24',40);

select count(*) as 'Total Records of Products ' from Products;

select * from Products;
