create database [HoaDon]
go

use [HoaDon]
go

set ansi_nulls on
go

set quoted_identifier on
go

create table [KhachHang](
	[MaKH]	[int]			not null	primary key,
	[TenKH]	[nvarchar](255)	null,
	[DCKH]	[nvarchar](255)	null,
	[DTKH]	[nvarchar](255) null
)
go

create table [NhanVien](
	[MaNV]		[int]			not null	primary key,
	[Ho]		[nvarchar](255)	null,
	[Ten]		[nvarchar](255) null,
	[Nu]		[int]			null,
	[LuongCB]	[float]			null,
	[CongViec]	[nvarchar](255)	null,
	[MaKV]		[int]			null,
)
go

create table [MatHang](
	[MaMH]		[int]			not null	primary key,
	[TenMH]		[nvarchar](255)	null,
	[DonViTinh]	[nvarchar](255)	null,
	[DonGia]	[float]			null,
	[SoTon]		[int]			null,
	[MaLH]		[nvarchar](255)	null
)
go

create table [HoaDon](
	[SoHD]		[int]		not null	primary key,
	[NgayHD]	[datetime]	null,
	[NgayGiao]	[datetime]	null,
	[MaKH]		[int]		null		foreign key references KhachHang(MaKH),
	[MaNV]		[int]		null		foreign key references NhanVien(MaNV)
)
go

create table [CTDH](
	[SoHD]		[int]	not null	foreign key references HoaDon(SoHD),
	[MaMH]		[int]	not null	foreign key references MatHang(MaMH),
	[So Luong]	[int]	null,
	[DG Ban]	[float]	null,
	primary key(SoHD, MaMH)
)
go

INSERT INTO [NhanVien]  VALUES
(1,N'Nguyễn Ngọc',N'Nga',1,2.34,N'NVVP',1),
(2,N'Hà Vĩnh',N'Phát',0,3.67,N'Kế Toán',1),
(3,N'Trần Tuyết',N'Oanh',1,2.67,N'nvvp',2),
(4,N'Nguyễn Kim',N'Ngọc',1,2.9,N'IT',3),
(5,N'Trương Duy',N'Hùng',0,3.1,N'KTV',4),
(6,N'Lương Bá',N'Tháng',0,3.1,N'NVVP',3),
(7,N'Lâm Sơn',N'Hoàng',0,3.67,N'IT',2),
(8,N'Nguyễn Minh',N'Hoồng',0,4.1,N'Kế Toán',3),
(9,N'Vương',N'Ngọc',1,4.1,N'KTV',4)
go

INSERT INTO [MatHang]  VALUES
(1,N'Ruợu',N'Chai',230,5,N'L2'),
(2,N'Gia Vị',N'Thùng',40,0,N'L3'),
(3,N'Bánh Kem',N'Cái',10,10,N'L2'),
(4,N'Bơ',N'KG',38,0,N'L3'),
(5,N'Bánh mì',N'Cái',8,20,N'L2')
go

INSERT INTO [KhachHang]  VALUES
(2,N'Cơ sở dân dụng',N'534 Lê Văn Sỹ P14',N'(058) 8647207'),
(3,N'Công nghệ mới',N'81 Trang Tư',N'(04) 8369254'),
(4,N'Công nghiệp cao su',N'84 Bình Thiên P3',N'(04) 8452178'),
(6,N'SXKD Dịch vụ tổng hợp',N'170 Hậu Giang P6',N'(031) 8631792'),
(7,N'Hóa nhựa Vĩnh Tiến',N'11 vạn tuơng P13',N'(058) 8796540'),
(8,N'Vận tải biển Việt Nam',N'220 Lê Văn Sỹ P14',N'(04) 8654298'),
(9,N'Vạn Thịnh Phát',N'110 Hùng vương P16 Q11',N'(08) 8762059')
go

INSERT INTO [HoaDon]  VALUES
(10144,'4/10/1999','10/16/1999',4,7),
(10145,'3/11/1999','10/11/1999',6,9),
(10148,'1/14/2000','11/2/2000',7,1),
(10150,'1/17/2000','2/28/2000',2,4)
go

INSERT INTO [CTDH]  VALUES
(10144,1,35,230),
(10148,5,25,230),
(10145,1,12,230),
(10148,2,25,40),
(10145,2,8,40),
(10144,3,10,10),
(10150,3,20,50)
go

