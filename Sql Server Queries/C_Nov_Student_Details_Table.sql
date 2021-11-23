/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [cat_id]
      ,[cat_name]
  FROM [myDB].[dbo].[category]
