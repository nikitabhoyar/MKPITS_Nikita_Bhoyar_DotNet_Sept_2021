

use myDB;
----Cursor Forward only-------

declare employeecursor cursor 
for select * from employee 
open employeecursor 
fetch next from employeecursor

fetch relative 2 from employeecursor 
close employeecursor;
deallocate employeecursor ;
------------------------------------


----
declare studentcursor cursor scroll   ---1)step
for select * from student
open studentcursor 
fetch next from studentcursor -----2)step 
fetch first from studentcursor 
fetch last from studentcursor
fetch prior from studentcursor


--------------------------------------

-- Following cursor is scrollable ---


declare Indiancarscursor cursor scroll 
for select * from IndianCars
open Indiancarscursor

fetch next from Indiancarscursor

fetch first from Indiancarscursor

fetch last from Indiancarscursor

fetch prior from Indiancarscursor

fetch relative -2 from  Indiancarscursor