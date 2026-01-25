-- second highest salary

select 
    distinct Salary as SecondHighestSalary
    from employee
    order by salary desc
    limit 1 offset 1;

    (this will skip n-1 row)

    if n=3
    then offset 2