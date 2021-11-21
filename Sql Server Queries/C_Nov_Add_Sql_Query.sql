
 declare @a int =20,
         @b int =30;
 select  @a+@b as 'sum' ;

------------------------------
create procedure AddtwoNumbers
(
@p1 int , 
@p2 int  ,
@result int output 
) 

 as 
 begin 
 select @result = @p1 + @p2;
 end
 go 

-------------------------------

DECLARE	@result int ;
EXEC	AddtwoNumbers
		@p1 = 24,
		@p2 = 20,
		@result = @result OUTPUT

SELECT	@result as N'@Result'

SELECT	'Return Value' = @result;

