--Table DanhSachMonAnTrongNgay
if OBJECT_ID('usp_TaoMaChuyen') is not null
Begin
	Drop proc usp_TaoMaChuyen
End
GO
create proc usp_TaoMaChuyen @SoBan int, @MaMoi char(10) output
As
Begin
	Declare @kt bit = 0
	Declare @len int
	Declare @chuoi char(5)
	Declare @so int
	
	Select top 1 @MaMoi = RIGHT(RTRIM(MaChuyen), LEN(MaChuyen)/2)
	From DanhSachDatMonTrongNgay
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
	
	set @MaMoi = REPLICATE('0', @len - LEN(@SoBan)) + RTRIM(CAST(@SoBan as char(5))) + '-' + REPLICATE('0', @len - LEN(@so)) + RTRIM(CAST(@so as char(5)))
	
End
GO
Declare @MaMoi char(10)
exec usp_TaoMaChuyen 8, @MaMoi output
print N'Mã mới: ' + @MaMoi
GO

if OBJECT_ID('spDSDatMonTrongNgayInsert') is not null
Begin
	Drop proc spDSDatMonTrongNgayInsert
End
GO
create proc spDSDatMonTrongNgayInsert 
@MaMon char(10), 
@SoLuong int = 1, 
@IP char(6), 
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
	Insert into DanhSachDatMonTrongNgay(MaChuyen, IP, MaMon, ThoiGian, SoLuong, GhiChu) values(@MaMoi, @IP, @MaMon, @Thoigian, @SoLuong, @GhiChu)
End
GO

Declare @MaMoi char(10)
--exec spDSDatMonTrongNgayInsert 'DA0001', 4,'12456', 1, @MaMoi output
exec spDSDatMonTrongNgayInsert @MaMon = 'DA0001', @IP = '123456', @SoBan = 2, @MaMoi = @MaMoi output
print @MaMoi

if OBJECT_ID('spDSDatMonTrongNgayUpate') is not null
Begin
	drop proc spDSDatMonTrongNgayUpate
End
GO
create proc spDSDatMonTrongNgayUpate 
@MaChuyen char(10),
@SoLuong int, 
@TinhTrang int,
@GhiChu nvarchar(50)
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
	
	Update DanhSachDatMonTrongNgay set TinhTrang = @TinhTrang, SoLuong = @SoLuong, GhiChu = @GhiChu where MaChuyen = @MaChuyen
End
GO

exec spDSDatMonTrongNgayUpate '001-009', 2, 2, N'không hành'

GO
if OBJECT_ID('uf_CatChuoiThanhSo') is not null
Begin
	drop function uf_CatChuoiThanhSo
End
GO
create function uf_CatChuoiThanhSo(@Ma char(10), @Dau char(1), @ViTri bit = 0)
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
		set @Chuoi = RIGHT(RTRIM(@Ma), CHARINDEX(@Dau, @Ma) - 1)
	End

	set @so = SUBSTRING(@Chuoi, PATINDEX('%[1-9]%', @Chuoi), LEN(@Chuoi) - PATINDEX('%[1-9]%', @Chuoi) + 1)
	return @So
End
GO

select dbo.uf_CatChuoiThanhSo('003-012', '-', 1)

if OBJECT_ID('spDSDatMonTrongNgaySelect') is not null
Begin
	drop proc spDSDatMonTrongNgaySelect
End
GO
create proc spDSDatMonTrongNgaySelect @MaChuyenDau char(10), @MaChuyenCuoi char(10)
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
	Select DS.MaChuyen, DS.MaMon, MA.TenMon, DS.SoLuong, DS.ThoiGian, DS.TinhTrang, DS.GhiChu, DS.IP
	From DanhSachDatMonTrongNgay DS, MonAnDoUong MA
	Where dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 1) >= dbo.uf_CatChuoiThanhSo(@MaChuyenDau,'-', 1) AND dbo.uf_CatChuoiThanhSo(MaChuyen,'-', 1) <= dbo.uf_CatChuoiThanhSo(@MaChuyenCuoi, '-', 1)
	AND DS.MaMon = MA.MaMon 
End
GO

Select MaChuyen
From DanhSachDatMonTrongNgay
where dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 1) > = dbo.uf_CatChuoiThanhSo('002-011    ', '-', 1)
exec spDSDatMonTrongNgaySelect '001-008', '002-012'
GO

if OBJECT_ID('spDSDatMonTrongNgayDelete') is not null
Begin
	drop proc spDSDatMonTrongNgayDelete
End
GO
create proc spDSDatMonTrongNgayDelete
As
Begin
	Delete From DanhSachDatMonTrongNgay
End
GO

exec spDSDatMonTrongNgayDelete

--Table ChiTietLamMon
if OBJECT_ID('spCTLamMonSelect') is not null
Begin
	drop proc spCTLamMonSelect
End
GO
create proc spCTLamMonSelect @MaMon char(10)
As
Begin
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	Select CT.MaMon, CT.MaSP, SP.TenSP, CT.SoLuong, LD.TenDV
	From ChiTietLamMon CT, LoaiDonViTinh LD, SanPham SP
	Where MaMon = @MaMon AND LD.MaDV = CT.MaDV AND SP.MaSP = CT.MaSP
End
GO

exec spCTLamMonSelect 'DA0003'
GO


--Table LuuTruSanPhamDaDung
if OBJECT_ID('DSSanPham') is not null
Begin
	drop type dbo.DSSanPham
End
GO
create type DSSanPham As table
(
	MaSP char(10),
	SoLuong int
)
GO

if OBJECT_ID('spSanPhamDaDungInsert') is not null
Begin
	drop proc spSanPhamDaDungInsert
End
GO
create proc spSanPhamDaDungInsert @DS As DSSanPham Readonly
As
Begin
	if not exists(Select * from @DS)
	Begin
		return
	End
	
	Insert into LuuTruSanPhamDaDung(MaSP, SoLuong, NgayDung) Select MaSP, SoLuong, GETDATE() From @DS
End
GO

Declare @DS As DSSanPham
insert into @DS values('SP0004', 1), ('SP0014', 2), ('SP0027', 3)
exec spSanPhamDaDungInsert @DS

--Reset auto increase
DBCC CHECKIDENT (LuuTruSanPhamDaDung, RESEED, 4)


--Table MonAnDoUong
if OBJECT_ID('spMonAnDoUongSelect') is not null
Begin
	Drop proc spMonAnDoUongSelect
End
GO
create proc spMonAnDoUongSelect
As
Begin
	Select MaMon, TenMon, GiaTienHienTai
	From MonAnDoUong
	where ThucDonMon = 1
End
GO

exec spMonAnDoUongSelect
--Table DatMon
if OBJECT_ID('usp_TaoMaHoaDon') is not null
Begin
	Drop proc usp_ThemHoaDon
End
GO
create proc usp_TaoMaHoaDon @MaMoi char(10) output
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

Declare @MaDatMon char(10)
exec usp_TaoMaHoaDon @MaDatMon output
print N'Mã mới: ' + @MaDatMon
GO

if OBJECT_ID('usp_ThemHoaDonMoi') is not null
Begin
	Drop proc usp_ThemHoaDonMoi
End
GO
create proc usp_ThemHoaDonMoi 
@MaNV char(10),
@SoBan int, 
@SoBanChung int = null, 
@SoLuongKhach int, 
@ThoiGian datetime, 
@TongTien int, 
@GhiChu nvarchar(50) = null
As
Begin
	if ISNULL(@SoBanChung, '') = ''
	Begin
		set @SoBanChung = @SoBan
	End
	
	Declare @MaMoi char(10)
	exec usp_TaoMaHoaDon @MaMoi output
	
	Insert into DatMon values(@MaMoi, @MaNV, @ThoiGian, @SoBan, @SoLuongKhach, @SoBanChung, @TongTien, @GhiChu)
End
GO

if OBJECT_ID('usp_LayMaDMonMoiNhat') is not null
Begin
	Drop proc usp_LayMaDMonMoiNhat
End
GO
create proc usp_LayMaDMonMoiNhat @MaNV char(10), @MaHD char(10) output
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

Declare @MaHD char(10)
exec usp_LayMaDMonMoiNhat 'NV011', @MaHD output
print N'Mã hóa đơn: ' + @MaHD