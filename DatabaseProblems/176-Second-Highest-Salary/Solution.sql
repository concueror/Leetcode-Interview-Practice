-- Write your PostgreSQL query statement below
select (
    select SecondHighestSalary from (
        select distinct salary SecondHighestSalary from Employee
        order by salary desc
    )
    limit 1 offset 1 ) as SecondHighestSalary