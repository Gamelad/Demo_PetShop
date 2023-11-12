select*from Users
select*from Products
select*from Products where ProductManufacturer like '%Triol%'

alter proc sp_FilterAndSortProducts
@selectedFilter nvarchar(50),@selectedSort nvarchar(50)
as
begin
select*from Products
where ProductManufacturer like '%' + @selectedFilter + '%'
order by ProductCost @selectedSort
end

execute sp_FilterAndSortProducts 'Triol'