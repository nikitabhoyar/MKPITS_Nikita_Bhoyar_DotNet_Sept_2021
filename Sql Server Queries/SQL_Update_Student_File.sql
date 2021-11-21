

create procedure SPupdateStudent
(
@english int,
@studid int
)
as 
begin
update student set English=@english where id=1;
end

exec SPupdateStudent 56,1