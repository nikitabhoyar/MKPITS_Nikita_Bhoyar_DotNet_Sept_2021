/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[emp_fname]
      ,[emp_lname]
      ,[emp_city]
      ,[emp_branch]
      ,[emp_salary]
  FROM [myDB].[dbo].[Employee]