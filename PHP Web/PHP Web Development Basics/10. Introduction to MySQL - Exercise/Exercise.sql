/* 01. Create Tables*/

create table minions (
	id int PRIMARY KEY,
	name int,
	age int,
	town_id int
);

create table towns(
	id int primary key,
	name varchar(50)
);

/* 02. Insert Records in Both Tables */

insert into `towns`(id, name)
values
	(1, 'Sofia'),
	(2, 'Plovdiv'),
	(3, 'Varna');

insert into `minions`(id, name, age, town_id)
values
	(1, 'Kevin', 22, 1),
	(2, 'Bob', 15, 3),
	(3, 'Steward', NULL, 2);

/* 03. Truncate Table Minions */

truncate minions;

/* 04. Drop All Tables */

drop table minions, towns;

/* 05. Create Table People */

create table people(
	id int unsigned auto_increment primary key,
	name varchar(200) not null,
	picture mediumblob,
	height float(7,2),
	weight float(7,2),
	gender enum('m', 'f') not null,
	birthdate date not null,
	biography text
);

insert into people(name, picture, height, weight, gender, birthdate, biography)
values
	('Petko', LOAD_FILE('D:/Pictures/01.jpg'), 1.8, 0.55, 'm', '1998-12-15', 'This is the first person'),
	('Ivan', LOAD_FILE('D:/Pictures/02.jpg'), 2, 0.5, 'm', '1997-05-12', 'This is the second person'),
	('Maria', LOAD_FILE('D:/Pictures/03.jpg'), 1.7, 0.45, 'f', '1996-11-12', 'This is the third person'),
	('Todor', LOAD_FILE('D:/Pictures/04.jpg'), 1.95, 0.65, 'm', '1996-01-16', 'This is the forth person'),
	('Denica', LOAD_FILE('D:/Pictures/05.jpg'), 1.75, 0.5, 'f', '1998-07-09', 'This is the fifth person');
	
/* 06. Create Table Users */

create table users (
	id bigint auto_increment primary key,
	username varchar(30) not null unique,
	password varchar(26) not null,
	profile_picture mediumblob,
	last_login_time datetime,
	is_deleted enum('true', 'false')
);

insert into users(username, password, profile_picture, last_login_time, is_deleted)
values
	('goshkata', 'gogo123', LOAD_FILE('D:/Pics/01.jpg'), '2018-10-02 18:42:56', 'false'),
	('ivo54', 'ivailo007', LOAD_FILE('D:/Pics/02.jpg'), '2018-09-30 10:31:06', 'false'),
	('geri19', 'catsarecool', LOAD_FILE('D:/Pics/03.jpg'), '2018-10-11 13:11:34', 'false'),
	('clemolino', '1qa2ws3ed', LOAD_FILE('D:/Pics/04.jpg'), '2017-08-04 15:08:21', 'true'),
	('todor40', '123pass456word', LOAD_FILE('D:/Pics/05.jpg'), '2018-05-02 02:45:10', 'false');
	
/* 07. Change Primary Key */

ALTER TABLE users DROP PRIMARY KEY ,
ADD PRIMARY KEY (id, username);

/* 08. Find All Information About Departments */

select * from departments
order by department_id

/* 09. Find all Department Names */ 

select name from departments
order by department_id

/* 10. Find Salary of Each Employee */

select first_name, last_name, salary from employees
order by employee_id

/* 11. Find Full Name of Each Employee */

select first_name, middle_name, last_name from employees
order by employee_id

/* 12. Find Email Address of Each Employee */

select concat(first_name, '.', last_name, '@softuni.bg') as full_email_address from employees
order by employee_id

/* 13. Find All Different Employee’s Salaries */

select distinct salary from employees
order by salary

/* 14. Find all Information About Employees */

select * from employees
where job_title = 'Sales Representative'
order by employee_id

/* 15. Find Names of All Employees by Salary in Range */ 

select first_name, last_name, job_title from employees
where salary between 20000 and 30000
order by employee_id

/* 16. Find Names of All Employees */

select concat(first_name, ' ', middle_name, ' ', last_name) as full_name from employees
where salary = 25000 or salary = 14000 or salary = 12500 or salary = 23600

/* 17. Find All Employees Without Manager */

select first_name, last_name from employees
where manager_id is null

/* 18. Find All Employees with Salary More Than */

select first_name, last_name, salary from employees
where salary > 50000
order by salary desc

/* 19. Find 5 Best Paid Employees */

select first_name, last_name from employees
order by salary desc
limit 5

/* 20. Find All Employees Except Marketing */

select first_name, last_name from employees
where department_id != 4

/* 21. Sort Employees Table */

select * from employees
order by salary desc, first_name, last_name desc, middle_name

/* 22. Distinct Job Titles */

select distinct job_title from employees
order by job_title

/* 23. Find First 10 Started Projects */

select * from projects
order by start_date, name
limit 10

/* 24. Last 7 Hired Employees */

select first_name, last_name, hire_date from employees
order by hire_date desc
limit 7

/* 25. Increase Salaries */

update employees 
set salary = salary * 1.12
where department_id = 1 or department_id = 2 or department_id = 4 or department_id = 11;

select salary from employees;

/* 26. All Mountain Peaks */

select peak_name from peaks
order by peak_name

/* 27. Biggest Countries by Population */

select country_name, population from countries
where continent_code = 'EU'
order by population desc, country_name
limit 30

/* 28. Countries and Currency (Euro / Not Euro) */

select country_name, country_code, if(countries.currency_code='EUR', 'Euro', 'Not Euro') as currency
from countries
order by country_name
