/* 01. Records’ Count */

select count(*) as count from wizzard_deposits;

/* 02. Longest Magic Wand  */

select max(magic_wand_size) from wizzard_deposits;

/* 03. Longest Magic Wand per Deposit Groups */

select deposit_group, max(magic_wand_size)  as longest_magic_wand
from wizzard_deposits 
group by deposit_group
order by longest_magic_wand;

/* 04. Smallest Deposit Group per Magic Wand Size */

SELECT deposit_group FROM wizzard_deposits
GROUP BY deposit_group
ORDER BY AVG(magic_wand_size) 
limit 1

/* 05. Deposits Sum */

SELECT deposit_group, SUM(deposit_amount) as total_sum FROM wizzard_deposits
GROUP BY deposit_group
ORDER BY total_sum

/* 06. Appetizers Count */

select count(*) from products where category_id = 2 and price > 8;

/* 07. Menu Prices */

select category_id, 
    round(avg(price),2) as `Average Price`, 
    min(price) as `Cheapest Product`, 
    max(price) as `Most Expensive Product` 
from products 
group by category_id;

/* 08.	Employee Address */

select e.employee_id, e.job_title, e.address_id, a.address_text
     from employees as e
     inner join addresses as a on e.address_id=a.address_id
     order by e.address_id
     limit 5;

/* 09.	Employee Departments */

SELECT e.employee_id, e.first_name, e.salary, d.name
FROM employees as e
INNER JOIN departments AS d ON e.department_id=d.department_id
WHERE e.salary > 15000
ORDER BY e.department_id DESC
LIMIT 5;

/* 10.	Employees Without Project */

SELECT e.employee_id, e.first_name
FROM employees AS e
LEFT JOIN employees_projects AS p ON e.employee_id=p.employee_id
WHERE p.project_id IS NULL
ORDER BY e.employee_id DESC
LIMIT 3;

/* 


