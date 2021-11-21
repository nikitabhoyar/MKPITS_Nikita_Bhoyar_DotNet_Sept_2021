

use myDB
create procedure MyCollege
(@salary decimal)
as
begin
select * from employee1 where salary=@salary
end
go
