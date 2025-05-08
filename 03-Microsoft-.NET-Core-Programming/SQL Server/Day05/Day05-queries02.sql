use AdventureWorks2012;

-- 1
select SalesOrderID , ShipDate
from Sales.SalesOrderHeader
where ShipDate between '7/28/2002' and '7/29/2014';

-- 2
select 
    productid,
    name
from production.product
where standardcost < 110.00;

-- 3
select productid, name
from production.product
where weight is null;

-- 4
select productid, name, color
from production.product
where color in ('silver', 'black', 'red');

-- 5
select productid, name
from production.product
where name like 'b%';

-- 6
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select productdescriptionid, description
from production.productdescription
where description like '%[_]%';

-- 7 
select orderdate, sum(totaldue) as [total]
from sales.salesorderheader
where orderdate between '2001-07-01' and '2014-07-31'
group by orderdate

-- 8
select distinct hiredate
from humanresources.employee;

--9 
select avg(distinct listprice) as [Unique avg]
from production.product
where listprice > 0;

-- 10
select
    'The ' + name + ' is only! ' + cast(listprice as varchar) as [Message]
from production.product
where
    listprice between 100 and 120
    and listprice is not null
order by listprice;

-- 11
-- a
select rowguid,name,salespersonid,demographics
into store_archive
from sales.store;

-- b
select rowguid, name, salespersonid, demographics
into store_archive_empty
from sales.store
where 1 = 2; 

-- 12
select format(getdate(), 'dd/mm/yyyy') as [today's date]
union all
select format(getdate(), 'mm-dd-yyyy')
union all
select format(getdate(), 'yyyy-mm-dd')
union all
select format(getdate(), 'dd mmm yyyy')
union all 
select format(getdate(), 'yyyy-MM-dd HH:mm:ss.fff')





