--group by
use NorthwindDB
select *from Products where CategoryID in (1,2) order by CategoryID

select CategoryID as 'Kategori ID'
, COUNT(ProductID) as 'Ürün Sayısı'
from Products
group by CategoryID
/*
Kural1- group by ile kolon yazılması zorunludur. 
=>Group by kendisiyle beraber yazılan kolon select ile from arasında yazılması raporlama açıısndan daha yorumlayıcıdır
Kural2-select ile from arasında yazılacak kolon group by ile yazılmalıdır
Kural3-group by için genelde bir fonksiyon yazılması daha yorumlayıcıdır
*/

select *from Categories
--iç içe select
--ANA SELECT için Product tablosu kullanılmış
select CategoryID as 'Kategori ID'
, 
--iç select içiin Category tablosu kullanılmış
(select CategoryName from Categories as c where c.CategoryID=p.CategoryID) as Kategori,
COUNT(ProductID) as 'Ürün Sayısı'
from Products as p
group by CategoryID
/*
iç içe select(Subquery)
Kural1- iç select tablosundaki bir kolon ile a an selecteki bir kolon mutlaka benzer olmalı
Kural2-iç select ile sadece bir kolon çağrılabilir
Kural3-iç select mutlaka ortak kolon Ana Kolon olmalı(Primary Key-PK)
*/
--Her bir personelin kaç siparişte görev aldığını hesaplayınız
select *from Orders order by  EmployeeID--830

select EmployeeID as PersonelID,
--iç select
(select FirstName from Employees as e where e.EmployeeID=o.EmployeeID ) as Personel
--iç select SON
,COUNT(OrderID) as 'Sipariş Sayısı'
from Orders as o
group by EmployeeID--9
order by [Sipariş Sayısı]
-- her bir müşterinin (Customer) kaç tane sipariş(Order) verdiğini hesaplayınız
--her bir üründen kaç tane satıldığımı hesaplayınız
--her bir siparişte kaç ürün olduğunu hesaplayınız








