--Joins:(AdventureWorks)
USE AdventureWorks2019
GO

--1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the
--following.	
--     Country                        Province
SELECT pc.Name AS Country, ps.Name AS Province
FROM person.CountryRegion AS pc
JOIN person.StateProvince AS ps ON pc.CountryRegionCode = ps.CountryRegionCode
ORDER BY pc.Name;


--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables 
-- and list the countries filter them by Germany and Canada.
--Join them and produce a result set similar to the following.
--    Country                        Province
SELECT pc.Name AS Country, ps.Name AS Province
FROM person.CountryRegion AS pc
JOIN person.StateProvince AS ps ON pc.CountryRegionCode = ps.CountryRegionCode
WHERE pc.Name IN ('Germany','Canada')
ORDER BY pc.Name;


-- Using Northwind Database: (Use aliases for all the Joins)
USE Northwind
GO
--3. List all Products that has been sold at least once in last 25 years. It is 2022-5-19 now. 1997-5-19
SELECT p.ProductName, MAX(o.OrderDate) AS LastSold
FROM Orders AS o
JOIN [Order Details] AS od ON o.OrderID = od.OrderID JOIN Products AS p ON od.ProductID = p.ProductID
GROUP BY p.ProductName
HAVING MAX(o.OrderDate) > '1997-05-19'
ORDER BY p.ProductName;


--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT top 5 o.ShipPostalCode, SUM(od.Quantity) AS ProductsNumbers
FROM Orders AS o
JOIN [Order Details] od ON o.OrderID =  od.OrderID
WHERE o.ShipPostalCode IS NOT NULL  AND DATEDIFF(year, o.OrderDate, GETDATE())< 25
GROUP BY o.ShipPostalCode
ORDER BY ProductsNumbers DESC


--5. List all city names and number of customers in that city.
SELECT c.City, COUNT (c.CustomerID) AS CustomerNumbers
FROM Customers AS c
GROUP BY c.City


--6. List city names which have more than 2 customers, and number of customers in that city
SELECT c.City, COUNT (c.CustomerID) AS CustomerNumbers
FROM Customers AS c
GROUP BY c.City
HAVING COUNT (c.CustomerID)> 2
ORDER BY CustomerNumbers DESC;


--7. Display the names of all customers  along with the  count of products they bought
SELECT c.CompanyName, SUM (od.Quantity) AS ProductsNumbers
FROM Customers AS c
LEFT JOIN Orders AS o ON o.CustomerID = c.CustomerID 
LEFT JOIN [Order Details] AS od ON od.OrderID = o.OrderID
GROUP BY c.CompanyName
ORDER BY ProductsNumbers;

 
--8. Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CompanyName, SUM (od.Quantity) AS CustomerNumbers
FROM Customers AS c
JOIN Orders AS o ON o.CustomerID = c.CustomerID JOIN [Order Details] AS od ON od.OrderID = o.OrderID
GROUP BY c.CompanyName
HAVING SUM (od.Quantity) > 100
ORDER BY SUM (od.Quantity) DESC;


--9. List all of the possible ways that suppliers can ship their products. Display the results as below
--   Supplier Company Name                Shipping Company Name
SELECT DISTINCT su.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
FROM Suppliers AS su
JOIN Products AS p ON su.SupplierID = p.SupplierID
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
JOIN Shippers AS sh ON sh.ShipperID = o.ShipVia
ORDER BY su.CompanyName;

SELECT sup.CompanyName, ship.CompanyName FROM Suppliers sup CROSS JOIN Shippers ship Order By 2, 1


--10. Display the products order each day. Show Order date and Product Name.
SELECT distinct o.OrderDate, p.ProductName
FROM Orders AS o
JOIN [Order Details] AS od ON od.OrderID = o.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
--solution
--GROUP BY o.OrderDate,p.ProductName
ORDER BY o.OrderDate;

--11. Displays pairs of employees who have the same job title.
SELECT e.Title, e.FirstName+' '+e.LastName AS Employee
FROM Employees e
ORDER BY e.Title


--12. Display all the Managers who have more than 2 employees reporting to them.
SELECT COUNT(e.EmployeeID) AS EmployeeNum, m.FirstName+' '+m.LastName AS Manager
FROM Employees e
JOIN Employees m ON e.ReportsTo = m.EmployeeID
Group by m.FirstName+' '+m.LastName
HAVING COUNT(e.EmployeeID) > 2


--13. Display the customers and suppliers by city. The results should have the following columns
--City
--Name
--Contact Name,
--Type (Customer or Supplier)
SELECT c.City, c.CompanyName AS Name, c.ContactName, 'Customer' AS Type
FROM Customers c
UNION ALL
SELECT su.City, su.CompanyName AS Name, su.ContactName, 'Supplier' AS Type
FROM Suppliers su

--All scenarios are based on Database NORTHWIND.
--14. List all cities that have both Employees and Customers.
SELECT c.City
FROM Customers c
UNION 
SELECT e.City
FROM Employees e
--solution
select distinct city from Customers where city in (select city from Employees)
--15. List all cities that have Customers but no Employee.
--a.Use sub-query
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN
(
    SELECT DISTINCT City
    FROM Employees
);

--b.Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e ON e.City = c.City
WHERE e.City IS NULL


--16. List all products and their total order quantities throughout all orders.
SELECT p.ProductID, SUM(od.Quantity) AS TotalQuatity
FROM Products p
JOIN [Order Details] od ON od.ProductID = p.ProductID
JOIN Orders o ON o.OrderID = od.OrderID
GROUP BY p.ProductID
ORDER BY SUM(od.Quantity) DESC

--solution
select ProductID,SUM(Quantity) as QunatityOrdered from [order details] 
group by ProductID
ORDER BY SUM(Quantity) DESC


--17. List all Customer Cities that have at least two customers.
--a.Use union
select city 
from Customers 
except 
select city from customers group by city 
having COUNT(*)=1 
union  
select city from customers group by city 
having COUNT(*)=0

SELECT  c.City, COUNT (c.CustomerID) AS CustomerNumber
FROM Customers c
GROUP BY c.City
HAVING COUNT (c.CustomerID) >= 2
ORDER BY COUNT (c.CustomerID) DESC

--b.Use sub-query and no union
--solution
select city from customers 
group by city 
having COUNT(*)>=2


--18. List all Customer Cities that have ordered at least two different kinds of products.
--solution
select distinct city from orders o join [order details] od on o.orderid=od.orderid join customers c on c.customerid=o.CustomerID group by city having COUNT(*)>=2
ORDER BY c.City


--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
--solution
select top 5 
ProductID,
    AVG(UnitPrice) as AvgPrice,
    (select top 1 City 
    from Customers c 
    join Orders o on o.CustomerID=c.CustomerID 
    join [Order Details] od2 on od2.OrderID=o.OrderID 
    where od2.ProductID=od1.ProductID 
    group by city 
    order by SUM(Quantity) desc) as City 
from [Order Details] od1 
group by ProductID  
order by sum(Quantity) desc



--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
--from. (tip: join  sub-query)
select 
(select top 1 City 
from Orders o 
join [Order Details] od on o.OrderID=od.OrderID 
join Employees e on e.EmployeeID = o.EmployeeID 
group by e.EmployeeID,e.City 
order by COUNT(*) desc) as MostOrderedCity, 
(select top 1 City 
from Orders o 
join [Order Details] od on o.OrderID=od.OrderID 
join Employees e on e.EmployeeID = o.EmployeeID 
group by e.EmployeeID,e.City 
order by sum(Quantity) desc) as MostQunatitySoldCity


--21. How do you remove the duplicates record of a table?

--use Row_Number() with partition by 
--then delete the rows where rowNumber > 1 with Group by
USE Northwind
GO
SELECT OrderID, ROW_NUMBER() OVER (Partition by OrderID ORDER BY OrderID) AS Row_Number
from [Order Details]
GROUP BY OrderID
