use master 
create database BookingAirline
go

use BookingAirline
go



create table Roles
(
	id int primary key,
	display_name nvarchar(10)
)

create table Staff
(
	id int primary key identity,
	role_id int default 1, --1: nhan vien 0: admin
	display_name nvarchar(50) not null, -- 
	password nvarchar(100) not null, -- mat khau
	email varchar(100) not null, -- email
	phone varchar(11) not null, --sdt
	status int default 1 -- 1: active 0: unactive
	foreign key(role_id) references Roles(id)
)

create table Customer
(
	id bigint primary key identity,
	email varchar(100) not null,
	password nvarchar(100) not null,
	first_name nvarchar(50) not null,
	middle_name nvarchar(50) not null,
	last_name nvarchar(50) not null,
	Dob datetime, -- ngay sinh
	phone varchar(11) not null,
	address nvarchar(50) not null,
	gender nchar(10) not null,
	status int default 1 -- 1:active 0: unactive
)

create table Bank
(
	id int primary key identity,
	customer_id bigint not null,
	display_name nvarchar(100) not null,
	bank_account_num bigint not null

	foreign key(customer_id) references Customer(id)
)

create table Location
(
	id int primary key identity,
	loca_code nvarchar(50) not null,
	display_name nvarchar(50) not null
)

create table Plane_type
(
	id bigint primary key identity,
	plane_code nvarchar(50) not null,
	display_name nvarchar(50) not null,
	total_seat int not null
)

create table Flight
(
	id bigint primary key identity,
	plane_type_id bigint not null,
	location_id int not null,
	flight_code varchar(50) not null,
	go_from nvarchar(100) not null,
	go_to nvarchar(100) not null,
	price int not null,
	date_flight datetime not null

	foreign key(plane_type_id) references Plane_type(id),
	foreign key(location_id) references Location(id)
)

create table Ticket
(
	id bigint primary key identity,
	customer_id bigint not null,
	flight_id bigint not null,
	create_date datetime not null,
	two_way int not null,
	total_ticket int not null,
	total_price int not null,

	foreign key(customer_id) references Customer(id),
	foreign key(flight_id) references Flight(id)
)

create table Class
(
	id int primary key identity,
	display_name nvarchar(50) not null,
	price int not null
)

create table Seat_detail
(
	id int identity primary key,
	class_id int not null,
	plane_type_id bigint not null,
	seat_code varchar(50) not null,
	status int default 1 --0: da dat 1: trong

	foreign key(class_id) references Class(id),
	foreign key(plane_type_id) references Plane_type(id)
)

create table Recommend
(
	id int primary key identity,
	id_flight bigint not null,
	content nvarchar(200) not null

	foreign key(id_flight) references Flight(id)
)

insert Roles values
(0,N'Admin'),
(1,N'Nhân viên'),
(99,N'Mail')

insert Staff(role_id,display_name,password,email,phone) values
(1,N'Lê Văn Luyện','spvhixkeagfawjqc','luyenlv@gmail.com','0129283738'),
(0,N'Lê Văn Hà','spvhixkeagfawjqc','halv@gmail.com','0918877228'),
(99,N'Email send','spvhixkeagfawjqc','bookingairline1@gmail.com','0918877228')

insert Customer (email,password,first_name,last_name,middle_name,Dob,address,phone,gender) values
('cus1@gmail.com','123',N'Phan',N'Trung',N'Nam','2001-1-15','none','0191771271',N'Nam')

insert Class(display_name,price) values
(N'Phổ Thông',500000),
(N'Thương Gia',1000000)

insert Plane_type(plane_code,display_name,total_seat) values
('Plane_1',N'Máy bay số 1',30),
('Plane_2',N'Máy bay số 2',50),
('Plane_3',N'Máy bay số 3',30),
('Plane_4',N'Máy bay số 4',30),
('Plane_5',N'Máy bay số 5',50),
('Plane_6',N'Máy bay số 6',30)

insert Location(loca_code,display_name) values
('TB',N'Thái Bình'),
('SL',N'Sơn La'),
('HT',N'Hà Tĩnh'),
('HA',N'Hà Giang'),
('CB',N'Cao Bằng'),
('LC',N'Lào Cai'),
('LCH',N'Lai Châu'),
('BK',N'Bắc Kạn'),
('LS',N'Lạng Sơn'),
('TQ',N'Tuyên Quang'),
('YB',N'Yên Bái'),
('TN',N'Thái Nguyên'),
('ĐB',N'Điện Biên'),
('PT',N'Phú Thọ'),
('VP',N'Vĩnh Phúc'),
('BG',N'Bắc Giang'),
('BN',N'Bắc Ninh'),
('HN',N'Hà Nội'),
('QN',N'Quảng Ninh'),
('HD',N'Hải Dương'),
('HP',N'Hải Phòng'),
('HB',N'Hòa Bình'),
('HY',N'Hưng Yên'),
('HNM',N'Hà Nam'),
('NĐ',N'Nam Định'),
('NB',N'Ninh Bình'),
('TH',N'Thanh Hóa'),
('NA',N'Nghệ An'),
('QB',N'Quảng Bình'),
('QT',N'Quảng Trị'),
('TTH',N'Thừa Thiên Huế'),
('ĐN',N'Đà Nẵng'),
('QN',N'Quảng Nam'),
('QNI',N'Quảng Ngãi'),
('KT',N'Kon Tum'),
('GL',N'Gia Lai'),
('BĐ',N'Bình Định'),
('PY',N'Phú Yên'),
('ĐL',N'Đắk Lắk'),
('KH',N'Khánh Hòa'),
('ĐN',N'Đắk Nông'),
('LĐ',N'Lâm Đồng'),
('NT',N'Ninh Thuận'),
('BP',N'Bình Phước'),
('TN',N'Tây Ninh'),
('BD',N'Bình Dương'),
('ĐN',N'Đồng Nai'),
('BT',N'Bình Thuận'),
('TPHCM',N'Thành phố Hồ Chí Minh'),
('LA',N'Long An'),
('BR-VT',N'Bà Rịa - Vũng Tàu'),
('ĐT',N'Đồng Tháp'),
('AG',N'An Giang'),
('TG',N'Tiền Giang'),
('VL',N'Vĩnh Long'),
('BT',N'Bến Tren'),
('CT',N'Cần Thơ'),
('KG',N'Kiên Giang'),
('TV',N'Trà Vinh'),
('HG',N'Hậu Giang'),
('ST',N'Sóc Trăng'),
('BL',N'Bạc Liêu'),
('CM',N'Cà Mau')

go

select * from Staff