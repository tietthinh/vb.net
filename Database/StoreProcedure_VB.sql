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

Declare @MaMoi char(10)
--exec spDSDatMonTrongNgayInsert 'DA0001', 4,'12456', 1, @MaMoi output
exec spDSDatMonTrongNgayInsert @MaMon = 'DA0001', @SoBan = 7, @MaMoi = @MaMoi output
print @MaMoi
GO

if OBJECT_ID('spDSDatMonTrongNgayUpdateTinhTrang') is not null
Begin
	drop proc spDSDatMonTrongNgayUpdateTinhTrang
End
GO
create proc spDSDatMonTrongNgayUpdateTinhTrang @MaChuyen char(10), @TinhTrang int
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


if OBJECT_ID('spDSDatMonTrongNgayUpdateSoLuong') is not null
Begin
	drop proc spDSDatMonTrongNgayUpdateSoLuong
End
GO
create proc spDSDatMonTrongNgayUpdateSoLuong @MaChuyen char(10), @SL int
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

if OBJECT_ID('spDSDatMonTrongNgayUpdateSLGhiChu') is not null
Begin
	drop proc spDSDatMonTrongNgayUpdateSLGhiChu
End
GO
create proc spDSDatMonTrongNgayUpdateSLGhiChu @MaChuyen char(10), @SoLuong int, @GhiChu nvarchar(50)
As
Begin
	if ISNULL(@MaChuyen,'') = ''
	Begin
		return 0
	End
	
	Update DanhSachDatMonTrongNgay set SoLuong = @SoLuong, GhiChu = @GhiChu where MaChuyen = @MaChuyen
End
GO

exec spDSDatMonTrongNgayUpdateSLGhiChu '02-0003',3, N'Không hành'

select dbo.uf_CatChuoiThanhSo('003-012', '-', 1)

if OBJECT_ID('spDSDatMonTrongNgaySelectThuNgan') is not null
Begin
	drop proc spDSDatMonTrongNgaySelectThuNgan
End
GO
create proc spDSDatMonTrongNgaySelectThuNgan @MaChuyenDau char(10), @MaChuyenCuoi char(10)
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

exec spDSDatMonTrongNgaySelectThuNgan '01-0001', '01-0004'

if OBJECT_ID('spDemMonDaDat') is not null
Begin
	drop proc spDemMonDaDat
End
GO
create proc spDemMonDaDat
As
Begin
	Select COUNT(*)
	From DanhSachDatMonTrongNgay
	Where TinhTrang = 1
End

exec spDemMonDaDat
GO
if OBJECT_ID('spDSDatMonTrongNgaySelect') is not null
Begin
	drop proc spDSDatMonTrongNgaySelect
End
GO
create proc spDSDatMonTrongNgaySelect @Time char(20)
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

exec spDSDatMonTrongNgaySelect '13:10:42.8975366'
Select MaChuyen
From DanhSachDatMonTrongNgay
where dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 1) > = dbo.uf_CatChuoiThanhSo('0002-0001', '-', 1)
exec spDSDatMonTrongNgaySelectThuNgan '02-0001', '02-0006'
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
	Select CT.MaMon, CT.MaSP, SP.TenSP, CT.SoLuong, LD.TenDV, LD.DoTangMacDinh
	From ChiTietLamMon CT, LoaiDonViTinh LD, SanPham SP
	Where MaMon = @MaMon AND LD.MaDV = CT.MaDV AND SP.MaSP = CT.MaSP
End
GO

exec spCTLamMonSelect 'DA0003'
GO

--Table SanPham
if OBJECT_ID('spLaySanPham') is not null
Begin
	drop proc spLaySanPham
End
GO
create proc spLaySanPham @TenSP nvarchar(50)
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
exec spLaySanPham N'thịt bò'

--Table LuuTruSanPhamDaDung
if TYPE_ID('dbo.DSSanPham') is not null
Begin
	if OBJECT_ID('spSanPhamDaDungInsert') is not null
	Begin
		drop proc spSanPhamDaDungInsert	
	End
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


--Table MonAnDoUong
if OBJECT_ID('spMonAnDoUongSelect') is not null
Begin
	Drop proc spMonAnDoUongSelect
End
GO
create proc spMonAnDoUongSelect @TinhTrang bit = 1
As
Begin
	Select MaMon, TenMon
	From MonAnDoUong
	where ThucDonMon = 1 AND TinhTrang = @TinhTrang
End
GO
exec spMonAnDoUongSelect
GO

if OBJECT_ID('spMonAnDoUongUpdateTinhTrangMon') is not null
Begin
	drop proc spMonAnDoUongUpdateTinhTrangMon
End
GO
create proc spMonAnDoUongUpdateTinhTrangMon @MaMon char(10), @TinhTrang bit
As
Begin
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	
	Update MonAnDoUong set TinhTrang = @TinhTrang where MaMon = @MaMon
End
Go

exec spMonAnDoUongUpdateTinhTrangMon 'DA0002', 0
--Table DatMon
if OBJECT_ID('usp_TaoMaHoaDon') is not null
Begin
	Drop proc usp_TaoMaHoaDon
End
GO
create proc usp_TaoMaHoaDon @MaMoi char(10) output
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

if OBJECT_ID('usp_LayMaDMonMoiNhat') is not null
Begin
	Drop proc usp_LayMaDMonMoiNhat
End
GO
create proc usp_LayMaDMonMoiNhat @MaNV char(10), @MaHD char(10) output
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

Declare @MaHD char(10)
exec usp_LayMaDMonMoiNhat 'NV011', @MaHD output
print N'Mã hóa đơn: ' + @MaHD