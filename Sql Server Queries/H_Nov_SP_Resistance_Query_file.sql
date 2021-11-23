

create procedure SPFindResistance 
                 @current int,
				 @voltage int,
				 @resistance int output 

as 
begin 
select @current = 0 ;
select @voltage =7;
end 
begin 
select @resistance = @voltage*@current;
end 

declare @r int
execute  SPFindResistance
@voltage = 5,
@current = 0,
@resistance = @r output;
select @r
