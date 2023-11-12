create table Roles(
RoleID int primary key,
RoleName nvarchar(100))

create table Users(
UserID int primary key,
UserSurname nvarchar(100),
UserName nvarchar(100),
UserPatronymic nvarchar(100),
UserLogin nvarchar(max),
UserPassword nvarchar(max),
UserRole int foreign key references Roles(RoleID))

create table PickupPoints(
PointID int primary key,
PointPostIndex int,
PointCity nvarchar(100),
PointStreet nvarchar(100),
PointStreetNumber int)

create table Orders(
OrderID int primary key,
OrderDate datetime,
OrderDeliveryDate datetime,
OrderPickupPoint int foreign key references PickupPoints(PointID),
OrderClient int foreign key references Users(UserID),
OrderCode int,
OrderStatus nvarchar(max))

create table Products(
ProductID int primary key,
ProductArticleNumber nvarchar(100),
ProductName nvarchar(max),
ProductUnit nvarchar(10),
ProductCost int,
ProductMaxDiscount int,
ProductManufacturer nvarchar(max),
ProductProvider nvarchar(max),
ProductCategory nvarchar(max),
ProductDiscountAmount int,
ProductQuantityInStock int,
ProductDescription nvarchar(max),
ProductPhoto nvarchar(max))

create table OrdersProducts(
OrdersProductsID int primary key,
OrderID int foreign key references Orders(OrderID),
ProductID int foreign key references Products(ProductID),
OrdersProductsCount int)
