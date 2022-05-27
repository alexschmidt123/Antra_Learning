-- 1. What is index; types of indexes; pros and cons
--There are two types of Indexes in SQL Server:1> Clustered Index; 2> Non-Clustered Index 
--Clustered indexes are indexes whose order of the rows in the data pages corresponds to the order of the rows in the index. This order is why only one clustered index can exist in any table, whereas, many non-clustered indexes can exist in the table.


-- 2. What's the difference between Primary key and Unique constraint?
--Primary key's purpose is to uniquely identify a row in a table. Unique constraint ensures that a field's value is unique among the rows in table. You can have only one primary key per table. You can have more than one unique constraint per table.


-- 3. Tell me about check constraint
--The CHECK constraint is used to limit the value range that can be placed in a column
CREATE TABLE Persons (
    ID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int CHECK (Age>=18)
); 


-- 4. Difference between temp table and table variable
--A Temp table is easy to create and back up data. Table variable involves the effort when you usually create the normal tables. Temp table result can be used by multiple users. Table variable can be used by the current user only.


-- 5. Difference between WHERE and HAVING
--WHERE Clause is used to filter the records from the table based on the specified condition. HAVING Clause is used to filter record from the groups based on the specified condition.


-- 6. Difference between RANK() and DenseRank() — value gap
--ROW_NUMBER will always generate unique values without any gaps, even if there are ties. RANK can have gaps in its sequence and when values are the same, they get the same rank. DENSE_RANK also returns the same rank for ties, but doesn't have any gaps in the sequence.


-- 7. COUNT(*) vs. COUNT(colName)
--COUNT(*) will count all the rows in the table, including NULL values. On the other hand, COUNT(column name) will count all the rows in the specified column while excluding NULL values.


-- 8. What's the difference between left join and inner join? JOIN and Subquery, which one has a better performance, why?
--You'll use INNER JOIN when you want to return only records having pair on both sides, and you'll use LEFT JOIN when you need all records from the “left” table, no matter if they have pair in the “right” table or not.
--JOIN is much faster. The advantage of a join includes that it executes faster. The retrieval time of the query using joins almost always will be faster than that of a subquery. By using joins, you can maximize the calculation burden on the database i.e., instead of multiple queries using one join query.


-- 9. What is correlated subquery
--A correlated subquery is a subquery that refers to a column of a table that is not in its FROM clause. The column can be in the Projection clause or in the WHERE clause. In general, correlated subqueries diminish performance.


-- 10. What is a CTE, why do we need CTE?
--Chronic traumatic encephalopathy (CTE) is the term used to describe brain degeneration likely caused by repeated head traumas.


-- 11. What does SQL Profiler do?
--Microsoft SQL Server Profiler is a graphical user interface to SQL Trace for monitoring an instance of the Database Engine or Analysis Services.


-- 12. What is SQL injection, how to avoid SQL injection?
--SQL injection is a code injection technique that might destroy your database.
--how to avoid: 1> Prepared Statements ; 2> Stored Procedures


-- 13. Difference between SP and user defined function? When to use SP when to use function?
--SPs can change database objects. Inline User-Defined Functions can be treated like views with parameters and can be used in row set operations and JOINs. Cannot JOIN the output of a Stored procedure. UDF can be used in the SQL statements anywhere in the WHERE / HAVING / SELECT sections.


-- 14. Criteria of Union and Union all? Difference between UNION and UNION ALL
--UNION or UNION ALL have the same basic requirements of the data being combined: There must be the same number of columns retrieved in each SELECT statement to be combined. The columns retrieved must be in the same order in each SELECT statement. The columns retrieved must be of similar data types.
--UNION ALL keeps all of the records from each of the original data sets, UNION removes any duplicate records. UNION first performs a sorting operation and eliminates of the records that are duplicated across all columns before finally returning the combined data set.


-- 15. Steps you take to improve SQL Queries
--Avoid Multiple Joins in a Single Query.


-- 16. concurrency problem in transaction
--Concurrency problems occur when multiple transactions execute concurrently in an uncontrolled manner. Dirty Read Problem, Unrepeatable Read Problem, Lost Update Problem, Phantom read Problem are the concurrency problems in DBMS.


-- 17. what is deadlock, how to prevent
--a deadlock occurs when two (or more) processes lock the separate resource. Under these circumstances, each process cannot continue and begins to wait for others to release the resource.
--Access objects in the same order.


-- 18. what is normalization, 1NF - BCNF, benefits using normalization
--Normalization is the process to eliminate data redundancy and enhance data integrity in the table. Normalization also helps to organize the data in the database. It is a multi-step process that sets the data into tabular form and removes the duplicated data from the relational tables.


-- 19. what are the system defined databases?
--A database is an organized collection of structured information, or data, typically stored electronically in a computer system. A database is usually controlled by a database management system (DBMS).


-- 20. composite key
--In database design, a composite key is a candidate key that consists of two or more attributes (table columns) that together uniquely identify an entity occurrence (table row). A compound key is a composite key for which each attribute that makes up the key is a foreign key in its own right.


-- 21. candidate key
--A candidate key is a specific type of field in a relational database that can identify each unique record independently of any other data. 


-- 22. DDL vs. DML
--Data definition language (DDL): Allows creation objects in database with:
--Create, Alter, Drop
--Data Manipulation Language (DML): Allows query and modify the data:
--Select, Insert, Update, Delete.


-- 23. ACID property
--In the context of transaction processing, the acronym ACID refers to the four key properties of a transaction: atomicity, consistency, isolation, and durability. All changes to data are performed as if they are a single operation. That is, all the changes are performed, or none of them are.


-- 24. table scan vs. index scan
--index scan is faster than a table scan because they look at sorted data and query optimizers know when to stop and look for another range.


-- 25. Difference between Union and JOIN
--Union's combines the data into new Rows. The Output of JOIN is a new horizontal set of rows having same number of Rows but can have different number of Columns. The Output of UNION is a new vertical set of rows having same number of Columns but can have different number of Rows.