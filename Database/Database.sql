USE [master]
GO
/****** Object:  Database [QuanLyNhaHang]    Script Date: 12/15/2015 13:33:23 ******/
CREATE DATABASE [QuanLyNhaHang] ON  PRIMARY 
( NAME = N'QuanLyNhaHang', FILENAME = N'E:\Database\QuanLyNhaHang\QuanLyNhaHang.mdf' , SIZE = 3328KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyNhaHang_log', FILENAME = N'E:\Database\QuanLyNhaHang\QuanLyNhaHang_log.LDF' , SIZE = 1344KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyNhaHang] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyNhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLyNhaHang] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET  DISABLE_BROKER
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLyNhaHang] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLyNhaHang] SET  READ_WRITE
GO
ALTER DATABASE [QuanLyNhaHang] SET RECOVERY FULL
GO
ALTER DATABASE [QuanLyNhaHang] SET  MULTI_USER
GO
ALTER DATABASE [QuanLyNhaHang] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLyNhaHang] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyNhaHang', N'ON'
GO
USE [QuanLyNhaHang]
GO
/****** Object:  UserDefinedTableType [dbo].[DSSanPham]    Script Date: 12/15/2015 13:33:24 ******/
CREATE TYPE [dbo].[DSSanPham] AS TABLE(
	[MaSP] [char](10) NULL,
	[SoLuong] [int] NULL
)
GO
/****** Object:  Table [dbo].[DanhSachDatMonTrongNgay]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DanhSachDatMonTrongNgay](
	[MaChuyen] [char](10) NOT NULL,
	[MaMon] [char](10) NULL,
	[ThoiGian] [time](7) NULL,
	[SoLuong] [int] NULL,
	[TinhTrang] [int] NULL,
	[GhiChu] [nvarchar](70) NULL,
 CONSTRAINT [PK_DanhSachDatMonTrongNgay] PRIMARY KEY CLUSTERED 
(
	[MaChuyen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucVuNhanVien]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVuNhanVien](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVuNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuuTruCTPhieuNhap]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruCTPhieuNhap](
	[MaPN] [char](10) NULL,
	[MaSP] [char](10) NULL,
	[SoLuong] [float] NULL,
	[MaDV] [int] NULL,
	[DonGia] [money] NULL,
	[TongTien] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruCTPhieuNhan]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruCTPhieuNhan](
	[MaPG] [char](10) NULL,
	[MaSP] [char](10) NULL,
	[SoLuong] [float] NULL,
	[MaPN] [char](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruCTLamMon]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruCTLamMon](
	[MaMon] [char](10) NULL,
	[MaSP] [char](10) NULL,
	[MaDV] [int] NULL,
	[SoLuong] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruCTHoaDon]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruCTHoaDon](
	[MaHoaDon] [char](10) NULL,
	[MaMon] [char](10) NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiDonViTinh]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDonViTinh](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](8) NULL,
	[DoTangMacDinh] [float] NULL,
 CONSTRAINT [PK_LoaiDonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[SoBan] [int] NOT NULL,
	[ViTri] [nvarchar](50) NULL,
	[SoLuongKhach] [int] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[SoBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: da dat 0: chua dat' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ban', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [char](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](60) NULL,
	[ChietKhau] [decimal](3, 2) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonAnDoUong]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonAnDoUong](
	[MaMon] [char](10) NOT NULL,
	[TenMon] [nvarchar](100) NOT NULL,
	[GiaTienHienTai] [money] NULL,
	[ThucDonMon] [bit] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_MonAn_SoLuong] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: Hien thi len thuc don mon 0: Khong hien thi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MonAnDoUong', @level2type=N'COLUMN',@level2name=N'ThucDonMon'
GO
/****** Object:  Table [dbo].[LuuTruSanPham]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruSanPham](
	[MaSP] [char](10) NULL,
	[TenSP] [nvarchar](70) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruPhieuNhap]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruPhieuNhap](
	[MaPN] [char](10) NULL,
	[MaNV] [char](10) NULL,
	[MaNCC] [char](10) NULL,
	[NgayLap] [date] NULL,
	[NgayGiaoDK] [date] NULL,
	[TinhTrang] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruPhieuNhan]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruPhieuNhan](
	[MaPG] [char](10) NULL,
	[MaPN] [char](10) NULL,
	[MaNV] [char](10) NULL,
	[TongTien] [money] NULL,
	[NgayLap] [date] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruNhanVien]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruNhanVien](
	[MaNV] [char](10) NULL,
	[TGBatDau] [date] NULL,
	[cmnd] [char](12) NULL,
	[HoTen] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](8) NULL,
	[LoaiNhanVien] [bit] NULL,
	[MaChucVu] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruMonAnDoUong]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruMonAnDoUong](
	[MaMon] [char](10) NULL,
	[TenMon] [nvarchar](100) NULL,
	[GiaTienHienTai] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruLichLamViec]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruLichLamViec](
	[MaNV] [char](10) NULL,
	[ThangNam] [datetime] NULL,
	[Ca] [int] NULL,
	[SoBan] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruHoaDon]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruHoaDon](
	[MaHoaDon] [char](10) NULL,
	[ThoiGian] [datetime] NULL,
	[TongTien] [money] NULL,
	[GhiChu] [nvarchar](70) NULL,
	[SoBanChung] [int] NULL,
	[SoLuongKhach] [int] NULL,
	[MaNV] [char](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichCa]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichCa](
	[NamThang] [datetime] NOT NULL,
	[Ca] [int] NOT NULL,
	[Gio] [datetime] NULL,
	[Luong] [money] NULL,
 CONSTRAINT [PK_LichCa] PRIMARY KEY CLUSTERED 
(
	[NamThang] ASC,
	[Ca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[uf_CatChuoiThanhSo]    Script Date: 12/15/2015 13:33:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[uf_CatChuoiThanhSo](@Ma char(10), @Dau char(1), @ViTri bit = 0)
returns int
As
Begin
	Declare @Chuoi char(10)
	Declare @So int
	if @ViTri = 0
	Begin
		set @Chuoi = LEFT(RTRIM(@Ma), CHARINDEX(@Dau, @Ma) - 1)
	End
	ELSE
	Begin
		if @Dau <> '0'
		Begin
			set @Chuoi = RIGHT(RTRIM(@Ma), CHARINDEX(@Dau, @Ma))
		End	
		Else
		Begin
			set @Chuoi = @Ma
		End
	End

	set @so = SUBSTRING(@Chuoi, PATINDEX('%[1-9]%', @Chuoi), LEN(@Chuoi) - PATINDEX('%[1-9]%', @Chuoi) + 1)
	return @So
End
GO
/****** Object:  StoredProcedure [dbo].[spMonAnDoUongUpdateTinhTrangMon]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spMonAnDoUongUpdateTinhTrangMon] @MaMon char(10), @TinhTrang bit
As
Begin
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	
	Update MonAnDoUong set TinhTrang = @TinhTrang where MaMon = @MaMon
End
GO
/****** Object:  StoredProcedure [dbo].[spMonAnDoUongSelect]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spMonAnDoUongSelect] @TinhTrang bit = 1
As
Begin
	Select MaMon, TenMon
	From MonAnDoUong
	where ThucDonMon = 1 AND TinhTrang = @TinhTrang
End
GO
/****** Object:  StoredProcedure [dbo].[usp_TaoMaChuyen]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_TaoMaChuyen] @SoBan int, @MaMoi char(10) output
As
Begin
	Declare @kt bit = 0
	Declare @len int
	Declare @chuoi char(5)
	Declare @so int
	
	Select top 1 @MaMoi = RIGHT(RTRIM(MaChuyen), CHARINDEX('-', MaChuyen) + 1)
	From DanhSachDatMonTrongNgay
	where dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 0) = @SoBan
	--Cắt chuỗi MaChuyen thành đôi lấy số để xét
	--Tìm số trong mã chuyển để sắp xếp
	Order by dbo.uf_CatChuoiThanhSo(MaChuyen,'-', 1) DESC
	if ISNULL(RTRIM(@MaMoi), '') = ''
	Begin
		set @kt = 1
		set @MaMoi = '0001'
	End
	
	set @len = LEN(@MaMoi)
	set @so = dbo.uf_CatChuoiThanhSo(@MaMoi, '0', 1)
	if @kt = 0
	Begin
		set @so = @so + 1
	End
	
	set @MaMoi = REPLICATE('0', 1) + RTRIM(CAST(@SoBan as char(5))) + '-' + REPLICATE('0', @len - LEN(@so)) + RTRIM(CAST(@so as char(5)))
	
End
GO
/****** Object:  StoredProcedure [dbo].[spDSDatMonTrongNgayDelete]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDSDatMonTrongNgayDelete]
As
Begin
	Delete From DanhSachDatMonTrongNgay
End
GO
/****** Object:  StoredProcedure [dbo].[spDemMonDaDat]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDemMonDaDat]
As
Begin
	Select COUNT(*)
	From DanhSachDatMonTrongNgay
	Where TinhTrang = 1
End
GO
/****** Object:  StoredProcedure [dbo].[spDSDatMonTrongNgayUpdateTinhTrang]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDSDatMonTrongNgayUpdateTinhTrang] @MaChuyen char(10), @TinhTrang int
As
Begin
	if ISNULL(@MaChuyen,'') = ''
	Begin
		return 0
	End
	
	if @TinhTrang < 1 OR @TinhTrang > 4
	Begin
		return 0
	End
	
	Update DanhSachDatMonTrongNgay set TinhTrang = @TinhTrang where @MaChuyen = @MaChuyen
End
GO
/****** Object:  StoredProcedure [dbo].[spDSDatMonTrongNgayUpdateSoLuong]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDSDatMonTrongNgayUpdateSoLuong] @MaChuyen char(10), @SL int
As
Begin
	if ISNULL(@MaChuyen,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@SL,'') = ''
	Begin
		return 0
	End
	
	Update DanhSachDatMonTrongNgay set SoLuong = @SL where @MaChuyen = @MaChuyen
End
GO
/****** Object:  StoredProcedure [dbo].[spDSDatMonTrongNgayUpdateGhiChu]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDSDatMonTrongNgayUpdateGhiChu] @MaChuyen char(10), @GhiChu nvarchar(50)
As
Begin
	if ISNULL(@MaChuyen,'') = ''
	Begin
		return 0
	End
	
	Update DanhSachDatMonTrongNgay set GhiChu = @GhiChu where MaChuyen = @MaChuyen
End
GO
/****** Object:  StoredProcedure [dbo].[spDSDatMonTrongNgaySelectThuNgan]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDSDatMonTrongNgaySelectThuNgan] @MaChuyenDau char(10), @MaChuyenCuoi char(10)
As
Begin
	if ISNULL(@MaChuyenDau,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaChuyenCuoi,'') = ''
	Begin
		return 0
	End
	Select DS.MaMon, MA.TenMon, DS.SoLuong, DS.ThoiGian, DS.TinhTrang, DS.GhiChu
	From DanhSachDatMonTrongNgay DS, MonAnDoUong MA
	Where dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 1) >= dbo.uf_CatChuoiThanhSo(@MaChuyenDau,'-', 1) AND dbo.uf_CatChuoiThanhSo(MaChuyen,'-', 1) <= dbo.uf_CatChuoiThanhSo(@MaChuyenCuoi, '-', 1)
	AND dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 0) = dbo.uf_CatChuoiThanhSo(@MaChuyenDau, '-', 0)
	AND DS.MaMon = MA.MaMon
End
GO
/****** Object:  StoredProcedure [dbo].[spDSDatMonTrongNgaySelect]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDSDatMonTrongNgaySelect] @Time char(20)
As
Begin
	if ISNULL(@Time, '') = ''
	Begin
		return 0
	End
	
	--if ISDATE(RTRIM(@Time)) = 0
	--Begin
	--	print @Time
	--	return 0
	--End
	--Else
	--Begin
		Declare @ThoiGian time
		set @ThoiGian = DATEADD(MILLISECOND, 500, CONVERT(time, @Time))
		Select DS.MaChuyen, DS.MaMon, MA.TenMon, DS.SoLuong, DS.ThoiGian, DS.GhiChu
		From DanhSachDatMonTrongNgay DS, MonAnDoUong MA
		Where ThoiGian >= @ThoiGian AND ThoiGian <= DATEADD(MINUTE, 3.5, @ThoiGian) AND Ma.MaMon = DS.MaMon
	--End
End
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TGBatDau] [date] NULL,
	[cmnd] [char](12) NULL,
	[HoTen] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](6) NULL,
	[LoaiNhanVien] [bit] NULL,
	[MaChucVu] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_NhanVien_cmd] UNIQUE NONCLUSTERED 
(
	[cmnd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: fulltime 0: parttime' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
/****** Object:  Table [dbo].[NhaCungCap_Email]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap_Email](
	[MaNCC] [char](10) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap_Email] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC,
	[Email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap_DienThoai]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap_DienThoai](
	[MaNCC] [char](10) NOT NULL,
	[SDT] [char](15) NOT NULL,
 CONSTRAINT [PK_NhaCungCap_DienThoai] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC,
	[SDT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [char](10) NOT NULL,
	[TenSP] [nvarchar](70) NULL,
	[SoLuongTon] [float] NULL,
	[MaDV] [int] NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruDanhSachMonAnSoLuongKHoanThanh]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruDanhSachMonAnSoLuongKHoanThanh](
	[NgayLamMon] [datetime] NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[SoLuongMon] [int] NULL,
 CONSTRAINT [PK_LuuTruDanhSachMonAnSoLuongKHoanThanh] PRIMARY KEY CLUSTERED 
(
	[NgayLamMon] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruDanhSachMonAnNhaBepHoanThanh]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruDanhSachMonAnNhaBepHoanThanh](
	[NgayLamMon] [date] NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[SoLuongMon] [int] NULL,
 CONSTRAINT [PK_DanhSachMonAnChoNhaBep] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[NgayLamMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [char](10) NOT NULL,
	[MaNV] [char](10) NULL,
	[ThoiGian] [datetime] NULL,
	[SoBan] [int] NULL,
	[SoLuongKhach] [int] NULL,
	[MaHDChung] [char](10) NULL,
	[TongTien] [money] NULL,
	[GhiChu] [nvarchar](70) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_ÐatMon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichLamViec]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichLamViec](
	[MaNV] [char](10) NOT NULL,
	[ThangNam] [datetime] NOT NULL,
	[Ca] [int] NOT NULL,
	[SoBan] [int] NULL,
 CONSTRAINT [PK_LichLamViec] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[ThangNam] ASC,
	[Ca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietLamMon]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietLamMon](
	[MaMon] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[MaDV] [int] NULL,
	[SoLuong] [float] NULL,
 CONSTRAINT [PK_ChiTietLamMon] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCT] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [char](10) NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaMotMon] [money] NULL,
	[ThanhTien] [money] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietHoaDon_1] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaMon] ASC,
	[MaCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuuTruSanPhamDaDung]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruSanPhamDaDung](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [char](10) NULL,
	[SoLuong] [int] NULL,
	[NgayDung] [date] NULL,
 CONSTRAINT [PK_LIchSuSanPham] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [char](10) NOT NULL,
	[MaNV] [char](10) NULL,
	[MaNCC] [char](10) NULL,
	[NgayLap] [date] NULL,
	[NgayGiaoDK] [date] NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spDSDatMonTrongNgayInsert]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDSDatMonTrongNgayInsert] 
@MaMon char(10), 
@SoLuong int = 1, 
@TinhTrang int = 1,
@GhiChu nvarchar(50) = null, 
@SoBan int, 
@MaMoi char(10) output
As
Begin
	if ISNULL(@SoBan, '') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaMon, '') = ''
	Begin
		return 0
	End
	
	exec usp_TaoMaChuyen @SoBan, @MaMoi output
	Declare @Thoigian time
	set @Thoigian = CONVERT(time, SYSDATETIME())
	Insert into DanhSachDatMonTrongNgay(MaChuyen, MaMon, ThoiGian, SoLuong, TinhTrang, GhiChu) values(@MaMoi, @MaMon, @Thoigian, @SoLuong, @TinhTrang, @GhiChu)
End
GO
/****** Object:  Table [dbo].[KhaNangViTinhCuaNhanVien]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhaNangViTinhCuaNhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenPhanMem] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhaNangViTinhCuaNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[TenPhanMem] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_LayMaDMonMoiNhat]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayMaDMonMoiNhat] @MaNV char(10), @MaHD char(10) output
As
Begin
	if ((Select COUNT(*) From HoaDon) = 0)
	Begin
		return 1
	End
	
	Select top 1 @MaHD = MaHoaDon
	From HoaDon
	Where MaNV = @MaNV
	Order by MaHoaDon DESC 
End
GO
/****** Object:  StoredProcedure [dbo].[spLaySanPham]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spLaySanPham] @TenSP nvarchar(50)
As
Begin
	if ISNULL(@TenSP,'') = ''
	Begin
		return 0
	End
	
	Select SP.MaSP, SP.TenSP, LD.TenDV, LD.DoTangMacDinh
	From SanPham SP, LoaiDonViTinh LD
	Where SP.TenSP like N'%' + @TenSP + '%' AND SP.MaDV = LD.MaDV
End
GO
/****** Object:  Table [dbo].[TaiKhoanNhanVien]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoanNhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenDN] [nvarchar](50) NULL,
	[MatKhau] [varchar](max) NULL,
 CONSTRAINT [PK_LoginNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_TaoMaHoaDon]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_TaoMaHoaDon] @MaMoi char(10) output
As
Begin
	Declare @so int
	Select top 1 @MaMoi = MaHoaDon
	From HoaDon
	Order By MaHoaDon DESC
	
	if ISNULL(@MaMoi, '') = ''
	Begin
		set @MaMoi = 'HD0001'
		return 1
	End
	
	set @so = SUBSTRING(RTRIM(@MaMoi), PATINDEX('%[1-9]%', @MaMoi), LEN(@MaMoi) - PATINDEX('%[1-9]%', @MaMoi) + 1) + 1
	set @MaMoi = 'HD' + REPLICATE('0', LEN(@MaMoi) - 2 - LEN(@so)) + CAST(@so as varchar(5))
End
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemHoaDonMoi]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemHoaDonMoi] 
@MaNV char(10),
@SoBan int, 
@SoLuongKhach int, 
@ThoiGian datetime, 
@GhiChu nvarchar(50) = null
As
Begin
	Declare @MaMoi char(10)
	exec usp_TaoMaHoaDon @MaMoi output
	
	Insert into HoaDon values(@MaMoi, @MaNV, @ThoiGian, @SoBan, @SoLuongKhach, @MaMoi, NULL, @GhiChu, 0)
End
GO
/****** Object:  StoredProcedure [dbo].[spSanPhamDaDungInsert]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spSanPhamDaDungInsert] @DS As DSSanPham Readonly
As
Begin
	if not exists(Select * from @DS)
	Begin
		return
	End
	
	Insert into LuuTruSanPhamDaDung(MaSP, SoLuong, NgayDung) Select MaSP, SoLuong, GETDATE() From @DS
End
GO
/****** Object:  StoredProcedure [dbo].[spCTLamMonSelect]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spCTLamMonSelect] @MaMon char(10)
As
Begin
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	Select CT.MaMon, CT.MaSP, SP.TenSP, CT.SoLuong, LD.TenDV, LD.DoTangMacDinh
	From ChiTietLamMon CT, LoaiDonViTinh LD, SanPham SP
	Where MaMon = @MaMon AND LD.MaDV = CT.MaDV AND SP.MaSP = CT.MaSP
End
GO
/****** Object:  Table [dbo].[PhieuNhan]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhan](
	[MaPG] [char](10) NOT NULL,
	[MaPN] [char](10) NULL,
	[MaNV] [char](10) NULL,
	[TongTien] [money] NULL,
	[NgayLap] [date] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuGiao] PRIMARY KEY CLUSTERED 
(
	[MaPG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[SoLuong] [float] NULL,
	[MaDV] [int] NULL,
	[DonGia] [money] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhan]    Script Date: 12/15/2015 13:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhan](
	[MaPG] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[SoLuong] [float] NULL,
	[MaPN] [char](10) NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuGiao] PRIMARY KEY CLUSTERED 
(
	[MaPG] ASC,
	[MaSP] ASC,
	[MaPN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [D_TinhTrang]    Script Date: 12/15/2015 13:33:25 ******/
ALTER TABLE [dbo].[DanhSachDatMonTrongNgay] ADD  CONSTRAINT [D_TinhTrang]  DEFAULT ((1)) FOR [TinhTrang]
GO
/****** Object:  Check [CK_NhanVien_CMND]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_NhanVien_CMND] CHECK  ((len([cmnd])=(9) OR len([cmnd])=(12)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_NhanVien_CMND]
GO
/****** Object:  ForeignKey [FK_NhanVien_ChucVuNhanVien]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVuNhanVien] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVuNhanVien] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVuNhanVien]
GO
/****** Object:  ForeignKey [FK_NhaCungCap_Email_NhaCungCap]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[NhaCungCap_Email]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_Email_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[NhaCungCap_Email] CHECK CONSTRAINT [FK_NhaCungCap_Email_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_NhaCungCap_DienThoai_NhaCungCap]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[NhaCungCap_DienThoai]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_DienThoai_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[NhaCungCap_DienThoai] CHECK CONSTRAINT [FK_NhaCungCap_DienThoai_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_SanPham_LoaiDonViTinh]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiDonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[LoaiDonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiDonViTinh]
GO
/****** Object:  ForeignKey [FK_LuuTruDanhSachMonAnSoLuongKHoanThanh_MonAnDoUong_SoLuong]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[LuuTruDanhSachMonAnSoLuongKHoanThanh]  WITH CHECK ADD  CONSTRAINT [FK_LuuTruDanhSachMonAnSoLuongKHoanThanh_MonAnDoUong_SoLuong] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAnDoUong] ([MaMon])
GO
ALTER TABLE [dbo].[LuuTruDanhSachMonAnSoLuongKHoanThanh] CHECK CONSTRAINT [FK_LuuTruDanhSachMonAnSoLuongKHoanThanh_MonAnDoUong_SoLuong]
GO
/****** Object:  ForeignKey [FK_LuuTruDanhSachMonAnChoNhaBep_MonAn_SoLuong]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[LuuTruDanhSachMonAnNhaBepHoanThanh]  WITH CHECK ADD  CONSTRAINT [FK_LuuTruDanhSachMonAnChoNhaBep_MonAn_SoLuong] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAnDoUong] ([MaMon])
GO
ALTER TABLE [dbo].[LuuTruDanhSachMonAnNhaBepHoanThanh] CHECK CONSTRAINT [FK_LuuTruDanhSachMonAnChoNhaBep_MonAn_SoLuong]
GO
/****** Object:  ForeignKey [FK_ÐatMon_Ban]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ÐatMon_Ban] FOREIGN KEY([SoBan])
REFERENCES [dbo].[Ban] ([SoBan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_ÐatMon_Ban]
GO
/****** Object:  ForeignKey [FK_LichLamViec_Ban]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD  CONSTRAINT [FK_LichLamViec_Ban] FOREIGN KEY([SoBan])
REFERENCES [dbo].[Ban] ([SoBan])
GO
ALTER TABLE [dbo].[LichLamViec] CHECK CONSTRAINT [FK_LichLamViec_Ban]
GO
/****** Object:  ForeignKey [FK_LichLamViec_LichCa]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD  CONSTRAINT [FK_LichLamViec_LichCa] FOREIGN KEY([ThangNam], [Ca])
REFERENCES [dbo].[LichCa] ([NamThang], [Ca])
GO
ALTER TABLE [dbo].[LichLamViec] CHECK CONSTRAINT [FK_LichLamViec_LichCa]
GO
/****** Object:  ForeignKey [FK_LichLamViec_NhanVien]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD  CONSTRAINT [FK_LichLamViec_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LichLamViec] CHECK CONSTRAINT [FK_LichLamViec_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietLamMon_MonAnDoUong_SoLuong]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietLamMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLamMon_MonAnDoUong_SoLuong] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAnDoUong] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietLamMon] CHECK CONSTRAINT [FK_ChiTietLamMon_MonAnDoUong_SoLuong]
GO
/****** Object:  ForeignKey [FK_ChiTietLamMon_NguyenLieu]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietLamMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLamMon_NguyenLieu] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietLamMon] CHECK CONSTRAINT [FK_ChiTietLamMon_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietLamMonMacDinh_LoaiDonViTinh]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietLamMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLamMonMacDinh_LoaiDonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[LoaiDonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[ChiTietLamMon] CHECK CONSTRAINT [FK_ChiTietLamMonMacDinh_LoaiDonViTinh]
GO
/****** Object:  ForeignKey [FK_ChiTietDatMon_DatMon]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatMon_DatMon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietDatMon_DatMon]
GO
/****** Object:  ForeignKey [FK_ChiTietDatMon_MonAn_SoLuong]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatMon_MonAn_SoLuong] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAnDoUong] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietDatMon_MonAn_SoLuong]
GO
/****** Object:  ForeignKey [FK_LIchSuSanPham_SanPham]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[LuuTruSanPhamDaDung]  WITH CHECK ADD  CONSTRAINT [FK_LIchSuSanPham_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[LuuTruSanPhamDaDung] CHECK CONSTRAINT [FK_LIchSuSanPham_SanPham]
GO
/****** Object:  ForeignKey [FK_DatHang_NhaCungCap]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_DatHang_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_DatHang_NhanVien]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_DatHang_NhanVien]
GO
/****** Object:  ForeignKey [FK_KhaNangViTinhCuaNhanVien_NhanVien]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[KhaNangViTinhCuaNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_KhaNangViTinhCuaNhanVien_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhaNangViTinhCuaNhanVien] CHECK CONSTRAINT [FK_KhaNangViTinhCuaNhanVien_NhanVien]
GO
/****** Object:  ForeignKey [FK_LoginNhanVien_NhanVien]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[TaiKhoanNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_LoginNhanVien_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoanNhanVien] CHECK CONSTRAINT [FK_LoginNhanVien_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuGiao_NhanVien]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[PhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhan] CHECK CONSTRAINT [FK_PhieuGiao_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuNhan_PhieuNhap]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[PhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhan_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[PhieuNhan] CHECK CONSTRAINT [FK_PhieuNhan_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_LoaiDonViTinh]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_LoaiDonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[LoaiDonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_LoaiDonViTinh]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_NguyenLieu]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_NguyenLieu] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_PhieuNhap]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuGiao_NguyenLieu]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiao_NguyenLieu] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan] CHECK CONSTRAINT [FK_ChiTietPhieuGiao_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuGiao_PhieuGiao]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiao_PhieuGiao] FOREIGN KEY([MaPG])
REFERENCES [dbo].[PhieuNhan] ([MaPG])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan] CHECK CONSTRAINT [FK_ChiTietPhieuGiao_PhieuGiao]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhan_ChiTietPhieuNhap]    Script Date: 12/15/2015 13:33:27 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhan_ChiTietPhieuNhap] FOREIGN KEY([MaPN], [MaSP])
REFERENCES [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan] CHECK CONSTRAINT [FK_ChiTietPhieuNhan_ChiTietPhieuNhap]
GO
