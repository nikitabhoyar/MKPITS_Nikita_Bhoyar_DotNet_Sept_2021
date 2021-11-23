

use myDB;
create procedure SPupdateMarks(@id int, @eng int , @math int , @sci int )
as
begin
update  student set Maths = @math , English = @eng , Science = @sci where id = @id;
end


select * from student;

execute  SPupdateMarks 24,20,30,40
execute SPupdateMarks 23,40,50,60