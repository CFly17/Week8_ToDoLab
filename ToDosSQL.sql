
-- CREATE DATABASE ToDo; 
-- CREATE table Employee(
-- 	Id int Primary Key auto_increment not null, 
--     `Name` nvarchar(30),
--     HoursAvailible float, 
--     Title nvarchar(40)
-- );
-- ​
-- CREATE TABLE ToDos(
-- 	Id int Primary Key auto_increment not null, 
--     AssignedTo int,
-- 	`Name` nvarchar(30),
-- 	`Description` nvarchar(100),
--     HoursNeeded float,
--     IsCompleted bool, 
--     foreign key (AssignedTo) references employee(Id)
-- );

-- this is a many to many table 
-- with many to many all tasks may be tackled by any number employees and vice versa 
-- one to many, one task has many employee, but each employee may have only 1 task 
-- CREATE TABLE Assignments(
-- 	Id int Primary Key auto_increment not null, 
--     EmployeeId int, 
--     ToDoId int,
--     foreign key (EmployeeId) References Employee(Id),
--     foreign key (todoID) references todos(Id));

-- insert into todos
-- values (0, '2', 'Clean schoolroom', 'Use iso spray to clean student boogers from desks', 2, false), 
-- (0, '1', 'Finish ToDo lab', 'go back 35 days to research MySQL tables and linking them to VS functions', 5, false), 
-- (0, '4', 'Restore Detroit power', 'Use iso spray to clean student boogers from desks', 20, true);

select * from employee;
