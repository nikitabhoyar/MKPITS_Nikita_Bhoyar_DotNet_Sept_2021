


select 1 + '7' AS result ; ---	Implicit conversion--
select 1 + '8' AS output ;
select 1 + '10'  Result ;


select 1 + CAST ('10' AS INT ) result ; --Explicit Conversion---
select 100 + CAST ('abc50' as int) result ; -- cannot convert explicitly also beacause it is not pure number (abc50)

select CAST(5.95 as int ) result ; --float into int ;
select CAST ('3.13945' as dec(10,2) ) result ; --string to decimal --
select CAST ('1/11/2021' as smalldatetime) result ;--string to date--


select convert (int,9,95) result; --float to int--
select convert (money,9) result;--int to money --

select convert (datetime,'01/11/2021') result;  --string to datetime--
select convert (smalldatetime,'02/13/2020') result --string to smalldatetime--

select convert (varchar(13), '2020-01-20 00:00:00.000') result
select convert (varchar(13),getdate()) result --current date to varchar--

---display name (Uppercase)total marks and average of each student from student table
  ---using convert function  from for average marks--

-- display 
 select 