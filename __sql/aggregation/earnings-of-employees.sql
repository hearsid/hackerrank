select months * salary as t, count(*) from Employee group by 1 order by t desc limit 1
