USE [myDB]
GO
/****** Object:  StoredProcedure [dbo].[myprocedure]    Script Date: 19-11-2021 11:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[myprocedure] 
AS
begin 
       Select * from Employee;
	   select * from employee1 where salary=@salary

end 
