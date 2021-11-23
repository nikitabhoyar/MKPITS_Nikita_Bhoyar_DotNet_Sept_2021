

use myDB;
SET QUOTED_IDENTIFIER On
select "firstname"  from "student1" where id<10;
---when it is on column name , sp name , table name view name can be used as quated identifier--

SET QUOTED_IDENTIFIER OFF
select "fistname" from "student1" where id<5;
---when it is off it is not treated as identifier--

SET NOCOUNT OFF 
SELECT * FROM STUDENT1 where id<>null;
select * from student1;