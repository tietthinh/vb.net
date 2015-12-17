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
exec spDSDatMonTrongNgayInsert @MaMon = 'DA0001', @SoBan = 4, @MaMoi = @MaMoi output
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
	
	Update DanhSachDatMonTrongNgay set TinhTrang = @TinhTrang where MaChuyen = @MaChuyen
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

exec spDSDatMonTrongNgayUpdateSLGhiChu '01-0001',3, N'Không hành'

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
	Select DS.MaMon, MA.TenMon, SUM(DS.SoLuong) as SoLuong, DS.GhiChu
	From DanhSachDatMonTrongNgay DS, MonAnDoUong MA
	Where dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 1) >= dbo.uf_CatChuoiThanhSo(@MaChuyenDau,'-', 1) AND dbo.uf_CatChuoiThanhSo(MaChuyen,'-', 1) <= dbo.uf_CatChuoiThanhSo(@MaChuyenCuoi, '-', 1)
	AND dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 0) = dbo.uf_CatChuoiThanhSo(@MaChuyenDau, '-', 0)
	AND DS.MaMon = MA.MaMon AND DS.TinhTrang = 3
	Group by DS.MaMon, Ma.TenMon, DS.SoLuong, DS.GhiChu
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
		Order by ThoiGian
	--End
End 
GO

exec spDSDatMonTrongNgaySelect '12:10:15'
Select MaChuyen
From DanhSachDatMonTrongNgay
where dbo.uf_CatChuoiThanhSo(MaChuyen, '-', 1) > = dbo.uf_CatChuoiThanhSo('0002-0001', '-', 1)
exec spDSDatMonTrongNgaySelectThuNgan '01-0001', '01-0004'
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
exec spLaySanPham N'bò'
GO

if OBJECT_ID('usp_TaoMaSanPham') is not null
Begin
	Drop proc usp_TaoMaSanPham
End
GO
create proc usp_TaoMaSanPham @MaMoi char(10) output
As
Begin
	Declare @so int
	Select top 1 @MaMoi = MaSP
	From SanPham
	Order By MaSP DESC
	
	if ISNULL(@MaMoi, '') = ''
	Begin
		set @MaMoi = 'SP0001'
		return 1
	End
	
	set @so = SUBSTRING(RTRIM(@MaMoi), PATINDEX('%[1-9]%', @MaMoi), LEN(@MaMoi) - PATINDEX('%[1-9]%', @MaMoi) + 1) + 1
	set @MaMoi = 'SP' + REPLICATE('0', LEN(@MaMoi) - 2 - LEN(@so)) + CAST(@so as varchar(5))
End
GO

Declare @MaMoi char(10)
exec usp_TaoMaSanPham @MaMoi output
print @MaMoi

GO
if OBJECT_ID('spSanPhamInsert') is not null
Begin
	drop proc spSanPhamInsert
End
GO
create proc spSanPhamInsert @TenSP char(10), @SoLuongTon int, @DonViTinh int
As
Begin
	if ISNULL(@TenSP,'') = ''
	Begin
		return 0
	End
	
	if @SoLuongTon <= 0
	Begin
		return 0
	End
	
	Declare @MaSP char(10)
	exec usp_TaoMaSanPham @MaSP output
	insert into SanPham values(@MaSP, @TenSP, @SoLuongTon, @DonViTinh)
End
GO

if OBJECT_ID('spSanPhamDelete') is not null
Begin
	drop proc spSanPhamDelete
End
GO
create proc spSanPhamDelete @MaSP char(10)
As
Begin
	if ISNULL(@MaSP,'') = ''
	Begin
		return 0
	End
	
	Delete LuuTruSanPhamDaDung where MaSP = @MaSP
	Insert into LuuTruCTPhieuNhan(MaPG, MaPN, MaSP, SoLuong) Select MaPG, MaPN, MaSP, SoLuong From ChiTietPhieuNhan
	Delete ChiTietPhieuNhan where MaSP = @MaSP
	Insert into LuuTruCTPhieuNhap(MaPN, MaSP, MaDV, DonGia, SoLuong, TongTien)  Select MaPN, MaSP, MaDV, DonGia, SoLuong, TongTien From ChiTietPhieuNhap
	Delete ChiTietPhieuNhap where MaSP = @MaSP
	Insert into LuuTruCTLamMon(MaMon, MaSP, SoLuong, MaDV) Select MaMon, MaSP, SoLuong, MaDV From ChiTietLamMon where MaSP = @MaSP
	Delete ChiTietLamMon where MaSP = @MaSP
	Insert into LuuTruSanPham(MaSP, TenSP) Select MaSP, TenSP From SanPham where MaSP = @MaSP
	Delete SanPham where MaSP = @MaSP
End
GO

if OBJECT_ID('spSanPhamUpdate') is not null
Begin
	Drop proc spSanPhamUpdate
End
GO
create proc spSanPhamUpdate @MaSP char(10), @TenSP nvarchar(70), @SoLuong float, @MaDV int
As
Begin
	if ISNULL(@MaSP,'') = ''
	Begin
		return 0
	End
	
	Update SanPham set TenSP = @TenSP, SoLuongTon = @SoLuong, MaDV = @MaDV where MaSP = @MaSP
End
GO

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
	SoLuong float,
	SoLuongMotMon float
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
	
	Insert into LuuTruSanPhamDaDung(MaSP, SoLuong, SoLuongDungMotMon ,NgayDung) Select MaSP, SoLuong, SoLuongMotMon, GETDATE() From @DS
End
GO

exec spCTLamMonSelect 'DA0003'
--Declare @DS As DSSanPham
--insert into @DS values('SP0006', 400, 4), ('SP0007', 10, 0.1)
--exec spSanPhamDaDungInsert @DS

--DBCC CHECKIDENT (LuuTruSanPhamDaDung, RESEED, 13)

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

if OBJECT_ID('LayGiaTienMon') is not null
Begin
	drop proc LayGiaTienMon
End
GO
create proc LayGiaTienMon  @MaMon char(10)
As
Begin
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	
	Select GiaTienHienTai
	From MonAnDoUong
	Where MaMon = @MaMon
End
Go

exec LayGiaTienMon 'DA0001'

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

if OBJECT_ID('spHoaDonInsert') is not null
Begin
	Drop proc spHoaDonInsert
End
GO
create proc spHoaDonInsert
@MaNV char(10),
@SoBan int, 
@SoLuongKhach int, 
@GhiChu nvarchar(50) = null,
@MaHD char(10) output
As
Begin
	Declare @MaMoi char(10)
	exec usp_TaoMaHoaDon @MaHD output
	
	Insert into HoaDon values(@MaHD, @MaNV, GETDATE(), @SoBan, @SoLuongKhach, @MaMoi, NULL, @GhiChu, 0)
End
GO

if OBJECT_ID('spHoaDonUpdate') is not null
Begin
	Drop proc spHoaDonUpdate
End
GO
create proc spHoaDonUpdate @MaHD char(10), @TongTien int, @TinhTrang bit
As
Begin
	if ISNULL(@MaHD,'') = ''
	Begin
		return 0
	End
	
	Update HoaDon set TongTien = @TongTien, TinhTrang = @TinhTrang where MaHoaDon = @MaHD 
End
GO

if OBJECT_ID('usp_GopHoaDon') is not null
Begin
	drop proc usp_GopHoaDon
End
GO
create proc usp_GopHoaDon @MaHD char(10), @MaHDGop char(10)
As
Begin
	if ISNULL(@MaHD,'') = '' OR ISNULL(@MaHDGop,'') = ''
	Begin
		return 0
	End
	
	Update HoaDon set MaHDChung = @MaHD where MaHoaDon = @MaHDGop
End
GO
Declare @MaMoi char(10)
exec spHoaDonInsert 'NV0009', 4, 4, N'Thiếu nợ', @MaMoi output
exec spHoaDonUpdate 'HD0008', 100000, 1

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
GO
if OBJECT_ID('spChiTietHoaDonInsert') is not null
Begin
	drop proc spChiTietHoaDonInsert
End
GO
create proc spChiTietHoaDonInsert @MaHD char(10), @MaMon char(10), @SoLuong int, @GiaMotMon int, @ThanhTien int, @GhiChu nvarchar(50)
As
Begin
	if ISNULL(@MaHD,'') = ''
	Begin
		return 0
	End
	
	insert into ChiTietHoaDon values(@MaHD, @MaMon, @SoLuong, @GiaMotMon, @ThanhTien, @GhiChu)
End
GO

--Table Ban
if OBJECT_ID('CapNhapTinhTrangBan') is not null
Begin
	drop proc CapNhapTinhTrangBan
End
GO
create proc CapNhapTinhTrangBan @SoBan int, @TinhTrang bit
As
Begin
	if @SoBan = 0
	Begin
		return 0
	End
	
	Update Ban set TinhTrang = @TinhTrang where SoBan = @SoBan
End
GO

--Table NhaCungCap_DienThoai
if OBJECT_ID('spNhaCungCap_DienThoaiSelect') is not null
Begin
	drop proc spNhaCungCap_DienThoaiSelect
End
GO
create proc spNhaCungCap_DienThoaiSelect @MaNCC char(10), @SDT char(12)
As
Begin
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
	Select SDT
	From NhaCungCap_DienThoai
	Where MaNCC = @MaNCC
End
GO

if OBJECT_ID('spNhaCungCap_DienThoaiInsert') is not null
Begin
	drop proc spNhaCungCap_DienThoaiInsert
End
GO
create proc spNhaCungCap_DienThoaiInsert @MaNCC char(10), @SDT char(12)
As
Begin
	
	if ISNULL(@SDT,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From NhaCungCap_DienThoai Where MaNCC = @MaNCC AND SDT = @SDT)
	Begin
		return 0
	End
	
	Insert into NhaCungCap_DienThoai values(@MaNCC, @SDT)
End
GO

if OBJECT_ID('spNhaCungCap_DienThoaiUpdate') is not null
Begin
	drop proc spNhaCungCap_DienThoaiUpdate
End
GO
create proc spNhaCungCap_DienThoaiUpdate @MaNCC char(10), @SDTCu char(12), @SDTMoi char(12)
As
Begin
	if ISNULL(@SDTCu,'') = '' OR ISNULL(@SDTMoi,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From NhaCungCap_DienThoai Where MaNCC = @MaNCC AND SDT = @SDTMoi)
	Begin
		return 0
	End
	
	Update NhaCungCap_DienThoai set SDT = @SDTMoi where MaNCC = @MaNCC AND SDT = @SDTCu
End
GO

--Table NhaCungCap_Email
if OBJECT_ID('spNhaCungCap_EmailSelect') is not null
Begin
	drop proc spNhaCungCap_EmailSelect
End
GO
create proc spNhaCungCap_EmailSelect @MaNCC char(10), @Email varchar(50)
As
Begin
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
	Select Email
	From NhaCungCap_Email
	Where MaNCC = @MaNCC
End
GO

if OBJECT_ID('spNhaCungCap_EmailInsert') is not null
Begin
	drop proc spNhaCungCap_EmailInsert
End
GO
create proc spNhaCungCap_EmailInsert @MaNCC char(10), @Email varchar(50)
As
Begin

	if ISNULL(@Email,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From NhaCungCap_Email Where MaNCC = @MaNCC AND Email = @Email)
	Begin
		return 0
	End
	
	Insert into NhaCungCap_DienThoai values(@MaNCC, @Email)
End
GO

if OBJECT_ID('spNhaCungCap_EmailUpdate') is not null
Begin
	drop proc spNhaCungCap_EmailUpdate
End
GO
create proc spNhaCungCap_EmailUpdate @MaNCC char(10), @EmailCu char(50), @EmailMoi char(50)
As
Begin
	if ISNULL(@EmailCu,'') = '' OR ISNULL(@EmailMoi,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From NhaCungCap_Email Where MaNCC = @MaNCC AND Email = @EmailMoi)
	Begin
		return 0
	End
	
	Update NhaCungCap_Email set Email = @EmailMoi where MaNCC = @MaNCC AND Email = @EmailCu
End
GO

sp_dropmessage @msgnum = 50001;
GO
sp_addmessage @msgnum = 50001, @Severity = 16, @msgtext = '%u'
if OBJECT_ID('tg_LuuTruSanPhamDaDung_Them') is not null
Begin
	drop trigger tg_LuuTruSanPhamDaDung_Them
End
GO
create trigger tg_LuuTruSanPhamDaDung_Them on LuuTruSanPhamDaDung
for insert
As
Begin
	Declare cur cursor for Select STT, MaSP, SoLuong, SoLuongDungMotMon From inserted order by SoLuong ASC
	Declare @MaSP char(10)
	Declare @SoLuong float
	Declare @SoLuongMacDinh float
	Declare @STT1 int
	open cur
	fetch next from cur into @STT1, @MaSP, @SoLuong, @SoLuongMacDinh
	
	while @@FETCH_STATUS = 0
	Begin
		if @SoLuong <> 0
			Begin
				Declare @SoLuongKho float
				Select @SoLuongKho = SoLuongTon
				From SanPham
				Where MaSP = @MaSP
				
				Declare @SoLuongSeDung float
				set @SoLuongSeDung = @SoLuongKho - @SoLuong
				
				if @SoLuongSeDung < 0
				Begin
					Declare @SoLuongMonKLD int
					set @SoLuongSeDung = ABS(@SoLuongSeDung) / @SoLuongMacDinh
					set @SoLuongMonKLD = CAST(@SoLuongSeDung as int)
					
					Declare curR cursor for Select MaSP, SoLuong From inserted order by SoLuong ASC
					Declare @MaSPR char(10)
					Declare @SoLuongR float
					
					open curR
					fetch next from curR into @MaSPR, @SoLuongR
					while @@FETCH_STATUS = 0
					Begin
						if @MaSPR = @MaSP
						Begin
							break
						End
						
						Update SanPham set SoLuongTon = SoLuongTon + @SoLuongR where MaSP = @MaSPR
						fetch next from curR into @MaSPR, @SoLuongR
					End
					close curR
					deallocate curR
					
					Declare curU cursor for Select STT, MaSP, SoLuong, SoLuongDungMotMon From inserted order by SoLuong ASC
					Declare @MaSPU char(10)
					Declare @SoLuongU float
					Declare @SoLuongMotMonU float
					Declare @STT int
					
					open curU
					fetch next from curU into @STT, @MaSPU, @SoLuongU, @SoLuongMotMonU
					
					while @@FETCH_STATUS = 0
					Begin
						Update SanPham set SoLuongTon = SoLuongTon - (@SoLuongU - @SoLuongMonKLD * @SoLuongMotMonU) where MaSP = @MaSPU
						Declare @SoLuongLamDuoc float
						set @SoLuongLamDuoc = @SoLuongU - @SoLuongMonKLD * @SoLuongMotMonU
						if @SoLuongLamDuoc = 0
						Begin
							Delete LuuTruSanPhamDaDung where STT = @STT
						End
						Else
						Begin
							Update LuuTruSanPhamDaDung set SoLuong = @SoLuongLamDuoc where STT = @STT
						End
						fetch next from curU into @STT, @MaSPU, @SoLuongU, @SoLuongMotMonU
					End
					close curU
					deallocate curU
					
					Raiserror(50001, 16, 1, @SoLuongMonKLD)
					close cur
					deallocate cur
					return 
			End
			Else
			Begin
				Update SanPham set SoLuongTon = @SoLuongSeDung where MaSP = @MaSP
			End
		End
		Else
		Begin
			Delete LuuTruSanPhamDaDung where STT = @STT1
		End
		
		
		fetch next from cur into @STT1, @MaSP, @SoLuong, @SoLuongMacDinh
	End
	close cur
	deallocate cur
End
GO
