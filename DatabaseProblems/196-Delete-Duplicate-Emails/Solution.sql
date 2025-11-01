-- Write your PostgreSQL query statement below
    
-- Delete from Person p
--    using Person p2
-- Where p.email = p2.email and p.Id > p2.id

-- statement for SQLite
DELETE FROM Person
WHERE Id IN (
    SELECT p.Id
    FROM Person p
             INNER JOIN Person p2 ON p.email = p2.email
    WHERE p.Id > p2.Id
);
