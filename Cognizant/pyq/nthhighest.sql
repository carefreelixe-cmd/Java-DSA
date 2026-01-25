-- second highest salary

select 
    distinct Salary as SecondHighestSalary
    from employee
    order by salary desc
    limit 1 offset 1;

    (this will skip n-1 row)

    if n=3
    then offset 2


    //chnge size of a name colum from varchar 50 to 100
    alter table employee
    modify name varchar(100);

    Example 2: Replace NULL values

Table: Employees

id	name	salary
1	Ram	50000
2	Sam	NULL
SELECT name, COALESCE(salary, 0) AS salary
FROM Employees;


✅ Output:

Ram   50000
Sam   0

🔹 Example 3: COALESCE with multiple columns
SELECT COALESCE(phone, email, 'No Contact') AS contact
FROM Customers;


👉 If phone is NULL → it checks email
👉 If both are NULL → returns "No Contact"

select name,coalesce(salary,0)as salary;
SELECT SUBSTRING_INDEX(full_name, ' ', -1) AS last_name
FROM employees;
