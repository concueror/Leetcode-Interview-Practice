-- Write your PostgreSQL query statement below

select d.name Department, e.name Employee, e.salary Salary
from Employee e
Join Department d
ON e.departmentId = d.Id
where e.salary IN (
    /** первые 3 ЗП в отделе **/
    select distinct e.salary from Employee e
    where e.departmentId = d.id
    order by e.salary desc
    Limit 3)
