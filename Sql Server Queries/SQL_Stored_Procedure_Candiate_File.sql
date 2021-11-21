


--create procedure SPGetstudent
--(@firstname  varchar(10))--

--as
--begin
--select * from student where  firstname=@firstname;--
--end 
--go--

--execute SPGetstudent nikita--



create procedure Candiate
(@salary decimal)
as 
begin
select * from employee1 where salary=@salary
select * from employee1 where salary<@salary
end 
go 


execute Candiate 2500