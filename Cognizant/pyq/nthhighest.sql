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