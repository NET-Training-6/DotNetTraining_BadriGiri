--create table Employee(Name varchar(100),
--ID int primary key,
--BOD date,
--Gender char,
--Contact varchar(40)
--);

--select * from Employee
--insert into Employee(Name,ID,BOD,Gender,Contact) values ('Badri raj Aran', 12, '1999-11-15', 'M','98654147869');

--SELECT * FROM Employee
--insert into Employee(Name,ID,BOD,Gender,Contact) values ('Swoostika Kayastha', 1, '2001-11-15', 'M','98487569');

update Employee set Gender='F' where ID=1;

SELECT * FROM Employee