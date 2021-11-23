

Declare @mytable Table(WeekNumber int,
                       DateStarting smalldatetime)
Declare @n int = 0
Declare @firstweek smalldatetime = '11/01/2021'

---Loop Through week ---
while @n <= 4
begin 
insert into @mytable values (@n , DATEADD(wk,@n,@firstweek));
set @n = @n + 1
END

---Show Results--------
select  WeekNumber, Datestarting from @mytable
-----------------