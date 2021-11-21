USE [myDB]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[myprocedure]

SELECT	'Return Value' = @return_value

GO
