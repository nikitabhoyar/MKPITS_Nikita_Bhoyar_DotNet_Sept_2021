


my DB;

create table NikitaInfo(id int primary key identity(10,1) , Firstname varchar(10) , Lastname varchar(20) , age int);   --For creating a table--

insert into NikitaInfo values ('Nikita','Bhoyar' ,18);  ----for inserting data into it --
insert into NikitaInfo values ('Prachi','Shah' ,18);
insert into NikitaInfo values ('Suyash','Lokhande' ,18);
insert into NikitaInfo values ('Nikhil','Sharma' ,18);
insert into NikitaInfo values ('Rahul','Kanojia' ,18);

update NikitaInfo set age= 17 where Lastname='shah';    ---for updating the data into it--
update NikitaInfo set age= 10 where Lastname='Lokhande';
update NikitaInfo set age= 20 where Lastname='Sharma';
update NikitaInfo set age= 23 where Lastname='Kanojia';

delete from NikitaInfo where age = 23;          ---for deleting the entire row from the table--

drop table NikitaInfo;                 --for droping the entire object/Table  from the Database---

select * from NikitaInfo;           ---it is used to show the entire table information--

select count(*)as TotalRecords from NikitaInfo;  ---it is used for finding the total records--

alter table NikitaInfo add class varchar(20);  --it is used for adding column in a table or making changes in a table--

update  NikitaInfo set class = 'MTech' where age = 18;

update  NikitaInfo set class = 'Msc' where age = 17;
update  NikitaInfo set class = 'BE' where age = 10;
update  NikitaInfo set class = 'Bcom' where age = 20;
update  NikitaInfo set class = 'Bsc' where age = 23;
    

alter table NikitaInfo drop column class;        --Inthis we make changes in the table i.e we delete the class column --

select id , Firstname+ ' '+Lastname as 'FullName' from NikitaInfo;  --For getting the id and fullname info---

select * from NikitaInfo where age =17;
                     