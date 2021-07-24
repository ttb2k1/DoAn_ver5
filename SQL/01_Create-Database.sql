create database DoAn
go

use DoAn
go

create table ThucAn
(
	MaThucAn varchar(10) primary key,
	LoaiThucAn nvarchar(20),
	TenThucAn nvarchar(20)
)
go

create table Size_Price
(
	KichCo nvarchar(10),
	GiaBan int,
	MaSP varchar(10) primary key,
	MaThucAn varchar(10),
	foreign key (MaThucAn) references ThucAn(MaThucAn)
)
go

create table NhanVien
(
	MaNhanVien varchar(10) primary key,
	HoVaTen nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(100),
	CMND int,
	Email varchar(100),
	SDT varchar(20),
	ChucVu nvarchar(50),
	NgayVaoLam date
)
go

create table HoaDonThucAn
(
	MaHoaDon varchar(10) primary key,
	NgayTao date,
	MaNhanVien varchar(10),
	foreign key (MaNhanVien) references NhanVien(MaNhanVien)
)
go

create table ChiTietHDTA
(
	MaHoaDon varchar(10),
	MaSP varchar(10),
	SoLuong int,
	foreign key (MaSP) references Size_Price(MaSP),
	foreign key (MaHoaDon) references HoaDonThucAn(MaHoaDon)
)
go

create table GheNgoi
(
	MaSuatChieu varchar(10),
	MaGhe varchar(10),
	TinhTrang bit,
	MaPhongChieu varchar(10)
)
go

create table HoaDonVe
(
	MaHoaDonVe int,
	MaSuatChieu nchar(10),
	MaGhe nvarchar(100),
	NgayBanVe date,
	MaNhanVien nvarchar(10),
	GiaVe float,
	MaKhachHang nvarchar(10)
)
go

create table KhachHang
(
	MaKhachHang nvarchar(50),
	TenKhachHang nvarchar(50),
	GioiTinh nvarchar(10),
	CMND varchar(10),
	NgaySinh date,
	Email varchar(50),
	SDT nvarchar(50),
	LoaiKhachHang nvarchar(10),
	NgayDangKy date
)
go

create table KichCoThucAn
(
	MaKichCo varchar(10),
	TenKichCo nvarchar(10)
)
go

create table LoaiThucAn
(
	MaLoaiThucAn varchar(10) primary key,
	TenLoaiThucAn nvarchar(50)
)
go

create table Phim
(
	MaPhim varchar(50) primary key,
	TenPhim nvarchar(100),
	ThoiLuong int,
	NamSanXuat int,
	GioiHanTuoi int,
	NgayRaMat date,
	TrangThai nvarchar(20),
	DienVien nvarchar(100),
	NuocSanXuat nvarchar(50),
	NgonNgu nvarchar(50),
	NhaSanXuat nvarchar(100),
	DoanhThu int,
	TomTat nvarchar(100)
)
go

create table PhongChieu
(
	MaPhongChieu nchar(10),
	TenPhongChieu nvarchar(50),
	SoHangGhe int,
	SoGhe1Hang int
)
go

create table SuatChieu
(
	MaPhim varchar(50),
	MaSuatChieu varchar(20) primary key,
	NgayGio datetime,
	DinhDang char(5),
	HinhThuc nvarchar(50),
	NgonNgu nvarchar(50),
	TrangThai nvarchar(20),
	TenPhongChieu nvarchar(50),
	GiaVe float,
	foreign key (MaPhim) references Phim(MaPhim)
)
go