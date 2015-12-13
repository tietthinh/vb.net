USE [master]
GO
/****** Object:  Database [QuanLyNhaHang]    Script Date: 12/09/2015 14:54:25 ******/
CREATE DATABASE [QuanLyNhaHang] ON  PRIMARY 
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [ChietKhau], [GhiChu]) VALUES (N'NCC001    ', N'Rau Quả Sạch', N'46,Cao Vân', CAST(2.00 AS Decimal(3, 2)), NULL)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [ChietKhau], [GhiChu]) VALUES (N'NCC002    ', N'Thực Phẩm Tươi', N'55,Lý Thường Kiệt', CAST(1.00 AS Decimal(3, 2)), NULL)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [ChietKhau], [GhiChu]) VALUES (N'NCC003    ', N'IBM', N'23,Cách Mạng Tháng Tám ', CAST(1.20 AS Decimal(3, 2)), NULL)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [ChietKhau], [GhiChu]) VALUES (N'NCC004    ', N'Viet Wine', N'7,Phan Châu Trinh', CAST(1.50 AS Decimal(3, 2)), NULL)
/****** Object:  Table [dbo].[MonAnDoUong]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0001    ', N'Cơm Chiên Dương Châu', 60.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0002    ', N'Tôm Muối Ớt', 70.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0003    ', N'Trứng Hấp', 79.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0004    ', N'Mỳ Bò Hàn Quốc', 79.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0005    ', N'Mỳ Trộn Lạnh', 79.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0006    ', N'Mỳ Tươi Hải Sản', 79.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0007    ', N'Bánh Hải Sản', 79.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0008    ', N'Cơm Trộn Hàn Quốc', 89.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0009    ', N'Cơm Trộn Bát Đá Nóng', 89.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0010    ', N'Mực Trứng', 70.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0011    ', N'Phi Lê Cá Ba Sa', 80.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0012    ', N'Kem Tươi', 5.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0013    ', N'Caramel', 15.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0029    ', N'Salad Tổng Hợp', 50.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0030    ', N'Salad Hoa Quả Tươi', 30.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0031    ', N'Salad Cá Ngừ', 50.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0032    ', N'Salad Rau Tươi', 30.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0033    ', N'Lẩu Bulgogi', 199.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0034    ', N'Lẩu Kim Chi ', 199.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0035    ', N'Lẩu Sườn Heo Kim Chi', 199.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0036    ', N'Canh Chua Cá Hú', 120.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0037    ', N'Tê Tượng Chiên Xù', 80.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0038    ', N'Sườn Xào Chua Ngọt', 70.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0039    ', N'Hào Sống', 70.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DA0040    ', N'Sò Điệp Bơ Tỏi', 70.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0014    ', N'Trà Hồ Đào', 45.0000, 1)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0015    ', N'Berry Colada', 45.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0016    ', N'Passion Colada', 45.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0017    ', N'Sparkle Hương Táo', 45.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0018    ', N'Lemon Juice', 45.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0019    ', N'Passion Juice', 45.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0020    ', N'Orange Juice', 45.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0021    ', N'HaNoi Beer', 30.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0022    ', N'Heneiken Beer', 30.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0023    ', N'SaiGon Beer', 30.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0024    ', N'Saporo Beer', 30.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0025    ', N'Vodka Aligato', 90.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0026    ', N'Rượu Gạo ', 129.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0027    ', N'Rượu Táo Xanh', 219.0000, 0)
INSERT [dbo].[MonAnDoUong] ([MaMon], [TenMon], [GiaTienHienTai], [ThucDonMon]) VALUES (N'DU0028    ', N'Rượu Táo Đỏ', 219.0000, 0)
/****** Object:  Table [dbo].[LuuTruSanPham]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruPhieuNhap]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruPhieuNhan]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruNhanVien]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruMonAnDoUong]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruLichLamViec]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruDatMon]    Script Date: 12/09/2015 14:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruDatMon](
	[MaDatMon] [char](10) NULL,
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
/****** Object:  Table [dbo].[ChucVuNhanVien]    Script Date: 12/09/2015 14:54:30 ******/
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
SET IDENTITY_INSERT [dbo].[ChucVuNhanVien] ON
INSERT [dbo].[ChucVuNhanVien] ([MaChucVu], [TenChucVu]) VALUES (1, N'Phục Vụ')
INSERT [dbo].[ChucVuNhanVien] ([MaChucVu], [TenChucVu]) VALUES (2, N'Pha Chế')
INSERT [dbo].[ChucVuNhanVien] ([MaChucVu], [TenChucVu]) VALUES (3, N'Quản Lý')
INSERT [dbo].[ChucVuNhanVien] ([MaChucVu], [TenChucVu]) VALUES (4, N'Tiếp Tân')
INSERT [dbo].[ChucVuNhanVien] ([MaChucVu], [TenChucVu]) VALUES (5, N'Quản Lý Kho')
SET IDENTITY_INSERT [dbo].[ChucVuNhanVien] OFF
/****** Object:  Table [dbo].[Ban]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (1, N'Bên Trái Sảnh', 4, 0)
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (2, N'Bên Trái Sảnh', 4, 0)
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (3, N'Bên Trái Sảnh', 6, 0)
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (4, N'Giữa Sảnh', 4, 0)
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (5, N'Giữa Sảnh', 4, 0)
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (6, N'Giữa Sảnh', 6, 0)
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (7, N'Bên Phải Sảnh', 4, 0)
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (8, N'Bên Phải Sảnh', 4, 0)
INSERT [dbo].[Ban] ([SoBan], [ViTri], [SoLuongKhach], [TinhTrang]) VALUES (9, N'Bên Phải Sảnh', 6, 0)
/****** Object:  Table [dbo].[LoaiDonViTinh]    Script Date: 12/09/2015 14:54:30 ******/
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
SET IDENTITY_INSERT [dbo].[LoaiDonViTinh] ON
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (1, N'Chai', 1)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (2, N'Lon', 1)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (3, N'Cái', 1)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (4, N'Kg', 0.2)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (5, N'ml', 100)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (6, N'Quả/Trái', 1)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (7, N'Ổ', 1)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (8, N'Hộp', 1)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (9, N'Hủ', 1)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (10, N'Bịch', 1)
INSERT [dbo].[LoaiDonViTinh] ([MaDV], [TenDV], [DoTangMacDinh]) VALUES (11, N'Con', 1)
SET IDENTITY_INSERT [dbo].[LoaiDonViTinh] OFF
/****** Object:  Table [dbo].[LichCa]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[LichCa] ([NamThang], [Ca], [Gio], [Luong]) VALUES (CAST(0x0000A55800000000 AS DateTime), 1, CAST(0x0000A55800735B40 AS DateTime), 90.0000)
INSERT [dbo].[LichCa] ([NamThang], [Ca], [Gio], [Luong]) VALUES (CAST(0x0000A55800000000 AS DateTime), 2, CAST(0x0000A5580128A180 AS DateTime), 90.0000)
INSERT [dbo].[LichCa] ([NamThang], [Ca], [Gio], [Luong]) VALUES (CAST(0x0000A57600000000 AS DateTime), 1, CAST(0x0000A57600735B40 AS DateTime), 90.0000)
INSERT [dbo].[LichCa] ([NamThang], [Ca], [Gio], [Luong]) VALUES (CAST(0x0000A57600000000 AS DateTime), 2, CAST(0x0000A5760128A180 AS DateTime), 90.0000)
INSERT [dbo].[LichCa] ([NamThang], [Ca], [Gio], [Luong]) VALUES (CAST(0x0000A59500000000 AS DateTime), 1, CAST(0x0000A59500735B40 AS DateTime), 90.0000)
INSERT [dbo].[LichCa] ([NamThang], [Ca], [Gio], [Luong]) VALUES (CAST(0x0000A59500000000 AS DateTime), 2, CAST(0x0000A5950128A180 AS DateTime), 90.0000)
/****** Object:  Table [dbo].[LuuTruCTPhieuNhap]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruCTPhieuNhan]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruCTLamMon]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruCTDatMon]    Script Date: 12/09/2015 14:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruCTDatMon](
	[MaDatMon] [char](10) NULL,
	[MaMon] [char](10) NULL,
	[SoLuong] [int] NULL,
	[ThoiGian] [datetime] NULL,
	[MaChuyen] [char](10) NULL,
	[ThanhTien] [money] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0001    ', CAST(0xCB350B00 AS Date), N'331646418   ', N'Nguyễn Thành Nhân', 1, CAST(0x9D080B00 AS Date), N'Nam', 1, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0002    ', CAST(0xCB350B00 AS Date), N'331675862   ', N'Lê Thị Bích Hà', 1, CAST(0x3C0F0B00 AS Date), N'Nữ', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0003    ', CAST(0x30370B00 AS Date), N'331654782   ', N'Trần Văn Thiện', 0, CAST(0xE5150B00 AS Date), N'Nam', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0004    ', CAST(0xC6350B00 AS Date), N'331786543   ', N'Nguyễn Thế Thành', 1, CAST(0xE6180B00 AS Date), N'Nam', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0005    ', CAST(0x66370B00 AS Date), N'331645327   ', N'Lê Văn Hòa', 0, CAST(0x45180B00 AS Date), N'Nam', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0006    ', CAST(0xEF340B00 AS Date), N'334672813   ', N'Trần Quế Vân', 1, CAST(0x4D160B00 AS Date), N'Nữ', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0007    ', CAST(0xF5380B00 AS Date), N'331794324   ', N'Huỳnh Thế Thức', 0, CAST(0x5D160B00 AS Date), N'Nam', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0008    ', CAST(0x38370B00 AS Date), N'332491787   ', N'Trần Thanh', 1, CAST(0x8B130B00 AS Date), N'Nữ', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0009    ', CAST(0x30360B00 AS Date), N'334678921   ', N'Trương Kim Ngọc', 1, CAST(0x0E190B00 AS Date), N'Nữ', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0010    ', CAST(0xCB350B00 AS Date), N'326701948   ', N'Huỳnh Thanh Ngọc', 1, CAST(0x1F1B0B00 AS Date), N'Nữ ', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0011    ', CAST(0x3C350B00 AS Date), N'339875243   ', N'Hoàng Thanh Vũ', 1, CAST(0xFC160B00 AS Date), N'Nam', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0012    ', CAST(0x52350B00 AS Date), N'331245789   ', N'Tôn Thanh Ngọc', 1, CAST(0xE1160B00 AS Date), N'Nữ', 1, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0013    ', CAST(0x99380B00 AS Date), N'336978012   ', N'Trần Văn Kiệt', 1, CAST(0x620B0B00 AS Date), N'Nam', 0, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0014    ', CAST(0xCC320B00 AS Date), N'334509183   ', N'Lữ Quốc Việt', 1, CAST(0x82140B00 AS Date), N'Nam', 1, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0015    ', CAST(0x8F340B00 AS Date), N'325789103   ', N'Trần Thu Hoài', 0, CAST(0x790D0B00 AS Date), N'Nữ', 0, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0016    ', CAST(0xF9320B00 AS Date), N'315670932   ', N'Đỗ Huy Nam', 1, CAST(0x0E150B00 AS Date), N'Nam', 1, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0017    ', CAST(0x41370B00 AS Date), N'345689203   ', N'Đỗ Quốc Hùng', 1, CAST(0x7B1A0B00 AS Date), N'Nam', 1, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0018    ', CAST(0x71370B00 AS Date), N'345789214   ', N'Trần Thanh Hòa', 1, CAST(0x9D0F0B00 AS Date), N'Nam', 1, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0019    ', CAST(0x68330B00 AS Date), N'332869103   ', N'Huỳnh Kim Ngọc', 1, CAST(0xE71A0B00 AS Date), N'Nữ', 0, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0020    ', CAST(0x4A340B00 AS Date), N'345123789   ', N'Nguyễn Kim Phượng', 1, CAST(0x6D160B00 AS Date), N'Nữ', 0, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0021    ', CAST(0x4C330B00 AS Date), N'326940867   ', N'Trần Tuấn Tài', 1, CAST(0x5D180B00 AS Date), N'Nam', 1, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0022    ', CAST(0x5D340B00 AS Date), N'342367514   ', N'Phan Duy Hòa', 0, CAST(0x14120B00 AS Date), N'Nam', 0, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0023    ', CAST(0x0B360B00 AS Date), N'331780945   ', N'Trần Thế Hào', 1, CAST(0x3A0F0B00 AS Date), N'Nam', 1, 4)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0024    ', CAST(0x2E370B00 AS Date), N'342189041   ', N'Nguyễn Văn Sang', 1, CAST(0x331B0B00 AS Date), N'Nam', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0025    ', CAST(0xF4370B00 AS Date), N'316894523   ', N'Trần Thu Đào', 1, CAST(0x92130B00 AS Date), N'Nữ', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0026    ', CAST(0x16380B00 AS Date), N'315678041   ', N'Hồ Hồng Thạnh', 1, CAST(0x12160B00 AS Date), N'Nam', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0027    ', CAST(0x66380B00 AS Date), N'317809278   ', N'Nguyễn Tuấn Anh', 1, CAST(0xAD160B00 AS Date), N'Nam', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0028    ', CAST(0x9B380B00 AS Date), N'391456789   ', N'Đoàn Thanh Ngọc', 1, CAST(0xF2130B00 AS Date), N'Nữ', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0029    ', CAST(0xAB380B00 AS Date), N'314589018   ', N'Nguyễn Tường Vy', 1, CAST(0x54180B00 AS Date), N'Nữ', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TGBatDau], [cmnd], [HoTen], [TinhTrang], [NgaySinh], [GioiTinh], [LoaiNhanVien], [MaChucVu]) VALUES (N'NV0030    ', CAST(0xFD380B00 AS Date), N'345320918   ', N'Thái QUốc Minh', 1, CAST(0xE5130B00 AS Date), N'Nam', 0, 5)
/****** Object:  Table [dbo].[NhaCungCap_Email]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[NhaCungCap_Email] ([MaNCC], [Email]) VALUES (N'NCC001    ', N'RQS@gmail.com')
INSERT [dbo].[NhaCungCap_Email] ([MaNCC], [Email]) VALUES (N'NCC002    ', N'ThucPhamTuoi@gmail.com')
INSERT [dbo].[NhaCungCap_Email] ([MaNCC], [Email]) VALUES (N'NCC003    ', N'IBMVN@gmail.com')
INSERT [dbo].[NhaCungCap_Email] ([MaNCC], [Email]) VALUES (N'NCC004    ', N'VietWine@gmail.com')
/****** Object:  Table [dbo].[NhaCungCap_DienThoai]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[NhaCungCap_DienThoai] ([MaNCC], [SDT]) VALUES (N'NCC001    ', N'01648756132    ')
INSERT [dbo].[NhaCungCap_DienThoai] ([MaNCC], [SDT]) VALUES (N'NCC002    ', N'0943211461     ')
INSERT [dbo].[NhaCungCap_DienThoai] ([MaNCC], [SDT]) VALUES (N'NCC003    ', N'0932641325     ')
INSERT [dbo].[NhaCungCap_DienThoai] ([MaNCC], [SDT]) VALUES (N'NCC004    ', N'01297423289    ')
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0001    ', N'Chuối', 200, 6)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0002    ', N'Bơ', 200, 6)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0003    ', N'Gạo', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0004    ', N'Đậu Que', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0005    ', N'Cà Rốt', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0006    ', N'Trứng', 200, 6)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0007    ', N'Muối', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0008    ', N'Đường', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0009    ', N'Bột Ngọt', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0010    ', N'Hạt Nêm', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0011    ', N'Tiêu', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0012    ', N'Dầu Ăn', 1000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0013    ', N'Ớt', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0014    ', N'Tôm', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0015    ', N'Nước Tương', 10000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0016    ', N'Mì', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0017    ', N'Thịt Bò', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0018    ', N'Rau Cần', 2, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0019    ', N'Rau Ngò', 2, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0020    ', N'Củ Cải Trắng', 2, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0021    ', N'Thịt Heo', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0022    ', N'Hành', 2, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0023    ', N'Ngò', 2, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0024    ', N'Hẹ', 2, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0025    ', N'Sò Điệp', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0026    ', N'Nghêu', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0027    ', N'Cua', 50, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0028    ', N'Bánh Mì', 100, 7)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0029    ', N'Kim Chi', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0030    ', N'Tôm Khô', 2, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0031    ', N'Bắp Cải', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0032    ', N'Dưa Leo', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0033    ', N'Mực', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0034    ', N'Bạch Tuộc', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0035    ', N'Gạo', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0036    ', N'Bột Mì', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0037    ', N'Cá Ba Sa', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0038    ', N'Kem Tươi', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0039    ', N'Caramel', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0040    ', N'Dâu', 5, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0041    ', N'Trà Hồ Đào', 10000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0042    ', N'Berry Colada', 20000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0043    ', N'Passion Colada', 20000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0044    ', N'Sparkle Hương Táo', 20000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0045    ', N'Lemon Juice', 20000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0046    ', N'Passion Juice', 20000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0047    ', N'Orange Juice', 20000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0048    ', N'HaNoi Beer', 240000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0049    ', N'Heneiken Beer', 240000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0050    ', N'SaiGon Beer', 240000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0051    ', N'Saporo Beer', 240000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0052    ', N'Vodka Aligato', 100, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0053    ', N'Rượu Gạo ', 100, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0054    ', N'Rượu Táo Xanh', 100, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0055    ', N'Rượu Táo Đỏ', 100, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0056    ', N'Giấm', 2000, 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0057    ', N'Mayone', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0058    ', N'Cá Ngừ', 100, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0059    ', N'Rau Mầm', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0060    ', N'Giá', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0061    ', N'Bạc Hà', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0062    ', N'Cá Hú', 50, 11)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0063    ', N'Me', 10, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0064    ', N'Cá Tê Tượng', 50, 11)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0065    ', N'Sườn Heo', 50, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0066    ', N'Hào', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0067    ', N'Tỏi', 20, 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuongTon], [MaDV]) VALUES (N'SP0068    ', N'Bơ Thực Vật', 20, 4)
/****** Object:  Table [dbo].[DatMon]    Script Date: 12/09/2015 14:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DatMon](
	[MaDatMon] [char](10) NOT NULL,
	[MaNV] [char](10) NULL,
	[ThoiGian] [datetime] NULL,
	[SoBan] [int] NULL,
	[SoLuongKhach] [int] NULL,
	[SoBanChung] [int] NULL,
	[TongTien] [money] NULL,
	[GhiChu] [nvarchar](70) NULL,
 CONSTRAINT [PK_ÐatMon] PRIMARY KEY CLUSTERED 
(
	[MaDatMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DatMon] ([MaDatMon], [MaNV], [ThoiGian], [SoBan], [SoLuongKhach], [SoBanChung], [TongTien], [GhiChu]) VALUES (N'MD001     ', N'NV002     ', CAST(0x0000A558008C1360 AS DateTime), 1, 5, 1, 180.0000, NULL)
INSERT [dbo].[DatMon] ([MaDatMon], [MaNV], [ThoiGian], [SoBan], [SoLuongKhach], [SoBanChung], [TongTien], [GhiChu]) VALUES (N'MD002     ', N'NV006     ', CAST(0x0000A558009450C0 AS DateTime), 3, 5, 1, 140.0000, NULL)
INSERT [dbo].[DatMon] ([MaDatMon], [MaNV], [ThoiGian], [SoBan], [SoLuongKhach], [SoBanChung], [TongTien], [GhiChu]) VALUES (N'MD003     ', N'NV011     ', CAST(0x0000A55800E6B680 AS DateTime), 5, 2, 5, 316.0000, NULL)
INSERT [dbo].[DatMon] ([MaDatMon], [MaNV], [ThoiGian], [SoBan], [SoLuongKhach], [SoBanChung], [TongTien], [GhiChu]) VALUES (N'MD004     ', N'NV029     ', CAST(0x0000A5580107AC00 AS DateTime), 7, 4, 7, 237.0000, NULL)
INSERT [dbo].[DatMon] ([MaDatMon], [MaNV], [ThoiGian], [SoBan], [SoLuongKhach], [SoBanChung], [TongTien], [GhiChu]) VALUES (N'MD005     ', N'NV011     ', CAST(0x0000A55801391C40 AS DateTime), 4, 4, 7, 395.0000, NULL)
INSERT [dbo].[DatMon] ([MaDatMon], [MaNV], [ThoiGian], [SoBan], [SoLuongKhach], [SoBanChung], [TongTien], [GhiChu]) VALUES (N'MD006     ', N'NV009     ', CAST(0x0000A55800DE7920 AS DateTime), 6, 5, 7, 316.0000, NULL)
INSERT [dbo].[DatMon] ([MaDatMon], [MaNV], [ThoiGian], [SoBan], [SoLuongKhach], [SoBanChung], [TongTien], [GhiChu]) VALUES (N'MD007     ', N'NV027     ', CAST(0x0000A558014418C0 AS DateTime), 9, 3, 9, 395.0000, NULL)
/****** Object:  Table [dbo].[LuuTruDanhSachMonAnSoLuongKHoanThanh]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruDanhSachMonAnNhaBepHoanThanh]    Script Date: 12/09/2015 14:54:30 ******/
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
/****** Object:  Table [dbo].[LuuTruSanPhamDaDung]    Script Date: 12/09/2015 14:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuuTruSanPhamDaDung](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [char](10) NULL,
	[TenSP] [nvarchar](50) NULL,
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
SET IDENTITY_INSERT [dbo].[LuuTruSanPhamDaDung] ON
INSERT [dbo].[LuuTruSanPhamDaDung] ([STT], [MaSP], [TenSP], [SoLuong], [NgayDung]) VALUES (1, N'SP0001    ', N'Chuối', 50, CAST(0xB53A0B00 AS Date))
INSERT [dbo].[LuuTruSanPhamDaDung] ([STT], [MaSP], [TenSP], [SoLuong], [NgayDung]) VALUES (2, N'SP0002    ', N'Bơ', 50, CAST(0xB53A0B00 AS Date))
INSERT [dbo].[LuuTruSanPhamDaDung] ([STT], [MaSP], [TenSP], [SoLuong], [NgayDung]) VALUES (3, N'SP0003    ', N'Gạo', 7, CAST(0xB53A0B00 AS Date))
INSERT [dbo].[LuuTruSanPhamDaDung] ([STT], [MaSP], [TenSP], [SoLuong], [NgayDung]) VALUES (4, N'SP0010    ', N'Hạt Nêm', 3, CAST(0xB53A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[LuuTruSanPhamDaDung] OFF
/****** Object:  Table [dbo].[LichLamViec]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0002    ', CAST(0x0000A55800000000 AS DateTime), 1, 1)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0002    ', CAST(0x0000A55800000000 AS DateTime), 2, 1)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0002    ', CAST(0x0000A57600000000 AS DateTime), 1, 1)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0002    ', CAST(0x0000A57600000000 AS DateTime), 2, 9)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0004    ', CAST(0x0000A55800000000 AS DateTime), 1, 2)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0004    ', CAST(0x0000A55800000000 AS DateTime), 2, 2)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0004    ', CAST(0x0000A57600000000 AS DateTime), 1, 2)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0004    ', CAST(0x0000A57600000000 AS DateTime), 2, 8)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0006    ', CAST(0x0000A55800000000 AS DateTime), 1, 3)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0006    ', CAST(0x0000A57600000000 AS DateTime), 2, 4)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0008    ', CAST(0x0000A55800000000 AS DateTime), 1, 4)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0008    ', CAST(0x0000A55800000000 AS DateTime), 2, 3)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0008    ', CAST(0x0000A57600000000 AS DateTime), 1, 3)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0009    ', CAST(0x0000A55800000000 AS DateTime), 1, 5)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0009    ', CAST(0x0000A55800000000 AS DateTime), 2, 4)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0009    ', CAST(0x0000A57600000000 AS DateTime), 1, 4)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0009    ', CAST(0x0000A57600000000 AS DateTime), 2, 7)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0010    ', CAST(0x0000A55800000000 AS DateTime), 1, 6)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0010    ', CAST(0x0000A57600000000 AS DateTime), 2, 1)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0011    ', CAST(0x0000A55800000000 AS DateTime), 1, 7)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0011    ', CAST(0x0000A55800000000 AS DateTime), 2, 5)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0024    ', CAST(0x0000A55800000000 AS DateTime), 1, 8)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0024    ', CAST(0x0000A57600000000 AS DateTime), 1, 7)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0024    ', CAST(0x0000A57600000000 AS DateTime), 2, 3)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0025    ', CAST(0x0000A55800000000 AS DateTime), 1, 9)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0025    ', CAST(0x0000A57600000000 AS DateTime), 1, 8)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0025    ', CAST(0x0000A57600000000 AS DateTime), 2, 5)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0026    ', CAST(0x0000A57600000000 AS DateTime), 1, 5)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0026    ', CAST(0x0000A57600000000 AS DateTime), 2, 2)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0027    ', CAST(0x0000A55800000000 AS DateTime), 2, 9)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0027    ', CAST(0x0000A57600000000 AS DateTime), 1, 6)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0027    ', CAST(0x0000A57600000000 AS DateTime), 2, 6)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0028    ', CAST(0x0000A55800000000 AS DateTime), 1, 9)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0028    ', CAST(0x0000A57600000000 AS DateTime), 2, 6)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0029    ', CAST(0x0000A55800000000 AS DateTime), 2, 7)
INSERT [dbo].[LichLamViec] ([MaNV], [ThangNam], [Ca], [SoBan]) VALUES (N'NV0030    ', CAST(0x0000A57600000000 AS DateTime), 2, 8)
/****** Object:  Table [dbo].[ChiTietLamMon]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0004    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0005    ', 6, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0006    ', 6, 2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0007    ', 4, 0.01)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0008    ', 4, 0.01)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0009    ', 4, 0.01)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0010    ', 4, 0.01)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0011    ', 4, 0.01)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0012    ', 5, 150)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0013    ', 6, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0014    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0015    ', 5, 10)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0018    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0001    ', N'SP0035    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0002    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0002    ', N'SP0013    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0002    ', N'SP0014    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0003    ', N'SP0006    ', 6, 4)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0003    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0004    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0004    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0004    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0004    ', N'SP0011    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0004    ', N'SP0016    ', 4, 0.3)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0004    ', N'SP0017    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0004    ', N'SP0018    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0004    ', N'SP0019    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0005    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0005    ', N'SP0011    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0005    ', N'SP0015    ', 5, 100)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0005    ', N'SP0018    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0005    ', N'SP0019    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0006    ', N'SP0014    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0006    ', N'SP0016    ', 4, 0.3)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0006    ', N'SP0025    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0006    ', N'SP0026    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0007    ', N'SP0022    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0007    ', N'SP0023    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0007    ', N'SP0024    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0007    ', N'SP0025    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0007    ', N'SP0026    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0007    ', N'SP0036    ', 4, 0.3)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0008    ', N'SP0023    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0008    ', N'SP0030    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0008    ', N'SP0032    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0008    ', N'SP0033    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0008    ', N'SP0035    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0009    ', N'SP0006    ', 6, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0009    ', N'SP0033    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0009    ', N'SP0035    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0010    ', N'SP0006    ', 6, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0010    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0010    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0010    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0010    ', N'SP0033    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0011    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0011    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0011    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0011    ', N'SP0022    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0011    ', N'SP0037    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0012    ', N'SP0038    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0013    ', N'SP0039    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0029    ', N'SP0018    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0029    ', N'SP0019    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0029    ', N'SP0023    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0029    ', N'SP0024    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0029    ', N'SP0032    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0029    ', N'SP0056    ', 5, 50)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0030    ', N'SP0001    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0030    ', N'SP0002    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0030    ', N'SP0040    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0030    ', N'SP0056    ', 5, 50)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0030    ', N'SP0057    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0031    ', N'SP0022    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0031    ', N'SP0023    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0031    ', N'SP0031    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0031    ', N'SP0056    ', 5, 50)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0031    ', N'SP0058    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0032    ', N'SP0022    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0032    ', N'SP0023    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0032    ', N'SP0056    ', 5, 50)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0032    ', N'SP0059    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0033    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0033    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0033    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0033    ', N'SP0021    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0033    ', N'SP0022    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0033    ', N'SP0023    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0034    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0034    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0034    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0034    ', N'SP0010    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0034    ', N'SP0020    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0034    ', N'SP0029    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0034    ', N'SP0031    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0035    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0035    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0035    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0035    ', N'SP0010    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0035    ', N'SP0021    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0035    ', N'SP0029    ', 4, 0.2)
GO
print 'Processed 100 total records'
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0035    ', N'SP0031    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0036    ', N'SP0007    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0036    ', N'SP0008    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0036    ', N'Sp0009    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0036    ', N'SP0010    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0036    ', N'SP0060    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0036    ', N'SP0061    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0036    ', N'SP0062    ', 11, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0036    ', N'SP0063    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0037    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0037    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0037    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0037    ', N'SP0010    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0037    ', N'SP0012    ', 5, 10)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0037    ', N'SP0064    ', 11, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0038    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0038    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0038    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0038    ', N'SP0010    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0038    ', N'SP0015    ', 5, 10)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0038    ', N'SP0056    ', 5, 10)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0038    ', N'SP0065    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0039    ', N'SP0019    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0039    ', N'SP0056    ', 5, 5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0039    ', N'SP0066    ', 4, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0040    ', N'SP0007    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0040    ', N'SP0008    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0040    ', N'SP0009    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0040    ', N'SP0010    ', 4, 0.1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0040    ', N'SP0025    ', 4, 0.5)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0040    ', N'SP0067    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DA0040    ', N'SP0068    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0014    ', N'SP0041    ', 4, 0.2)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0015    ', N'SP0042    ', 5, 100)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0016    ', N'SP0043    ', 5, 100)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0017    ', N'SP0044    ', 5, 100)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0018    ', N'SP0045    ', 5, 100)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0019    ', N'SP0046    ', 5, 100)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0020    ', N'SP0047    ', 5, 100)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0021    ', N'SP0048    ', 5, 100)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0022    ', N'SP0049    ', 1, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0023    ', N'SP0050    ', 1, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0024    ', N'SP0051    ', 1, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0025    ', N'SP0052    ', 1, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0026    ', N'SP0053    ', 1, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0027    ', N'SP0054    ', 1, 1)
INSERT [dbo].[ChiTietLamMon] ([MaMon], [MaSP], [MaDV], [SoLuong]) VALUES (N'DU0028    ', N'SP0055    ', 1, 1)
/****** Object:  Table [dbo].[ChiTietDatMon]    Script Date: 12/09/2015 14:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietDatMon](
	[MaChuyen] [char](10) NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[MaDatMon] [char](10) NULL,
	[MaMon] [char](10) NULL,
	[SoLuong] [int] NULL,
	[GiaMotMon] [money] NULL,
	[ThanhTien] [money] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietDatMon] PRIMARY KEY CLUSTERED 
(
	[MaChuyen] ASC,
	[ThoiGian] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietDatMon] ([MaChuyen], [ThoiGian], [MaDatMon], [MaMon], [SoLuong], [GiaMotMon], [ThanhTien], [GhiChu]) VALUES (N'001-001   ', CAST(0x0000A558008C1360 AS DateTime), N'MD001     ', N'DA0001    ', 3, 60.0000, 180.0000, NULL)
INSERT [dbo].[ChiTietDatMon] ([MaChuyen], [ThoiGian], [MaDatMon], [MaMon], [SoLuong], [GiaMotMon], [ThanhTien], [GhiChu]) VALUES (N'003-002   ', CAST(0x0000A558009C8E20 AS DateTime), N'MD002     ', N'DA0002    ', 2, 70.0000, 140.0000, NULL)
INSERT [dbo].[ChiTietDatMon] ([MaChuyen], [ThoiGian], [MaDatMon], [MaMon], [SoLuong], [GiaMotMon], [ThanhTien], [GhiChu]) VALUES (N'004-003   ', CAST(0x0000A55800C5C100 AS DateTime), N'MD004     ', N'DA0005    ', 3, 79.0000, 237.0000, NULL)
INSERT [dbo].[ChiTietDatMon] ([MaChuyen], [ThoiGian], [MaDatMon], [MaMon], [SoLuong], [GiaMotMon], [ThanhTien], [GhiChu]) VALUES (N'004-004   ', CAST(0x0000A55800E3F760 AS DateTime), N'MD005     ', N'DA0007    ', 5, 79.0000, 395.0000, NULL)
INSERT [dbo].[ChiTietDatMon] ([MaChuyen], [ThoiGian], [MaDatMon], [MaMon], [SoLuong], [GiaMotMon], [ThanhTien], [GhiChu]) VALUES (N'005-005   ', CAST(0x0000A558008C1360 AS DateTime), N'MD003     ', N'DA0008    ', 4, 79.0000, 316.0000, NULL)
INSERT [dbo].[ChiTietDatMon] ([MaChuyen], [ThoiGian], [MaDatMon], [MaMon], [SoLuong], [GiaMotMon], [ThanhTien], [GhiChu]) VALUES (N'006-006   ', CAST(0x0000A5580107AC00 AS DateTime), N'MD006     ', N'DA0010    ', 4, 79.0000, 316.0000, NULL)
INSERT [dbo].[ChiTietDatMon] ([MaChuyen], [ThoiGian], [MaDatMon], [MaMon], [SoLuong], [GiaMotMon], [ThanhTien], [GhiChu]) VALUES (N'009-007   ', CAST(0x0000A55801323E70 AS DateTime), N'MD007     ', N'DA0012    ', 5, 79.0000, 395.0000, NULL)
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/09/2015 14:54:30 ******/
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
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayLap], [NgayGiaoDK], [TinhTrang]) VALUES (N'PN0001    ', N'NV0030    ', N'NCC001    ', CAST(0x1C3A0B00 AS Date), CAST(0x233A0B00 AS Date), 1)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayLap], [NgayGiaoDK], [TinhTrang]) VALUES (N'PN0002    ', N'NV0030    ', N'NCC002    ', CAST(0x1C3A0B00 AS Date), CAST(0x74390B00 AS Date), 1)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayLap], [NgayGiaoDK], [TinhTrang]) VALUES (N'PN0003    ', N'NV0030    ', N'NCC003    ', CAST(0x1C3A0B00 AS Date), CAST(0x74390B00 AS Date), 1)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayLap], [NgayGiaoDK], [TinhTrang]) VALUES (N'PN0004    ', N'NV0030    ', N'NCC004    ', CAST(0x1C3A0B00 AS Date), CAST(0x74390B00 AS Date), 1)
/****** Object:  StoredProcedure [dbo].[usp_LayMaDMonMoiNhat]    Script Date: 12/09/2015 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayMaDMonMoiNhat] @MaNV char(10), @MaHD char(10) output
As
Begin
	if ((Select COUNT(*) From DatMon) = 0)
	Begin
		return 1
	End
	
	Select top 1 @MaHD = MaDatMon
	From DatMon
	Where MaNV = @MaNV
	Order by MaDatMon DESC 
End
GO
/****** Object:  Table [dbo].[LoginNhanVien]    Script Date: 12/09/2015 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoginNhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenDN] [nvarchar](50) NULL,
	[MatKhau] [varchar](max) NULL,
 CONSTRAINT [PK_LoginNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0001    ', N'NguyenThanhNhan', N'339ec5e4b6cc7707a39da270b3bef7255ba94c03b82d2a9c1dd4b5fee7b360f4')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0002    ', N'LeThiBichHa', N'd864a01fa22796d4481a42410cc29081ce6d9fa3cfee8f8a598d7b2bfb94db94')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0003    ', N'TranVanThien', N'b035ee71d0d202a098c207c424a1125ae168bc73b66113228f9265c78c980c54')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0004    ', N'NguyenTheThanh', N'af8fe92ffb3b3912db23f97c6d6ebbfcbb0cd912f33269f5016b2a4b97b857f9')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0005    ', N'LeVanHoa', N'a68db38d8f153f1a939a9c3207608b4fb3b23a2bd92514c2d7a56bcc0d3a7148')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0006    ', N'TranQueVan', N'0a0f2142f2297ec63254d1f1f11e5679b23067caaab44bcf698c889b7fdfb822')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0007    ', N'HuynhTheThuc', N'5011e961bd3306cecaf62f384b2bc3e111d2c4487a029b674fcee09437a15e05')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0008    ', N'TranThanh', N'7016428f501de3f6310472411f094fe99bdeb1a7b210a3346d71df95a6ef2965')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0009    ', N'TruongKimNgoc', N'858482b7ef6504c3fbd97a5109a37383837e2874fa8876a874c5f5e856b9577a')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0010    ', N'HuynhThanhNgoc', N'17ad37f38ee9ceb7628ef377330a95849d9d34ca4ca05a27b455fb3b5816d6ef')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0011    ', N'HoanhThanhVu', N'6bc7a7c16254e0d4af3b0db131d6f06d5a71664cfdb834a7932986bfcfbd6009')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0012    ', N'TonThanhNgoc', N'e0f2fa542f21c3a0cebed9c7232832ab4721e8360b893d4c91ef3a9566712f46')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0013    ', N'TranVanKiet', N'2a3273f863b8c23fc57a4d590ceee926d8b2715b4cf63653bdeb4dcc1f37a3ea')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0014    ', N'LuQuocViet', N'b3c221c7ea0adf83d6f662c6fdc5d122c2ae860c9566e42e2cf11b28919bb4ac')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0015    ', N'TranThuHoai', N'17c0380ff5a023edd32b57066a3e59dd1764409dd9834863c87c5e9bb770afc7')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0016    ', N'DoHuyNam', N'26d7c838ddf415dfca4708e7e33947bf14ba9d2c7f43c85e57be724fce17384c')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0017    ', N'DoQuocHung', N'10385a8b9052dac5c8a82218b6dfc94d8659a9c9011b915e710158b94b0de882')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0018    ', N'TranThanhHoa', N'4173930d4dfbd405518e7988d7c35aca7d38f0402415f71830e0668e397f4df9')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0019    ', N'HuynhKimNgoc', N'3df904d9efee3b40f26e136d24ee7e963cb13e40e580417922384447bfb1b881')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0020    ', N'NguyenKimPhuong', N'0f39a8505f2d9dc38873669607648f696ff41666c65b6322c41ba6e1f5bf26ab')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0021    ', N'TranTuanTai', N'61b8330033da90885523f43ddd071aff2327d66a53a3e1610b4f9bb9a42b1c41')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0022    ', N'PhanDuyHoa', N'c20e58952f4d58b0b532b9dbd3e1f7a55a771c0d1344a9876d0b2dd604321b47')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0023    ', N'TranTheHao', N'b27d7d09ca9117ab3c97c6d63b8b7427723f422fb8059e73e6a0743400e265f4')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0024    ', N'NguyenVanSang', N'b33c396195ffdc86150c566af67e9d9492a19df5323401d86b68b811e9f1c0a9')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0025    ', N'TranThuDao', N'b0f2cbc3e5433e0daf7908385540bd14399935b1400d3334fb5cdf2159ed3eb2')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0026    ', N'HoHongThanh', N'b7f845646c9bd188d502a89d5cea6ffeed1deea9fc999a3b0e41e0d51e00ccaa')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0027    ', N'NguyenTuanAnh', N'158e29ca030f758a53656753f6e5aa1c73f956906942c62c032355017ccdacb5')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0028    ', N'DoanThanhNgoc', N'15c9139a00a4d1b30f4570054ff52b46dbd40f19a7fb7029c42343c9b7e104fc')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0029    ', N'NguyenTuongVy', N'e1ac1961f29980b995a81da62076505fe4dd990626b89a446754f7b34e1f7d10')
INSERT [dbo].[LoginNhanVien] ([MaNV], [TenDN], [MatKhau]) VALUES (N'NV0030    ', N'ThaiQuocMinh', N'ade8d6bdf6c46a737fb15471602c0234d1fe65b8b5594cd6a35ebc3ca1d45411s')
/****** Object:  Table [dbo].[KhaNangViTinhCuaNhanVien]    Script Date: 12/09/2015 14:54:40 ******/
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
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0001    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0001    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0002    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0002    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0003    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0003    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0004    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0004    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0005    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0005    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0006    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0006    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0007    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0007    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0008    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0008    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0009    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0009    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0010    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0010    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0011    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0011    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0012    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0013    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0014    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0015    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0016    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0017    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0018    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0019    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0020    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0021    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0022    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0023    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0024    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0024    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0025    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0025    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0026    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0026    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0027    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0027    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0028    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0028    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0029    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0029    ', N'Word')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0030    ', N'Excel')
INSERT [dbo].[KhaNangViTinhCuaNhanVien] ([MaNV], [TenPhanMem]) VALUES (N'NV0030    ', N'Word')
/****** Object:  StoredProcedure [dbo].[usp_TaoMaHoaDon]    Script Date: 12/09/2015 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_TaoMaHoaDon] @MaMoi char(10) output
As
Begin
	Declare @so int
	Select top 1 @MaMoi = MaDatMon
	From DatMon
	Order By MaDatMon DESC
	
	if ISNULL(@MaMoi, '') = ''
	Begin
		set @MaMoi = 'HD0001'
		return 1
	End
	
	set @so = SUBSTRING(RTRIM(@MaMoi), PATINDEX('%[1-9]%', @MaMoi), LEN(@MaMoi) - PATINDEX('%[1-9]%', @MaMoi) + 1) + 1
	set @MaMoi = 'HD' + REPLICATE('0', LEN(@MaMoi) - 2 - LEN(@so)) + CAST(@so as varchar(5))
End
GO
/****** Object:  StoredProcedure [dbo].[usp_TaoMaCTDM]    Script Date: 12/09/2015 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_TaoMaCTDM] @SoBan int, @MaMoi char(10) output
As
Begin
	Declare @kt bit = 0
	Declare @len int
	Declare @chuoi char(5)
	Declare @so int
	
	Select top 1 @MaMoi = RIGHT(RTRIM(MaChuyen), LEN(MaChuyen)/2)
	From ChiTietDatMon
	--Cắt chuỗi MaChuyen thành đôi lấy số để xét
	--Tìm số trong mã chuyển để sắp xếp
	Order by cast(SUBSTRING(RIGHT(RTRIM(MaChuyen), LEN(MaChuyen)/2), PATINDEX('%[1-9]%', RIGHT(RTRIM(MaChuyen), LEN(MaChuyen)/2)), LEN(MaChuyen) /2 - PATINDEX('%[1-9]%', RIGHT(RTRIM(MaChuyen), LEN(MaChuyen)/2)) + 1) as int) DESC
	if ISNULL(RTRIM(@MaMoi), '') = ''
	Begin
		set @kt = 1
		set @MaMoi = '001'
	End
	
	set @len = LEN(@MaMoi)
	set @so = SUBSTRING(@MaMoi, PATINDEX('%[1-9]%', @MaMoi), @len - PATINDEX('%[1-9]%', @MaMoi) + 1)
	
	if @kt = 0
	Begin
		set @so = @so + 1
	End
	
	set @MaMoi = REPLICATE('0', @len - LEN(@SoBan)) + RTRIM(CAST(@SoBan as char(5))) + '-' + REPLICATE('0', @len - LEN(@So)) + RTRIM(CAST(@so as varchar(5)))
	
End
GO
/****** Object:  Table [dbo].[PhieuNhan]    Script Date: 12/09/2015 14:54:40 ******/
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
INSERT [dbo].[PhieuNhan] ([MaPG], [MaPN], [MaNV], [TongTien], [NgayLap], [GhiChu]) VALUES (N'PG0001    ', N'PN0001    ', N'NV0030    ', 2000.0000, CAST(0x74390B00 AS Date), NULL)
INSERT [dbo].[PhieuNhan] ([MaPG], [MaPN], [MaNV], [TongTien], [NgayLap], [GhiChu]) VALUES (N'PG0002    ', N'PN0002    ', N'NV0030    ', 4000.0000, CAST(0x74390B00 AS Date), NULL)
INSERT [dbo].[PhieuNhan] ([MaPG], [MaPN], [MaNV], [TongTien], [NgayLap], [GhiChu]) VALUES (N'PG0003    ', N'PN0003    ', N'NV0030    ', 2000.0000, CAST(0x74390B00 AS Date), NULL)
INSERT [dbo].[PhieuNhan] ([MaPG], [MaPN], [MaNV], [TongTien], [NgayLap], [GhiChu]) VALUES (N'PG0004    ', N'PN0004    ', N'NV0030    ', 2000.0000, CAST(0x74390B00 AS Date), NULL)
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/09/2015 14:54:40 ******/
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
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0001    ', 200, 6, 1000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0002    ', 200, 6, 1000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0004    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0005    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0013    ', 1, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0018    ', 2, 4, 10000.0000, 20000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0019    ', 2, 4, 10000.0000, 20000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0020    ', 2, 4, 10000.0000, 20000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0022    ', 2, 4, 10000.0000, 20000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0023    ', 2, 4, 10000.0000, 20000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0024    ', 2, 4, 10000.0000, 20000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0031    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0032    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0040    ', 5, 4, 20000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0001    ', N'SP0059    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0006    ', 200, 6, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0007    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0008    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0009    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0010    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0011    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0012    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0014    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0015    ', 5, 4, 10000.0000, 50000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0016    ', 10, 4, 10000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0017    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0021    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0025    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0026    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0027    ', 50, 4, 10000.0000, 5000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0028    ', 100, 7, 10000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0029    ', 5, 4, 20000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0030    ', 5, 4, 20000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0033    ', 10, 4, 20000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0034    ', 10, 4, 20000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0035    ', 10, 4, 20000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0036    ', 10, 4, 10000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0037    ', 10, 4, 20000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0056    ', 2000, 5, 10000.0000, 20000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0057    ', 10, 4, 10000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0058    ', 100, 4, 100000.0000, 10000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0060    ', 10, 4, 10000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0061    ', 10, 4, 10000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0063    ', 10, 4, 10000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0064    ', 50, 11, 50000.0000, 2500000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0065    ', 50, 4, 20000.0000, 1000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0066    ', 20, 4, 20000.0000, 400000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0067    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0002    ', N'SP0068    ', 20, 4, 10000.0000, 200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0038    ', 5, 4, 20000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0039    ', 5, 4, 20000.0000, 100000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0041    ', 10000, 5, 10000.0000, 100000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0042    ', 20000, 5, 10000.0000, 200000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0043    ', 20000, 5, 10000.0000, 200000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0044    ', 20000, 5, 10000.0000, 200000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0045    ', 20000, 5, 10000.0000, 200000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0046    ', 20000, 5, 10000.0000, 200000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0003    ', N'SP0047    ', 20000, 5, 10000.0000, 200000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0004    ', N'SP0048    ', 240000, 1, 10000.0000, 2400000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0004    ', N'SP0049    ', 240000, 1, 10000.0000, 2400000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0004    ', N'SP0050    ', 240000, 1, 10000.0000, 2400000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0004    ', N'SP0051    ', 240000, 1, 10000.0000, 2400000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0004    ', N'SP0052    ', 240000, 1, 10000.0000, 2400000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0004    ', N'SP0053    ', 100, 1, 200000.0000, 20000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [MaDV], [DonGia], [TongTien]) VALUES (N'PN0004    ', N'SP0054    ', 100, 1, 200000.0000, 20000000.0000)
/****** Object:  Table [dbo].[ChiTietPhieuNhan]    Script Date: 12/09/2015 14:54:40 ******/
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
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0001    ', 200, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0002    ', 200, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0004    ', 20, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0005    ', 20, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0013    ', 1, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0018    ', 1, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0019    ', 2, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0020    ', 2, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0022    ', 2, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0023    ', 2, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0024    ', 2, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0031    ', 5, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0032    ', 5, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0040    ', 5, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0001    ', N'SP0059    ', 20, N'PN0001    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0006    ', 200, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0007    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0008    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0009    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0010    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0011    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0012    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0014    ', 20, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0015    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0016    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0017    ', 20, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0021    ', 20, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0025    ', 20, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0026    ', 20, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0027    ', 50, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0028    ', 100, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0029    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0030    ', 5, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0033    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0034    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0035    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0036    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0037    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0056    ', 2000, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0057    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0058    ', 100, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0060    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0061    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0063    ', 10, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0064    ', 50, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0065    ', 50, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0066    ', 20, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0067    ', 20, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0002    ', N'SP0068    ', 20, N'PN0002    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0003    ', N'SP0038    ', 5, N'PN0003    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0003    ', N'SP0039    ', 5, N'PN0003    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0003    ', N'SP0041    ', 10000, N'PN0003    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0003    ', N'SP0042    ', 10000, N'PN0003    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0003    ', N'SP0043    ', 20000, N'PN0003    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0003    ', N'SP0044    ', 20000, N'PN0003    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0003    ', N'SP0046    ', 20000, N'PN0003    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0003    ', N'SP0047    ', 20000, N'PN0003    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0004    ', N'SP0048    ', 240000, N'PN0004    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0004    ', N'SP0049    ', 240000, N'PN0004    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0004    ', N'SP0050    ', 240000, N'PN0004    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0004    ', N'SP0051    ', 240000, N'PN0004    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0004    ', N'SP0052    ', 240000, N'PN0004    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0004    ', N'SP0053    ', 100, N'PN0004    ')
INSERT [dbo].[ChiTietPhieuNhan] ([MaPG], [MaSP], [SoLuong], [MaPN]) VALUES (N'PG0004    ', N'SP0054    ', 100, N'PN0004    ')
/****** Object:  Check [CK_NhanVien_CMND]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_NhanVien_CMND] CHECK  ((len([cmnd])=(9) OR len([cmnd])=(12)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_NhanVien_CMND]
GO
/****** Object:  ForeignKey [FK_NhanVien_ChucVuNhanVien]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVuNhanVien] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVuNhanVien] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVuNhanVien]
GO
/****** Object:  ForeignKey [FK_NhaCungCap_Email_NhaCungCap]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[NhaCungCap_Email]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_Email_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[NhaCungCap_Email] CHECK CONSTRAINT [FK_NhaCungCap_Email_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_NhaCungCap_DienThoai_NhaCungCap]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[NhaCungCap_DienThoai]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_DienThoai_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[NhaCungCap_DienThoai] CHECK CONSTRAINT [FK_NhaCungCap_DienThoai_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_SanPham_LoaiDonViTinh]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiDonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[LoaiDonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiDonViTinh]
GO
/****** Object:  ForeignKey [FK_ÐatMon_Ban]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[DatMon]  WITH CHECK ADD  CONSTRAINT [FK_ÐatMon_Ban] FOREIGN KEY([SoBan])
REFERENCES [dbo].[Ban] ([SoBan])
GO
ALTER TABLE [dbo].[DatMon] CHECK CONSTRAINT [FK_ÐatMon_Ban]
GO
/****** Object:  ForeignKey [FK_LuuTruDanhSachMonAnSoLuongKHoanThanh_MonAnDoUong_SoLuong]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[LuuTruDanhSachMonAnSoLuongKHoanThanh]  WITH CHECK ADD  CONSTRAINT [FK_LuuTruDanhSachMonAnSoLuongKHoanThanh_MonAnDoUong_SoLuong] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAnDoUong] ([MaMon])
GO
ALTER TABLE [dbo].[LuuTruDanhSachMonAnSoLuongKHoanThanh] CHECK CONSTRAINT [FK_LuuTruDanhSachMonAnSoLuongKHoanThanh_MonAnDoUong_SoLuong]
GO
/****** Object:  ForeignKey [FK_LuuTruDanhSachMonAnChoNhaBep_MonAn_SoLuong]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[LuuTruDanhSachMonAnNhaBepHoanThanh]  WITH CHECK ADD  CONSTRAINT [FK_LuuTruDanhSachMonAnChoNhaBep_MonAn_SoLuong] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAnDoUong] ([MaMon])
GO
ALTER TABLE [dbo].[LuuTruDanhSachMonAnNhaBepHoanThanh] CHECK CONSTRAINT [FK_LuuTruDanhSachMonAnChoNhaBep_MonAn_SoLuong]
GO
/****** Object:  ForeignKey [FK_LIchSuSanPham_SanPham]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[LuuTruSanPhamDaDung]  WITH CHECK ADD  CONSTRAINT [FK_LIchSuSanPham_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[LuuTruSanPhamDaDung] CHECK CONSTRAINT [FK_LIchSuSanPham_SanPham]
GO
/****** Object:  ForeignKey [FK_LichLamViec_Ban]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD  CONSTRAINT [FK_LichLamViec_Ban] FOREIGN KEY([SoBan])
REFERENCES [dbo].[Ban] ([SoBan])
GO
ALTER TABLE [dbo].[LichLamViec] CHECK CONSTRAINT [FK_LichLamViec_Ban]
GO
/****** Object:  ForeignKey [FK_LichLamViec_LichCa]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD  CONSTRAINT [FK_LichLamViec_LichCa] FOREIGN KEY([ThangNam], [Ca])
REFERENCES [dbo].[LichCa] ([NamThang], [Ca])
GO
ALTER TABLE [dbo].[LichLamViec] CHECK CONSTRAINT [FK_LichLamViec_LichCa]
GO
/****** Object:  ForeignKey [FK_LichLamViec_NhanVien]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD  CONSTRAINT [FK_LichLamViec_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LichLamViec] CHECK CONSTRAINT [FK_LichLamViec_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietLamMon_MonAnDoUong_SoLuong]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[ChiTietLamMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLamMon_MonAnDoUong_SoLuong] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAnDoUong] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietLamMon] CHECK CONSTRAINT [FK_ChiTietLamMon_MonAnDoUong_SoLuong]
GO
/****** Object:  ForeignKey [FK_ChiTietLamMon_NguyenLieu]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[ChiTietLamMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLamMon_NguyenLieu] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietLamMon] CHECK CONSTRAINT [FK_ChiTietLamMon_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietLamMonMacDinh_LoaiDonViTinh]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[ChiTietLamMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLamMonMacDinh_LoaiDonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[LoaiDonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[ChiTietLamMon] CHECK CONSTRAINT [FK_ChiTietLamMonMacDinh_LoaiDonViTinh]
GO
/****** Object:  ForeignKey [FK_ChiTietDatMon_DatMon]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[ChiTietDatMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatMon_DatMon] FOREIGN KEY([MaDatMon])
REFERENCES [dbo].[DatMon] ([MaDatMon])
GO
ALTER TABLE [dbo].[ChiTietDatMon] CHECK CONSTRAINT [FK_ChiTietDatMon_DatMon]
GO
/****** Object:  ForeignKey [FK_ChiTietDatMon_MonAn_SoLuong]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[ChiTietDatMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatMon_MonAn_SoLuong] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAnDoUong] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietDatMon] CHECK CONSTRAINT [FK_ChiTietDatMon_MonAn_SoLuong]
GO
/****** Object:  ForeignKey [FK_DatHang_NhaCungCap]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_DatHang_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_DatHang_NhanVien]    Script Date: 12/09/2015 14:54:30 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_DatHang_NhanVien]
GO
/****** Object:  ForeignKey [FK_LoginNhanVien_NhanVien]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[LoginNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_LoginNhanVien_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LoginNhanVien] CHECK CONSTRAINT [FK_LoginNhanVien_NhanVien]
GO
/****** Object:  ForeignKey [FK_KhaNangViTinhCuaNhanVien_NhanVien]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[KhaNangViTinhCuaNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_KhaNangViTinhCuaNhanVien_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhaNangViTinhCuaNhanVien] CHECK CONSTRAINT [FK_KhaNangViTinhCuaNhanVien_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuGiao_NhanVien]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[PhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhan] CHECK CONSTRAINT [FK_PhieuGiao_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuNhan_PhieuNhap]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[PhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhan_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[PhieuNhan] CHECK CONSTRAINT [FK_PhieuNhan_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_LoaiDonViTinh]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_LoaiDonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[LoaiDonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_LoaiDonViTinh]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_NguyenLieu]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_NguyenLieu] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_PhieuNhap]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuGiao_NguyenLieu]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiao_NguyenLieu] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan] CHECK CONSTRAINT [FK_ChiTietPhieuGiao_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuGiao_PhieuGiao]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiao_PhieuGiao] FOREIGN KEY([MaPG])
REFERENCES [dbo].[PhieuNhan] ([MaPG])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan] CHECK CONSTRAINT [FK_ChiTietPhieuGiao_PhieuGiao]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhan_ChiTietPhieuNhap]    Script Date: 12/09/2015 14:54:40 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhan_ChiTietPhieuNhap] FOREIGN KEY([MaPN], [MaSP])
REFERENCES [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan] CHECK CONSTRAINT [FK_ChiTietPhieuNhan_ChiTietPhieuNhap]
GO
