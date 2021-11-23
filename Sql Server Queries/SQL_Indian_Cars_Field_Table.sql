      /.

use myDB;
create table IndianCars(carid int primary key identity(1,13), carname varchar(20),
brand varchar(20) ,model varchar(10),price decimal(12,2), modelyear int);

insert into IndianCars(carname, brand,model,price,modelyear)values('Maruticar','Maruti' ,'Altok20' , 40000 , 10000);
insert into IndianCars(carname, brand,model,price,modelyear)values('Swift Dezire','Maruti',	'Swift',600000,2005);
insert into IndianCars(carname, brand,model,price,modelyear)values('Tata Indica','Tata','Indica',700000,2001);
insert into IndianCars(carname, brand,model,price,modelyear)values('Indicatata','tata','Indica',78000,1987);
insert into IndianCars(carname, brand,model,price,modelyear)values('Tiago 5','tata','tataTiago',908000,1989);
select count(*) as 'Total Records' from IndianCars;
select * from IndianCars;

---------------------------------------

create procedure SPIndianCarByBrand
(
    @brand varchar(20),          
    @car_count INT OUTPUT
) AS
BEGIN
    SELECT 
        carname,
        price
    FROM
        IndianCars
    WHERE
        brand= @brand;

    SELECT @car_count = @@ROWCOUNT;
END;

-------------------------------------

declare @count int;
execute SPIndianCarByBrand @brand='maruti',
                          @car_count =@count out;
	select @count as 'count of cars';


------------------------



create procedure SPIndianCarByYear
(
    @modelyear int,          
    @car_count INT OUTPUT
) AS
BEGIN
    SELECT 
        carname,
        price,
    FROM
        IndianCars
    WHERE
        modelyear= @modelyear;

    SELECT @car_count = @@ROWCOUNT;
END;

-------------------------

declare @count int;
execute SPIndianCarByYear @modelyear='2005',
                          @car_count =@count out;
	select @count as 'count of cars';

