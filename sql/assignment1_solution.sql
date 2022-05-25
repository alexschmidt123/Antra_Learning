USE AdventureWorks2019
GO
-- - 1 ---- 
select productid,Name,Color,ListPrice from [Production].[Product]

-- - 2 ----- 
select productid,Name,Color,ListPrice from [Production].[Product] where ListPrice <>0

-- - 3 -----
select productid,Name,Color,ListPrice from [Production].[Product]  where color is null

-- - 4 ----- 
select productid,Name,Color,ListPrice from [Production].[Product] where color is not null and ListPrice > 0

-- -- 5 ---- 
select Name+':'+color from production.Product where color is not null

-- - 6 ----- 
select 'NAME: '+ name+' -- COLOR: '+ color from production.product where color is not null

-- -- 7 ------- 
select productid,Name from [Production].[Product] where productid between 400 and 500

-- - 8 ------ 
select productid,Name,Color from [Production].[Product] where color in ('Black','Blue')

-- -- 9 ----- 
select productid,Name,Color,ListPrice from [Production].[Product] where name like 'S%' 

-- -- 10 ------ 
select Name,ListPrice from Production.Product where Name like 'S%' or Name like 'A%' 

-- - 11 ------ 
SELECT [Name], ListPrice  FROM Production.Product WHERE [Name] LIKE 'spo[^k]%' ORDER BY [Name]

-- -- 12 ------ 
select distinct ProductSubcategoryID ,Color from Production.Product where Color is not null and ProductSubcategoryID is not null order by ProductSubcategoryID,Color