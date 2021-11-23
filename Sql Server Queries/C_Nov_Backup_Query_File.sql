
declare @name varchar(30) -- database name --
declare @path varchar(256) ---path for backup files--
declare @fileName varchar(256) --filename for backup--
declare @fileDate varchar(20) ---used for filename--


set @path =  'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\Backup\'

select @fileName  = CONVERT(Varchar(20),GETDATE(),112)

declare db_cursor CURSOR FOR 
select name 
from master.dbo.sysdatabases
where name NOT IN ('master',' model', 'msdb', 'tempdb' )

open db_cursor
fetch next from db_cursor into @name

while @@fetch_status = 0
begin
      set @filename =  @path + @name + '_' +@fileDate + '.BAK'
	  BACKUP DATABASE @name To DISK = @filename

	  fetch next from db_cursor into @name
end

	  close db_cursor
	  deallocate db_cursor
