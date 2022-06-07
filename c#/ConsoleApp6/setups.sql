drop table Employee;
drop table Department;
CREATE  table Department (Id int primary key, DName varchar(20), Loc varchar(20));
CREATE  table Employee (Id int primary key, EName varchar(45), Age int, DeptId int foreign key references Department(Id));

insert into Department values (1,'IT','NYU');
insert into Department values (2,'HR','NJ');
insert into Department values (3,'SALE','BOSTON');
select * from Department;

insert into Employee values (1,'Lauren Smith',34,1);
insert into Employee values (2,'Alex Adam',45,2);
insert into Employee values (3,'Joseph Lihn',24,3);
select * from Employee;

