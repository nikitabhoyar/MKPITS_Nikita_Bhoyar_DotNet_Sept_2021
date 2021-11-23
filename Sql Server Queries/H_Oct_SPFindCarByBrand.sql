  CREATE PROCEDURE SPFindCarByBrand
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
