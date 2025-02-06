--join
/*
birden fazla tablo işlemlerinde tabloları bağlamak için kullanılır
Id
*/

select *from Products
select *from Categories
select *from [Order Details]

select *from Products--79
select *from Categories--10
--inner join
select 
p.ProductName,c.CategoryName,'--------',*
from		Products	as p
inner join	Categories	as c  on c.CategoryID=p.CategoryID
order by c.CategoryName--77
--left join
select 
p.ProductName,c.CategoryName,'--------',*
from		Products	as p left join	Categories	as c  on c.CategoryID=p.CategoryID
order by c.CategoryName
--right  join
select 
p.ProductName,c.CategoryName,'--------',*
from		Products	as p right join	Categories	as c  on c.CategoryID=p.CategoryID
order by c.CategoryName--79
--full outer  join
select 
p.ProductName,c.CategoryName,'--------',*
from		Products	as p full outer join	Categories	as c  on c.CategoryID=p.CategoryID
order by c.CategoryName--81
--
select 
p.ProductID,c.CategoryID,p.ProductName,c.CategoryName,'--------',*
from		Products	as p cross  join	Categories	as c
order by c.CategoryID--10*79
----------------------------------------------------------------
--her biri ürünün kaç adet satıldğını, spariş tarihini, ürün adını, satılan ürün sayısı  getiren scripti kodlayınız
--her bir müşterinin aldığı ürün sayısını contactname, companyname,ürün sayısı şeklinde hesaplayan script
--her bir personelin hangi ürün kategorilerinde kaç ürün sattığını hesaplayınız
--en çok sipariş veren 10 müşterinin hangi kategorilerde kaç ürün sipariş verdiğini hesaplayınız
--her bir kategoride kaç müşteri sipariş vermiş hesaplayınız

