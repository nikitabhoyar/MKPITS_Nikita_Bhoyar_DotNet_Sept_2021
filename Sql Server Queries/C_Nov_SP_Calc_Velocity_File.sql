

create procedure Calcvelocity
                 @distance float,
				 @time float,
				 @velocity float OUTPUT
AS

if(@time=0.00)
begin
select @time = 1;
SELECT @velocity = @distance;
end
begin
select @velocity = @distance / @time;
end

declare @v float 
execute Calcvelocity
@distance=100,
@time=5,
@velocity=@v output;
select @v

declare @v float
exec Calcvelocity 340,2,@v output;
select @v as 'Velocity'
