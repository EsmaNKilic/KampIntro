-- nereyi seçersen orayı çalıştırır, seçip çalıştır
--Select
--ANSII
Select ContacName Adi, CompanyName Sirketadi, City Sehir from Customers -- * kolonlar anlamına gelir

Select * from Customers where City = 'London'

-- case insensitive - büyük küçük duyarsız kafana göre yaz
Select * from Products where CategoryID = 1 or CategoryID = 3
Select * from Products where CategoryID = 1 and UnitPrice >= 10 -- <> 10 demek 10 dan farklı anlamındadır

select * from products order by CategoryID, ProductName -- neyi önce yazarsan sıralama ona göre olur

select * from products order by UnitPrice asc -- ascending artan demek 
select * from products order by UnitPrice desc -- descending azalan demek 

select * from products where CategoryID = 1 order by UnitPrice desc -- kategorisi 1 olan ve azalanları listele

select COUNT(*) from Products -- tüm satırları say demek, çalıştırınca tek bir kolon tek bir sayı gelmeli
select COUNT(*) from Products where CategoryID = 2 -- bu kategoride kaç satır var say demek
select COUNT(*), ProductName from Products -- BU KULLANIM YANLIŞ!! İSMİ VERİP SAY DİYEMEZSİN.

select categoryId, count(*) from Products group by CategoryID -- hangi kategoride kaç farklı ürün var demek
select categoryId, count(*) from Products group by CategoryID having count(*) < 10 -- ürün sayısı 10 dan az olan kategorileri listele
select categoryId, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10 -- önce where çalışır, fiyatı 20 den fazla olanları kategori id ye göre grupla sayısı 10 dan küçük olsun demek

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID -- on durumunda şartında demek 
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice > 10  
-- inner join sadece iki tabloda da eşleşenleri bir araya getirir, eşleşmeyen data varsa onu getirmez

--DTO Data Transformation object

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID -- left join solda olup sağda olmayanları da getir demek 
select * from Products p left join [Order Details] od on p.ProductID = od.ProductID inner join orders o on o.OrderID = od.OrderID --ikiden fazla tabloyu join etmek istersen
select * from Customers c left join orders o on c.CustomerID = o.CustomerID ---müşterilerde olup siparişlerde olmayanları da getir anlamına gelir
select * from Customers c left join orders o on c.CustomerID = o.CustomerID where o.CustomerID is null -- sistemimize kayıt olmuş ama hiç ürün almamışları bana getir ben onlara kampanya yapacağım demek, buradaki null siparişlerde gelmeyen datanız yani data yok demek
-- right join de left joinin tam tersi

