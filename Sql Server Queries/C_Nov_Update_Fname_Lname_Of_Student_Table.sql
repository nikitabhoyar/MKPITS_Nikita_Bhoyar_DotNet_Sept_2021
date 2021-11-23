
use myDB;
 create procedure SPaddStudent
(
@fname varchar(20),
@lname varchar(20)
)
as 
begin
insert into student1(firstname,lastname)values(@fname,@lname);

end

select * from student1;