use myDB;
declare @a int = 25,
        @b int = 30;
		select @a-@b'sub';


create procedure SubTwoNumbers
(
  @p1 int ,
  @p2 int ,
  @result int Output
 )
 as 
begin
select @result =  @p1 - @p2;
end 
go

DECLARE	@result int ;
EXEC	SubtwoNumbers
		@p1 = 24,
		@p2 = 20,
		@result = @result OUTPUT

SELECT	@result as N'@Result'

SELECT	'Return Value' = @result;

