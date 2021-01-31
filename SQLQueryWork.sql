
select ProductName as Products, sum( [Order Details].Quantity * [Order Details].UnitPrice ) as Profit
from Products inner join [Order Details] on [Order Details].ProductID = Products.ProductID 
group by ProductName
order by Profit;