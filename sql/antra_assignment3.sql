--Use Northwind database. All questions are based on assumptions described by the Database Diagram sent to you yesterday. When inserting, make up info if necessary. Write query for each step. Do not use IDE. BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE.
USE Northwind
GO
--1.      Create a view named "view_product_order_[your_last_name]", list all products and total ordered quantity for that product.
CREATE VIEW view_product_order_Lin
AS
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) AS [Total Ordered Quantity]
FROM Products p
JOIN [Order Details] od ON od.ProductID = p.ProductID
GROUP BY p.ProductID, p.ProductName

SELECT * FROM view_product_order_Lin

--2.      Create a stored procedure "sp_product_order_quantity_[your_last_name]" that accept product id as an input and total quantities of order as output parameter.
CREATE PROC sp_product_order_quantity_Lin
@inputProductID INT
AS
BEGIN
    SELECT SUM(Quantity) AS [Total Ordered Quantity]
    FROM [Order Details]
    GROUP BY ProductID
    HAVING ProductID = @inputProductID
END

EXEC sp_product_order_quantity_Lin 1


--3.      Create a stored procedure "sp_product_order_city_[your_last_name]" that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
CREATE PROC sp_product_order_city_Lin
@inputProductName VARCHAR(20)
AS
BEGIN
    SELECT TOP 5 dt.City
    FROM(SELECT c.City, SUM(od.Quantity) AS ProductsNumbers
        FROM Customers c
        JOIN Orders o ON c.CustomerID = o.CustomerID
        JOIN [Order Details] od ON od.OrderID = o.OrderID
        JOIN Products p ON p.ProductID = od.ProductID
        WHERE p.ProductName = @inputProductName
        GROUP BY c.City
    ) AS dt
    ORDER BY dt.ProductsNumbers DESC
END

EXEC sp_product_order_city_Lin 'Geitost'


--4.      Create 2 new tables "people_your_last_name" "city_your_last_name". City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. Remove city of Seattle. If there was anyone from Seattle, put them into a new city "Madison". Create a view "Packers_your_name" lists all people from Green Bay. If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
CREATE TABLE city_Lin(
Id int,
City varchar(20)
);
INSERT INTO city_Lin VALUES (1, 'Seattle'), (2, 'Green Bay');
CREATE TABLE people_Lin(
Id int,
Name varchar(20),
City int
);
INSERT INTO people_Lin VALUES (1, 'Aaron Rodgers', 2), (2, 'Russell Wilson', 1), (3, 'Jody Nelson',2);

INSERT INTO city_Lin VALUES (3, 'Madison');
UPDATE people_Lin
SET City= '3'
WHERE City ='1'
DELETE city_Lin WHERE Id='1'

SELECT * FROM city_Lin;
SELECT * FROM people_Lin;

CREATE VIEW Packers_GaomingLin
AS
SELECT dt.Name
FROM
    (
        SELECT p.Id, p.Name, c.City
        FROM people_Lin p
        JOIN city_Lin c ON c.Id = p.City
    ) AS dt
WHERE dt.City = 'Green Bay'
SELECT * FROM Packers_GaomingLin

DROP TABLE city_Lin, people_Lin;
DROP VIEW Packers_GaomingLin;


--5.       Create a stored procedure "sp_birthday_employees_[you_last_name]" that creates a new table "birthday_employees_your_last_name" and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.
CREATE PROC sp_birthday_employees_Lin
AS
BEGIN
    CREATE TABLE birthday_employees_Lin(
        Id int,
        Name varchar(45),
        BirthDate DATETIME
    )
    INSERT INTO birthday_employees_Lin (Id, Name, BirthDate)
    SELECT EmployeeID, FirstName+' '+LastName, BirthDate
    FROM Employees
    WHERE MONTH(Employees.BirthDate) = 2 
END

EXEC sp_birthday_employees_Lin;

SELECT * FROM birthday_employees_Lin;
DROP TABLE birthday_employees_Lin;


--6.  How do you make sure two tables have the same data?
SELECT * FROM Table_1
EXCEPT
SELECT * FROM Table_2