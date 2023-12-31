select product_name, year, price
from product p
inner join sales s
on p.product_id = s.product_id