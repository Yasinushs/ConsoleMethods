use NorthwindDB

--?--en çok sipariş veren 10 müşterinin hangi kategorilerde kaç ürün sipariş verdiğini hesaplayınız?

select top 10
CustomerID,COUNT(OrderID) as Sayı
from Orders
group by CustomerID
order by Sayı desc
--

select top 10
Orders.CustomerID ,ContactName,
CategoryName,
sum (Quantity) as SiparisSayisi
from  Customers
inner join Orders on Orders.CustomerID=Customers.CustomerID
inner join [Order Details] on Orders.OrderID=[Order Details].OrderID
inner join Products on Products.ProductID=[Order Details].ProductID
inner join Categories on Products.CategoryID=Categories.CategoryID
group by ContactName,CategoryName,Orders.CustomerID
order by SiparisSayisi desc
--Hatalı çözüm, doğrusu aşağıdaki gibi olacak

--

select 
Orders.CustomerID ,Customers.ContactName,
CategoryName,
sum (Quantity) as SiparisSayisi
from
(
select top 10
CustomerID,COUNT(OrderID) as Sayı
from Orders
group by CustomerID
order by Sayı desc
) as snlTable
inner join Customers on Customers.CustomerID=snlTable.CustomerID
inner join Orders on Orders.CustomerID=snlTable.CustomerID
inner join [Order Details] on Orders.OrderID=[Order Details].OrderID
inner join Products on Products.ProductID=[Order Details].ProductID
inner join Categories on Products.CategoryID=Categories.CategoryID
group by ContactName,CategoryName,Orders.CustomerID
order by ContactName,SiparisSayisi