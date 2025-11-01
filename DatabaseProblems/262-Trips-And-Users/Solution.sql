-- Write your PostgreSQL query statement below
-- select request_at as "Day", case when rate is not null then round(rate ::decimal, 2) else 0 end as "Cancellation Rate"
-- from (
--          select tc.request_at,
--                 (SUM(CASE WHEN tc.status = 'cancelled_by_driver' or tc.status = 'cancelled_by_client' THEN 1 END)::float / count(*)) as rate
--          from
--              (
--                  select t1.*, u1.banned clientBanned from Trips t1
--                                                               join Users u1
--                                                                    ON u1.users_id = t1.client_id
--                  where
--                      t1.request_at >= '2013-10-01' and
--                      t1.request_at <= '2013-10-03'
--              ) tc
--                  join
--              (
--                  select t2.*, u2.banned driverBanned from Trips t2
--                                                               join Users u2
--                                                                    ON u2.users_id = t2.driver_id
--                  where
--                      t2.request_at >= '2013-10-01' and
--                      t2.request_at <= '2013-10-03'
--              ) td
--              ON tc.id = td.id
--          where tc.clientBanned = 'No' and td.driverBanned = 'No'
--          group by tc.request_at
--      ) as tt;

-- SQLite query statement below
select request_at as "Day",
       case when rate is not null then round(rate, 2) else 0 end as "Cancellation Rate"
from (
         select tc.request_at,
                (CAST(SUM(CASE WHEN tc.status = 'cancelled_by_driver' or tc.status = 'cancelled_by_client' THEN 1 END) AS REAL) / count(*)) as rate
         from
             (
                 select t1.*, u1.banned clientBanned from Trips t1
                                                              join Users u1
                                                                   ON u1.users_id = t1.client_id
                 where
                     t1.request_at >= '2013-10-01' and
                     t1.request_at <= '2013-10-03'
             ) tc
                 join
             (
                 select t2.*, u2.banned driverBanned from Trips t2
                                                              join Users u2
                                                                   ON u2.users_id = t2.driver_id
                 where
                     t2.request_at >= '2013-10-01' and
                     t2.request_at <= '2013-10-03'
             ) td
             ON tc.id = td.id
         where tc.clientBanned = 'No' and td.driverBanned = 'No'
         group by tc.request_at
     ) as tt;