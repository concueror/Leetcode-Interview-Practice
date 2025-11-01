-- Write your PostgreSQL query statement below
select z.Customer Customers from (
select c.name Customer, o.customerId from Customers c 
left join Orders o
on c.id = o.customerId) z
where z.customerId is null
