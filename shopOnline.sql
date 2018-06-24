CREATE DATABASE OperaShop2
go
create table NguoiDung
(
	ID_NguoiDung nvarchar(10) primary key,
	TaiKhoan varchar(50),
	MatKhau varchar(50),
)
create table KhachHang
(
	ID_KhachHang nvarchar(10) primary key,
	TenKH varchar(50),
	SDT int,
	Mail varchar(100),
)
create table SanPham
(
	ID_SanPham nvarchar(10) primary key,
	ID_DanhMuc nvarchar(10) references DanhMucSanPham(ID_DanhMuc),
	TenOp varchar(250),
	TieuDeSP varchar(250),
	MoTaSP varchar(250),
	GiaSP int,
	SoLuong int,
	HinhAnh varchar(250),
	GiaKM int,
)
create table DanhMucSanPham
(
	ID_DanhMuc nvarchar(10) primary key,
	TenDM varchar(50),
)
create table HoaDon
(
	ID_HoaDon nvarchar(10) primary key,
	NgayLapHD datetime,
	DiaDiemNhan varchar(250),
	GhiChu varchar(250),
	TongTien int,
	ID_KhachHang nvarchar(10) references KhachHang(ID_KhachHang),
	ID_TinhTrangHD nvarchar(10) references TinhTrangHoaDon(ID_TinhTrangHD),
	ID_NVGiaoHang nvarchar(10) references NhanVienGiaoHang(ID_NVGiaoHang),
)
create table ChiTietDonDatHang
(
	ID_ChiTietHD nvarchar(10) primary key, 
	GiaSP int,
	SoLuong int,
	ID_HoaDon nvarchar(10) references HoaDon(ID_HoaDon),
	ID_SanPham nvarchar(10) references SanPham(ID_SanPham),
)
create table OpBanChay
(
	SoLuongBan int primary key,
	ID_SanPham nvarchar(10) references SanPham(ID_SanPham),
)
create table TinhTrangHoaDon
(
	ID_TinhTrangHD nvarchar(10) primary key,
	TinhTrangHD varchar(250),
)
create table NhanVienGiaoHang
(
	ID_NVGiaoHang nvarchar(10) primary key,
	TenNV varchar(50),
	SDT int,
)
go
