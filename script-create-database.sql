create database one_coffee; 

use one_coffee;


create table staff(
	Id varchar(64) primary key, -- Id nay khong phai la mã nhân viên --
	UserName VARCHAR(300) not null, -- bat buoc nhap --
	PassWord VARCHAR(300) not null,
	StaffCode VARCHAR(50) not null, -- Đây mới là mã nhân viên--
	Email VARCHAR(300),	
	CreatedByUserId VARCHAR(64) not null,	-- Đây là người tạo nhân viên-- 
	LastUpdatedByUserId VARCHAR(64) not null, -- Đây là người cập nhật thông tin nhân viên -- 
	CreatedDate datetime not null, -- Day la ngay tao nhân viên--
	LastUpdatedDate datetime not null, -- Ngay cap nhap nhan vien -- 
	IsDeleted tinyint(6),
	Status smallint(6), -- trang thai kich hoat hoac vo hieu tai khoan --
	key (CreatedByUserId), -- Khoa ngoai cung chinh la Id cua staff --
	key (LastUpdatedByUserId)  -- Khoa ngoai cung chinh la Id  cua staff--
	
);

create table customer(
	Id varchar(64) primary key,
	UserName VARCHAR(300) not null,
	FullName VARCHAR(300) not null,
	PassWord VARCHAR(300) not null,
	PhoneNumber VARCHAR(50) not null,
	DetailAddress VARCHAR(300) ,
	Email VARCHAR(300),
	CreatedByUserId VARCHAR(64) not null,	-- Đây là người tạo nhân viên-- 
	LastUpdatedByUserId VARCHAR(64) not null, -- Đây là người cập nhật thông tin nhân viên -- 
	CreatedDate datetime not null, -- Day la ngay tao nhân viên--
	LastUpdatedDate datetime not null, -- Ngay cap nhap nhan vien -- 
	IsDeleted tinyint(6), -- default = 0, khi xoa nhan vien, chi can cap nhat bien = 1, khong su dung DELETE --
	Status smallint(6), -- trang thai kich hoat hoac vo hieu tai khoan --
	key (CreatedByUserId), -- Khoa ngoai cung chinh la Id cua staff --
	key (LastUpdatedByUserId));  -- Khoa ngoai cung chinh la Id  cua staff--

	
	
	
create table customer_score(
	Id VARCHAR(64) primary key,
	CustomerId varchar(64) not null,
	score int not null, -- maximun 100 , tạo diem so khac -- 
	Email VARCHAR(300),
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), -- trang thai cua diem so thuoc khach hang --
	key (CreatedByUserId), -- Khoa ngoai cung chinh la Id cua staff --
	key (LastUpdatedByUserId) );
	
	
	
);
drop table bill;

create table bill(
	Id  VARCHAR(64) primary key,
	Description VARCHAR (300) not null, -- ???? hoa odn khong co userName --
	-- Hoa on nay thuoc food hay drink -- 
	Amount tinyint(6)  not null,
	Price tinyint(6)  not null,
	Total tinyint(6)  not null,
	TypeOfBillID VARCHAR(64) not null, -- hoa don nahy thuoc food hay drink --
	PayId VARCHAR(64 )not null,
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), -- trang thai cua diem so thuoc khach hang --
	key (CreatedByUserId), -- Khoa ngoai cung chinh la Id cua staff --
	key (LastUpdatedByUserId),
	key (PayId),
	key (TypeOfBillID) );



create table type_of_bill (
	Id  VARCHAR(64) primary key,
	Name VARCHAR(300) not null,
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), -- trang thai cua diem so thuoc khach hang --
	key (CreatedByUserId), -- Khoa ngoai cung chinh la Id cua staff --
	key (LastUpdatedByUserId) );
	

create table bill_detail(
	Id  VARCHAR(64) primary key,
	BillID  VARCHAR(64)  not null,	
	Price bigint(16),
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), 	
	key (CreatedByUserId),
	key(BillID), 
	key (LastUpdatedByUserId) );


create table pay(
	Id VARCHAR(64) primary key,
	CustomerID VARCHAR(64) not null,	
	PaymentMethodId VARCHAR(300),
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6),
	key (CreatedByUserId), 
	key (LastUpdatedByUserId) );


create table payment_method(
	Id VARCHAR(64) primary key,
	Name VARCHAR(64) not null,	
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6),
	key (CreatedByUserId), 
	key (LastUpdatedByUserId) );



create table payment_detail(
	Id VARCHAR(64) primary key,
	Name VARCHAR(300),
	PaymentMethods VARCHAR(300),
	Amount VARCHAR(300),
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), 
	key (CreatedByUserId), 
	key (LastUpdatedByUserId) );

);
create table cart(
	Id VARCHAR(64) primary key,	
	Amount VARCHAR(300),
	Price VARCHAR(300),
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), 
	key (CreatedByUserId), 
	key (LastUpdatedByUserId) );

);
create table drink(
	Id VARCHAR(64) primary key,
	Name VARCHAR(300) not null,
	Amount VARCHAR(300) not null,
	Price VARCHAR(300) not null,
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), 
	key (CreatedByUserId),
	key (LastUpdatedByUserId) );


create table kind_of_drink(
	Id VARCHAR(64) primary key,
	Name VARCHAR(300)  not null,
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), 
	key (CreatedByUserId), 
	key (LastUpdatedByUserId) );


create table food(
	Id VARCHAR(64) primary key,
	Name VARCHAR(300)  not null,	
	Amount VARCHAR(300)  not null,	
	Price VARCHAR(300)  not null,	
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), 
	key (CreatedByUserId), 
	key (LastUpdatedByUserId) );


create table kind_of_food(
	Id  VARCHAR(64) primary key,
	Name VARCHAR(300) ot null,	
	CreatedByUserId VARCHAR(64) not null,	
	LastUpdatedByUserId VARCHAR(64) not null, 
	CreatedDate datetime not null, 
	LastUpdatedDate datetime not null, 
	IsDeleted tinyint(6) ,
	Status smallint(6), 
	key (CreatedByUserId), 
	key (LastUpdatedByUserId) );
