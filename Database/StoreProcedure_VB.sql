SP_CONFIGURE 'nested_triggers',0
GO
RECONFIGURE
GO

--@ViTri = 0 will get string in left sign want spilt, @ViTri = 1 opposite
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


--Table DanhSachDatMonTrongNgay
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
	if ISNULL(@SoBan,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	
	if @MaMoi is null
	Begin
		exec usp_TaoMaChuyen @SoBan, @MaMoi output
		Declare @Thoigian time
		set @Thoigian = CONVERT(time, SYSDATETIME())
		Insert into DanhSachDatMonTrongNgay(MaChuyen, MaMon, ThoiGian, SoLuong, TinhTrang, GhiChu) values(@MaMoi, @MaMon, @Thoigian, @SoLuong, @TinhTrang, @GhiChu)
	End
	
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
create proc spDemMonDaDat @Ma char(2), @SoLuong int output
As
Begin
	if ISNULL(@Ma,'') = ''
	Begin
		return 0
	End
	
	Select @SoLuong = COUNT(*)
	From DanhSachDatMonTrongNgay
	Where TinhTrang = 1 AND LEFT(MaMon, CHARINDEX('0', MaMon) - 1) = @Ma
End
GO
Declare @SoLuong int
exec spDemMonDaDat 'DA', @SoLuong output
print @SoLuong
GO

if OBJECT_ID('spDSDatMonTrongNgaySelect') is not null
Begin
	drop proc spDSDatMonTrongNgaySelect
End
GO
create proc spDSDatMonTrongNgaySelect @MaChuyen char(10)
As
Begin
	if ISNULL(@MaChuyen, '') = ''
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
		Select @ThoiGian = ThoiGian
		From DanhSachDatMonTrongNgay
		Where MaChuyen = @MaChuyen
		
		Select DS.MaChuyen, DS.MaMon, MA.TenMon, DS.ThoiGian, DS.SoLuong, DS.GhiChu
		From DanhSachDatMonTrongNgay DS, MonAnDoUong MA
		Where DS.ThoiGian >= @ThoiGian AND DS.ThoiGian <= DATEADD(MINUTE, 1, @ThoiGian) AND Ma.MaMon = DS.MaMon AND DS.TinhTrang = 1 AND LEFT(Ma.MaMon, CHARINDEX('0', Ma.MaMon) - 1) = 'DA'
		Order by ThoiGian
	--End
End 
GO

exec spDSDatMonTrongNgaySelect '01-0001'
GO

if OBJECT_ID('spDSDoUongTrongNgaySelect') is not null
Begin
	drop proc spDSDoUongTrongNgaySelect
End
GO
create proc spDSDoUongTrongNgaySelect @MaChuyen char(10)
As
Begin
	if ISNULL(@MaChuyen,'') = ''
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
		Select @ThoiGian = ThoiGian
		From DanhSachDatMonTrongNgay
		Where MaChuyen = @MaChuyen
		
		Select DS.MaChuyen, DS.MaMon, MA.TenMon, DS.ThoiGian, DS.SoLuong, DS.GhiChu
		From DanhSachDatMonTrongNgay DS, MonAnDoUong MA
		Where DS.ThoiGian >= @ThoiGian AND DS.ThoiGian <= DATEADD(MINUTE, 1, @ThoiGian) AND Ma.MaMon = DS.MaMon AND DS.TinhTrang = 1 AND LEFT(Ma.MaMon, CHARINDEX('0', Ma.MaMon) - 1) = 'DU'
		Order by ThoiGian
	--End
End 
GO

exec spDSDoUongTrongNgaySelect '01-0001'

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
	Select CT.MaMon, CT.MaSP, SP.TenSP, CT.SoLuong, LD.TenDV, LD.DoTangMacDinh, LD.SoThuc
	From ChiTietLamMon CT, LoaiDonViTinh LD, SanPham SP
	Where MaMon = @MaMon AND LD.MaDV = CT.MaDV AND SP.MaSP = CT.MaSP
End
GO

exec spCTLamMonSelect 'DA0003'
GO

if OBJECT_ID('spCTLamMonSelectQuanLy') is not null
Begin
	drop proc spCTLamMonSelectQuanLy
End
GO
create proc spCTLamMonSelectQuanLy @MaMon char(10)
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

exec spCTLamMonSelectQuanLy 'DA0001'

--Cần kiểm tra mã đơn vị trong bảng sản phẩm giống mã đơn vị trong bảng chi tiết làm món
if OBJECT_ID('spCTLamMonInsert') is not null
Begin
	drop proc spCTLamMonInsert
End
GO
create proc spCTLamMonInsert @MaMon char(10), @MaSP char(10), @SoLuong float, @MaDV int
As
Begin
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaSP,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From ChiTietLamMon where MaMon = @MaMon AND MaSP = @MaSP)
	Begin
		return 1
	End
	
	Insert into ChiTietLamMon values(@MaMon, @MaSP, @MaDV, @SoLuong)
End
GO

if OBJECT_ID('spCTLamMonUpdate') is not null
Begin
	drop proc spCTLamMonUpdate
End
GO
create proc spCTLamMonUpdate @MaMon char(10), @MaSPCu char(10), @MaSPMoi char(10), @SoLuong float, @MaDV int
As
Begin
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaSPCu,'') = '' OR ISNULL(@MaSPMoi,'') =''
	Begin
		return 0
	End
	
	if exists(Select * From ChiTietLamMon where MaMon = @MaMon AND MaSP = @MaSPMoi)
	Begin
		return 1
	End
	
	Update ChiTietLamMon set MaSP = @MaSPMoi, SoLuong = @SoLuong, MaDV = @MaDV where MaMon = @MaMon AND MaSP = @MaSPCu
End
GO

if OBJECT_ID('spCTLamMonDelete') is not null
Begin
	drop proc spCTLamMonDelete
End
GO
create proc spCTLamMonDelete @MaMon char(10), @MaSP char(10)
As
Begin
	if ISNULL(@MaMon,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaSP,'') = ''
	Begin
		return 0
	End
	
	Insert into LuuTruCTLamMon(MaMon, MaSP, SoLuong, MaDV) Select  MaMon, MaSP, SoLuong, MaDV From ChiTietLamMon Where MaSP = @MaSP AND MaMon = @MaMon
	Delete ChiTietLamMon where MaMon = @MaMon AND MaSP = @MaSP
End
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
	
	Select SP.MaSP, SP.TenSP, LD.TenDV, LD.DoTangMacDinh, LD.SoThuc
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
create proc spSanPhamInsert @TenSP nvarchar(70), @SoLuongTon int, @DonViTinh int
As
Begin
	if ISNULL(@TenSP,'') = ''
	Begin
		return 0
	End
	
	if @SoLuongTon < 0
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
	
	--Delete LuuTruSanPhamDaDung where MaSP = @MaSP
	--Insert into LuuTruCTPhieuNhan(MaPG, MaPN, MaSP, SoLuong) Select MaPG, MaPN, MaSP, SoLuong From ChiTietPhieuNhan where MaSP = @MaSP
	--Delete ChiTietPhieuNhan where MaSP = @MaSP
	--Insert into LuuTruCTPhieuNhap(MaPN, MaSP, MaDV, DonGia, SoLuong, ThanhTien)  Select MaPN, MaSP, MaDV, DonGia, SoLuong, ThanhTien From ChiTietPhieuNhap where MaSP = @MaSP
	--Delete ChiTietPhieuNhap where MaSP = @MaSP
	--Insert into LuuTruCTLamMon(MaMon, MaSP, SoLuong, MaDV) Select MaMon, MaSP, SoLuong, MaDV From ChiTietLamMon where MaSP = @MaSP
	--Delete ChiTietLamMon where MaSP = @MaSP
	--Insert into LuuTruSanPham(MaSP, TenSP) Select MaSP, TenSP From SanPham where MaSP = @MaSP
	--Delete SanPham where MaSP = @MaSP
	
	--Declare curPNhan cursor for Select MaPN, MaPG From PhieuNhan
	--open curPNhan
	--Declare @MaPN char(10)
	--Declare @MaPG char(10)
	--fetch next from curPNhan into @MaPN, @MaPG
	--while @@FETCH_STATUS = 0
	--Begin
	--	if not exists(Select * from ChiTietPhieuNhan where MaPG = @MaPG)
	--	Begin
	--		Insert into LuuTruPhieuNhan(MaPG, MaPN, MaNV, NgayLap, TongTien, GhiChu) Select MaPG, MaPN, MaNV, NgayLap, TongTien, GhiChu From PhieuNhan where MaPG = @MaPG
	--		Delete PhieuNhan where MaPN = @MaPN
			
	--		Insert into LuuTruPhieuNhap(MaPN, MaNV, MaNCC, NgayLap, NgayGiaoDK, TongTien, TinhTrang) Select MaPN, MaNV, MaNCC, NgayLap, NgayGiaoDK, TongTien, TinhTrang From PhieuNhap where MaPN = @MaPN
	--		Delete PhieuNhap where MaPN = @MaPN
	--	End
	--	fetch next from curPNhan into @MaPN, @MaPG	
	--End
	--close curPNhan
	--deallocate curPNhan
	
	if exists(Select * from ChiTietPhieuNhap where MaSP = @MaSP)
	Begin
		return 1
	End
	
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

if OBJECT_ID('spSanPhamSelect') is not null
Begin
	drop proc spSanPhamSelect
End
GO
create proc spSanPhamSelect
As
Begin
	Select SP.MaSP, SP.TenSP, Sp.SoLuongTon, SP.MaDV, DV.TenDV
	From SanPham SP, LoaiDonViTinh DV
	Where SP.MaDV = DV.MaDV
End
GO

exec spSanPhamSelect
GO

if OBJECT_ID('spSanPhamSelectPhieuNhap') is not null
Begin
	drop proc spSanPhamSelectPhieuNhap
End
GO
create proc spSanPhamSelectPhieuNhap
As
Begin
	Select SP.MaSP, SP.TenSP, SP.MaDV, DV.TenDV
	From SanPham SP, LoaiDonViTinh DV
	Where SP.MaDV = DV.MaDV
End
GO

exec spSanPhamSelectPhieuNhap


--Table LoaiDonViTinh
if OBJECT_ID('spLoaiDonViTinhSelect') is not null
Begin
	drop proc spLoaiDonViTinhSelect
End
GO
create proc spLoaiDonViTinhSelect
As
Begin
	Select MaDV, TenDV, DoTangMacDinh, SoThuc
	From LoaiDonViTinh
End
GO

exec spLoaiDonViTinhSelect
GO

if OBJECT_ID('spLoaiDonViTinhInsert') is not null
Begin
	drop proc spLoaiDonViTinhInsert
End
GO
create proc spLoaiDonViTinhInsert @TenDV nvarchar(8), @SoThuc bit
As
Begin
	if ISNULL(@TenDV, '') = ''
	Begin
		return 0
	End
	
	Insert into LoaiDonViTinh values(@TenDV, 0, @SoThuc)
End
GO

if OBJECT_ID('spLoaiDonViTinhUpdate') is not null
Begin
	drop proc spLoaiDonViTinhUpdate
End
GO
create proc spLoaiDonViTinhUpdate @MaDV int, @TenDV nvarchar(8), @DoTangMacDinh float, @SoThuc bit
As
Begin
	if ISNULL(@MaDV,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@TenDV, '') = ''
	Begin
		return 0
	End
	
	Update LoaiDonViTinh set TenDV = @TenDV, DoTangMacDinh = @DoTangMacDinh, SoThuc = @SoThuc where MaDV = @MaDV
End
GO

if OBJECT_ID('spLoaiDonViTinhDelete') is not null
Begin
	drop proc spLoaiDonViTinhDelete
End
GO
create proc spLoaiDonViTinhDelete @MaDV int
As
Begin
	if ISNULL(@MaDV, '') = ''
	Begin
		return 0
	End
	
	if exists(Select * From SanPham Where MaDV = @MaDV)
	Begin
		return 1
	End
	
	Delete LoaiDonViTinh where MaDV = @MaDV
End
Go

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

exec spCTLamMonSelect 'DA0001'
--Declare @DS As DSSanPham
--insert into @DS values('SP0006', 400, 4), ('SP0007', 10, 0.1)
--exec spSanPhamDaDungInsert @DS

--DBCC CHECKIDENT (ChiTietHoaDon, RESEED, 5)


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

if OBJECT_ID('spMonAnDoUongSelectAll') is not null
Begin
	drop proc spMonAnDoUongSelectAll
End
GO
create proc spMonAnDoUongSelectAll
As
Begin
	Select MaMon, TenMon, GiaTienHienTai, ThucDonMon
	From MonAnDoUong
End
GO

exec spMonAnDoUongSelectAll

--@kt = 1 tạo mã đồ ăn, @kt = 0 tạo mã đồ uống
if OBJECT_ID('usp_TaoMaMonAnDoUong') is not null
Begin
	Drop proc usp_TaoMaMonAnDoUong
End
GO
create proc usp_TaoMaMonAnDoUong @MaMoi char(10) output, @kt bit
As
Begin
	Declare @so int
	Select top 1 @MaMoi = MaMon
	From MonAnDoUong
	Order By MaMon DESC
	
	if ISNULL(@MaMoi, '') = ''
	Begin
		if @kt = 1
		Begin
			set @MaMoi = 'DA0001'
			return 0
		End
		Else
		Begin
			set @MaMoi = 'DU0001'
			return 0
		End
	End
	
	Declare @Ma char(2)
	if @kt = 1
	Begin
		set @Ma = 'DA'
	End
	Else
	Begin
		set @Ma = 'DU'
	End
	set @so = SUBSTRING(RTRIM(@MaMoi), PATINDEX('%[1-9]%', @MaMoi), LEN(@MaMoi) - PATINDEX('%[1-9]%', @MaMoi) + 1) + 1
	set @MaMoi = @Ma + REPLICATE('0', LEN(@MaMoi) - 2 - LEN(@so)) + CAST(@so as varchar(5))
End
GO

Declare @MaMoi char(10)
exec usp_TaoMaMonAnDoUong @MaMoi output, 0
print @MaMoi
GO

if OBJECT_ID('MonAnDoUongInsert') is not null
Begin
	drop proc MonAnDoUongInsert
End
GO
create proc MonAnDoUongInsert @TenMon nvarchar(100), @GiaTienHienTai int, @kt bit
As
Begin
	if @GiaTienHienTai < 0
	Begin
		return 1
	End
	
	if ISNULL(@TenMon,'') = ''
	Begin
		return 0
	End
	
	Declare @MaMoi char(10)
	exec usp_TaoMaMonAnDoUong @MaMoi output, @kt
	Insert into MonAnDoUong values(@MaMoi, @TenMon, @GiaTienHienTai, 0, 0)
End
GO

if OBJECT_ID('spMonAnDoUongUpdate') is not null
Begin
	drop proc spMonAnDoUongUpdate
End
GO
create proc spMonAnDoUongUpdate @MaDA char(10), @TenMon nvarchar(100), @GiaTienHienTai int, @ThucDonMon bit
As
Begin
	if ISNULL(@TenMon, '') = ''
	Begin
		return 0
	End
	
	if @GiaTienHienTai < 0
	Begin
		return 1
	End
	
	Declare @TinhTrang bit = 0
	if @ThucDonMon = 1
	Begin
		set @TinhTrang = 1
	End
	Update MonAnDoUong set TenMon = @TenMon, GiaTienHienTai = @GiaTienHienTai, ThucDonMon = @ThucDonMon, TinhTrang = @TinhTrang where MaMon = @MaDA
End
GO

if OBJECT_ID('spMonAnDoUongDelete') is not null
Begin
	drop proc spMonAnDoUongDelete
End
GO
create proc spMonAnDoUongDelete @MaDA char(10)
As
Begin
	if ISNULL(@MaDA,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From ChiTietHoaDon Where MaMon = @MaDA)
	Begin
		return 1
	End
	
	Insert into LuuTruCTLamMon(MaMon, MaSP, SoLuong, MaDV) Select MaMon, MaSP, SoLuong, MaDV From ChiTietLamMon Where MaMon = @MaDA
	Delete ChiTietLamMon where MaMon = @MaDA
	Insert into LuuTruMonAnDoUong(MaMon, TenMon, GiaTienHienTai) Select MaMon, TenMon, GiaTienHienTai From MonAnDoUong where MaMon = @MaDA
	Delete MonAnDoUong where MaMon = @MaDA
End
GO

exec spMonAnDoUongDelete 'DA0008'

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
	
	Update MonAnDoUong set ThucDonMon = @TinhTrang where MaMon = @MaMon
End
Go

--exec spMonAnDoUongUpdateTinhTrangMon 'DA0002', 0

--Table HoaDon
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
		return 0
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
	exec usp_TaoMaHoaDon @MaHD output
	
	Insert into HoaDon values(@MaHD, @MaNV, GETDATE(), @SoBan, @SoLuongKhach, @MaHD, NULL, @GhiChu, 0)
End
GO

if OBJECT_ID('spHoaDonUpdate') is not null
Begin
	Drop proc spHoaDonUpdate
End
GO
create proc spHoaDonUpdate @MaHD char(10), @TongTien bigint, @TinhTrang bit
As
Begin
	if ISNULL(@MaHD,'') = ''
	Begin
		return 0
	End
	
	Update HoaDon set TongTien = @TongTien, TinhTrang = @TinhTrang where MaHoaDon = @MaHD 
End
GO

if OBJECT_ID('spHoaDonSelect') is not null
Begin
	drop proc spHoaDonSelect
End
GO
create proc spHoaDonSelect
As
Begin
	Select HD.MaHoaDon, HD.MaNV, NV.HoTen, HD.ThoiGian, HD.SoBan, HD.SoLuongKhach, HD.MaHDChung, HD.TongTien, HD.GhiChu, HD.TinhTrang
	From HoaDon HD, NhanVien NV
	Where HD.MaNV = NV.MaNV
End
GO

exec spHoaDonSelect
GO

if OBJECT_ID('spHoaDonDelete') is not null
Begin
	drop proc spHoaDonDelete
End
GO
create proc spHoaDonDelete @MaHD char(10)
As
Begin
	if ISNULL(@MaHD,'') = ''
	Begin
		return 0
	End
	
	Insert into LuuTruCTHoaDon(MaHoaDon, MaMon, SoLuong, GiaMotMon, ThanhTien, GhiChu) Select MaHoaDon, MaMon, SoLuong, GiaMotMon, ThanhTien, GhiChu From ChiTietHoaDon where MaHoaDon = @MaHD
	Delete ChiTietHoaDon where MaHoaDon = @MaHD
	Insert into LuuTruHoaDon(MaHoaDon, MaNV, ThoiGian, SoBan, SoLuongKhach, MaHDChung, TongTien, GhiChu) Select MaHoaDon, MaNV, ThoiGian, SoBan, SoLuongKhach, MaHDChung, TongTien, GhiChu From HoaDon Where MaHoaDon = @MaHD
	Delete HoaDon where MaHoaDon = @MaHD
End
GO

--Declare @MaHD char(10)
--exec spHoaDonInsert'NV0005', 4, 4, NULL, @MaHD output
--exec spChiTietHoaDonInsert @MaHD, 'DA0001', 2, 60000, 120000, NULL
--exec spHoaDonDelete 'HD0008'

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

--Declare @MaMoi char(10)
--exec spHoaDonInsert 'NV0009', 4, 4, N'Thiếu nợ', @MaMoi output
--exec spHoaDonUpdate 'HD0008', 100000, 1

if OBJECT_ID('usp_TachHoaDon') is not null
Begin
	drop proc usp_TachHoaDon
End
GO
create proc usp_TachHoaDon @MaHD char(10)
As
Begin
	if ISNULL(@MaHD,'') = ''
	Begin
		return 0
	End
	
	Update HoaDon set MaHDChung = MaHoaDon where MaHoaDon = @MaHD
End
GO

if OBJECT_ID('usp_LayTinhTrangHoaDon') is not null
Begin
	drop proc usp_LayTinhTrangHoaDon
End
GO
create proc usp_LayTinhTrangHoaDon @MaHD char(10), @TinhTrang bit output
As
Begin
	if ISNULL(@MaHD, '') = ''
	Begin
		return 0
	End
	
	Select @TinhTrang = TinhTrang
	From HoaDon
	Where MaHoaDon = @MaHD
End
GO

Declare @TinhTrang bit
exec usp_LayTinhTrangHoaDon 'HD0001', @TinhTrang output
print cast(@TinhTrang as varchar(5))

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

--Table ChiTietHoaDon
if OBJECT_ID('spChiTietHoaDonInsert') is not null
Begin
	drop proc spChiTietHoaDonInsert
End
GO
create proc spChiTietHoaDonInsert @MaHD char(10), @MaMon char(10), @SoLuong int, @GiaMotMon int, @ThanhTien bigint, @GhiChu nvarchar(50)
As
Begin
	if ISNULL(@MaHD,'') = ''
	Begin
		return 0
	End
	
	insert into ChiTietHoaDon values(@MaHD, @MaMon, @SoLuong, @GiaMotMon, @ThanhTien, @GhiChu)
End
GO

if OBJECT_ID('spChiTietHoaDonSelect') is not null
Begin
	drop proc spChiTietHoaDonSelect
End
GO
create proc spChiTietHoaDonSelect @MaHD char(10)
As
Begin
	if TRIGGER_NESTLEVEL() > 1
	Begin
		return
	End
	Select CT.MaHoaDon, CT.MaMon, MA.TenMon, CT.SoLuong, CT.GiaMotMon, CT.ThanhTien, CT.GhiChu
	From ChiTietHoaDon CT, MonAnDoUong MA
	Where CT.MaMon = MA.MaMon AND CT.MaHoaDon = @MaHD
End
GO
exec spChiTietHoaDonSelect 'HD0003'

--Table NhanVien

if OBJECT_ID('spNhanVienSelect') is not null
Begin
	drop proc spNhanVienSelect
End
GO
create proc spNhanVienSelect
As
Begin
	Select NV.MaNV, NV.HoTen, NV.TGBatDau, NV.cmnd, NV.TinhTrang, NV.NgaySinh, NV.GioiTinh, NV.LoaiNhanVien, NV.MaChucVu, CV.TenChucVu, NV.MaNV As MaNV_KhaNang
	From NhanVien NV, ChucVuNhanVien CV
	Where NV.MaChucVu = CV.MaChucVu AND NV.MaNV <> 'NV0000'
End
GO

exec spNhanVienSelect

if OBJECT_ID('usp_TaoMaNhanVien') is not null
Begin
	Drop proc usp_TaoMaNhanVien
End
GO
create proc usp_TaoMaNhanVien @MaMoi char(10) output
As
Begin
	Declare @so int
	Select top 1 @MaMoi = MaNV
	From NhanVien
	Order By MaNV DESC
	
	if ISNULL(@MaMoi, '') = ''
	Begin
		set @MaMoi = 'NV0001'
		return 0
	End
	
	set @so = SUBSTRING(RTRIM(@MaMoi), PATINDEX('%[1-9]%', @MaMoi), LEN(@MaMoi) - PATINDEX('%[1-9]%', @MaMoi) + 1) + 1
	set @MaMoi = 'NV' + REPLICATE('0', LEN(@MaMoi) - 2 - LEN(@so)) + CAST(@so as varchar(5))
End
GO

Declare @MaMoi char(10)
exec usp_TaoMaNhanVien @MaMoi output
print @MaMoi

if OBJECT_ID('spNhanVienInsert') is not null
Begin
	drop proc spNhanVienInsert
End
GO
create proc spNhanVienInsert @HoTen nvarchar(50), @CMND char(12), @TinhTrang bit, @TGBatDau date ,@NgaySinh date, @GioiTinh nvarchar(6), @LoaiNhanVien bit, @MaChucVu int
As
Begin
	Declare @MaMoi char(10)
	exec usp_TaoMaNhanVien @MaMoi output
	Insert into NhanVien values(@MaMoi, @HoTen, @TGBatDau, @CMND, @TinhTrang, @NgaySinh, @GioiTinh, @LoaiNhanVien, @MaChucVu)
End
GO

if OBJECT_ID('spNhanVienDelete') is not null
Begin
	drop proc spNhanVienDelete
End
GO
create proc spNhanVienDelete @MaNV char(10)
As
Begin
	if ISNULL(@MaNV,'') = ''
	Begin
		return 0
	End
	
	Delete TaiKhoanNhanVien where MaNV = @MaNV
	Delete KhaNangViTinhCuaNhanVien where MaNV = @MaNV
	Insert into LuuTruLichLamViec(MaNV, Ca, SoBan, ThangNam) Select MaNV, Ca, SoBan, ThangNam  From LichLamViec where MaNV = @MaNV
	Delete LichLamViec where MaNV = @MaNV
	Insert into LuuTruNhanVien(MaNV, HoTen, TGBatDau, cmnd, TinhTrang, NgaySinh, GioiTinh, LoaiNhanVien, MaChucVu) Select MaNV, HoTen, TGBatDau, cmnd, TinhTrang, NgaySinh, GioiTinh, LoaiNhanVien, MaChucVu From NhanVien where MaNV = @MaNV
	Delete NhanVien where MaNV = @MaNV
End
GO

if OBJECT_ID('spNhanVienUpdate') is not null
Begin
	drop proc spNhanVienUpdate
End
GO
create proc spNhanVienUpdate @MaNV char(10), @TenNV nvarchar(50), @TGBatDau date, @CMND char(12), @TinhTrang bit, @GioiTinh nvarchar(6), @NgaySinh date, @LoaiNhanVien bit, @MaChucVu int
As
Begin
	if ISNULL(@MaNV,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From NhanVien where MaNV = @MaNV AND cmnd <> @CMND)
	Begin
		if exists(Select * from TaiKhoanNhanVien where MaNV = @MaNV)
		Begin
			return 1
		End
	End
	
	Update NhanVien set HoTen = @TenNV, TGBatDau = @TGBatDau, cmnd = @CMND, TinhTrang = @TinhTrang, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, LoaiNhanVien = @LoaiNhanVien, MaChucVu = @MaChucVu Where MaNV = @MaNV
End
GO

--exec spNhanVienUpdate 'NV0003', N'Trần Văn Thiện', '2013-06-06', '331654790', 0, N'Nam', '1990-02-04', 0, 1

--exec spNhanVienSelect
--exec spNhanVienInsert N'Nguyên Lưu', '012345678123', '2000-12-1' '1994-12-1', 'Nam', 1, 3
--exec spNhanVienDelete 'NV0031'

--Table ChucVuNhanVien
if OBJECT_ID('spChucVuNhanVienSelect') is not null
Begin
	drop proc spChucVuNhanVienSelect
End
GO
create proc spChucVuNhanVienSelect
As
Begin
	Select MaChucVu, TenChucVu
	From ChucVuNhanVien
	Where TenChucVu not like N'Nhân Viên'
End
GO

exec spChucVuNhanVienSelect

if OBJECT_ID('spChucVuNhanVienUpdate') is not null
Begin
	drop proc spChucVuNhanVienUpdate
End
GO
create proc spChucVuNhanVienUpdate @MaChucVu int, @TenChucVu nvarchar(50)
As
Begin
	if ISNULL(@MaChucVu,'') = ''
	Begin
		return 0
	End
	
	Update ChucVuNhanVien set TenChucVu = @TenChucVu where MaChucVu = @MaChucVu
End
GO

--exec spChucVuNhanVienUpdate @MaChucVu = 6, @TenChucVu = 'test'

if OBJECT_ID('spChucVuNhanVienDelete') is not null
Begin
	drop proc spChucVuNhanVienDelete
End
GO
create proc spChucVuNhanVienDelete @MaChucVu int
As
Begin
	if @MaChucVu <= 0
	Begin
		return 0
	End
	
	Update NhanVien set MaChucVu = 6 Where MaChucVu = @MaChucVu
	Delete ChucVuNhanVien where MaChucVu = @MaChucVu
End
GO

if OBJECT_ID('spChucVuNhanVienInsert') is not null
Begin
	drop proc spChucVuNhanVienInsert 
End
GO
create proc spChucVuNhanVienInsert @TenChucVu nvarchar(50)
As
Begin
	if ISNULL(@TenChucVu,'') = ''
	Begin
		return 0
	End
	
	insert into ChucVuNhanVien values(@TenChucVu)
End
GO

--Table KhaNangViTinhCuaNhanVien
if OBJECT_ID('spKhaNangViTinhCuaNhanVienSelect') is not null
Begin
	drop proc spKhaNangViTinhCuaNhanVienSelect
End
GO
create proc spKhaNangViTinhCuaNhanVienSelect @MaNV char(10)
As
Begin
	if ISNULL(@MaNV,'') = ''
	Begin
		return 0
	End
	
	Select MaNV,TenPhanMem
	From KhaNangViTinhCuaNhanVien
	Where MaNV = @MaNV
End
GO

if OBJECT_ID('spKhaNangViTinhCuaNhanVienInsert') is not null
Begin
	drop proc spKhaNangViTinhCuaNhanVienInsert
End
GO
create proc spKhaNangViTinhCuaNhanVienInsert @MaNV char(10), @TenPM nvarchar(50)
As
Begin
	if ISNULL(@MaNV,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@TenPM,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From KhaNangViTinhCuaNhanVien Where MaNV = @MaNV AND TenPhanMem = @TenPM)
	Begin
		return 1
	End
	
	insert into KhaNangViTinhCuaNhanVien values(@MaNV, @TenPM)
End
GO

if OBJECT_ID('spKhaNangViTinhCuaNhanVienUpdate') is not null
Begin
	drop proc spKhaNangViTinhCuaNhanVienUpdate
End
GO
create proc spKhaNangViTinhCuaNhanVienUpdate @MaNV char(10), @TenPMCu nvarchar(50), @TenPMMoi nvarchar(50)
As
Begin
	if ISNULL(@MaNV,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@TenPMCu,'') = '' OR ISNULL(@TenPMMoi,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From KhaNangViTinhCuaNhanVien Where MaNV = @MaNV AND TenPhanMem = @TenPMMoi)
	Begin
		return 1
	End
	
	Update KhaNangViTinhCuaNhanVien set TenPhanMem = @TenPMMoi where MaNV = @MaNV AND TenPhanMem = @TenPMCu
End
GO

if OBJECT_ID('spKhaNangViTinhCuaNhanVienDelete') is not null
Begin
	drop proc spKhaNangViTinhCuaNhanVienDelete
End
GO
create proc spKhaNangViTinhCuaNhanVienDelete @MaNV char(10), @TenPM nvarchar(50)
As
Begin
	if ISNULL(@MaNV,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@TenPM,'') = ''
	Begin
		return 0
	End
	
	Delete KhaNangViTinhCuaNhanVien where MaNV = @MaNV AND TenPhanMem = @TenPM
End
GO


--Table Ban
if OBJECT_ID('usp_CapNhapTinhTrangBan') is not null
Begin
	drop proc usp_CapNhapTinhTrangBan
End
GO
create proc usp_CapNhapTinhTrangBan @SoBan int, @TinhTrang bit
As
Begin
	if ISNULL(@SoBan, 0) = 0
	Begin
		return 0
	End
	
	Update Ban set TinhTrang = @TinhTrang, NhanVienTiepNhan = NULL where SoBan = @SoBan
End
GO

if OBJECT_ID('usp_LayTinhTrangBan') is not null
Begin
	drop proc usp_LayTinhTrangBan
End
GO
create proc usp_LayTinhTrangBan @SoBan int
AS
Begin
	if ISNULL(@SoBan, 0) = 0
	Begin
		return 0
	End
	
	Select TinhTrang
	From Ban
	Where SoBan = @SoBan
End
GO

exec usp_LayTinhTrangBan 1

if OBJECT_ID('usp_CapNhapNhanVienTiepNhanBan') is not null
Begin
	drop proc usp_CapNhapNhanVienTiepNhanBan
End
GO
create proc usp_CapNhapNhanVienTiepNhanBan @SoBan int, @MaNV char(10), @TinhTrang bit
As
Begin
	if ISNULL(@SoBan, '') = ''
	Begin
		return 0
	End
	
	Update Ban set NhanVienTiepNhan = @MaNV , TinhTrang = @TinhTrang Where SoBan = @SoBan
End
GO

--Table NhaCungCap_DienThoai
if OBJECT_ID('spNhaCungCap_DienThoaiSelect') is not null
Begin
	drop proc spNhaCungCap_DienThoaiSelect
End
GO
create proc spNhaCungCap_DienThoaiSelect @MaNCC char(10)
As
Begin
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
	Select MaNCC, SDT 
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
	
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
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

if OBJECT_ID('spNhaCungCap_DienThoaiDelete') is not null
Begin
	drop proc spNhaCungCap_DienThoaiDelete
End
GO
create proc spNhaCungCap_DienThoaiDelete @MaNCC char(10), @SDT char(12)
As
Begin
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	Delete NhaCungCap_DienThoai where MaNCC = @MaNCC AND SDT = @SDT
End
GO

--Table NhaCungCap_Email
if OBJECT_ID('spNhaCungCap_EmailSelect') is not null
Begin
	drop proc spNhaCungCap_EmailSelect
End
GO
create proc spNhaCungCap_EmailSelect @MaNCC char(10)
As
Begin
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
	Select MaNCC, Email
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
	
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@Email,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From NhaCungCap_Email Where MaNCC = @MaNCC AND Email = @Email)
	Begin
		return 1
	End
	
	Insert into NhaCungCap_Email values(@MaNCC, @Email)
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
	
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@EmailCu,'') = '' OR ISNULL(@EmailMoi,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From NhaCungCap_Email Where MaNCC = @MaNCC AND Email = @EmailMoi)
	Begin
		return 1
	End
	
	Update NhaCungCap_Email set Email = @EmailMoi where MaNCC = @MaNCC AND Email = @EmailCu
End
GO

if OBJECT_ID('spNhaCungCap_EmailDelete') is not null
Begin
	drop proc spNhaCungCap_EmailDelete
End
GO
create proc spNhaCungCap_EmailDelete @MaNCC char(10), @Email varchar(50)
As
Begin
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	Delete NhaCungCap_Email where MaNCC = @MaNCC AND Email = @Email
End
GO

--Trigger kiểm tra nguyên liệu ví dụ đưa 10 dĩa trả về 3 dĩa không làm được và trừ nguyên liệu 7 dĩa
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
	--Tìm nguyên liệu có số lượng nhỏ nhất để so sánh
	Declare cur cursor for Select STT, MaSP, SoLuong, SoLuongDungMotMon From inserted order by SoLuong ASC
	Declare @MaSP char(10)
	Declare @SoLuong real
	Declare @SoLuongMacDinh real
	Declare @STT1 int
	open cur
	fetch next from cur into @STT1, @MaSP, @SoLuong, @SoLuongMacDinh
	
	while @@FETCH_STATUS = 0
	Begin
		--Số lượng khác 0 sẽ kiểm tra
		if @SoLuong <> 0
			Begin
				Declare @SoLuongKho real
				Select @SoLuongKho = SoLuongTon
				From SanPham
				Where MaSP = @MaSP
				
				Declare @SoLuongSeDung real
				set @SoLuongSeDung = @SoLuongKho - @SoLuong
				
				--Nếu số lượng < 0=> thiếu nguyên liệu
				if @SoLuongSeDung < 0
				Begin
					Declare @SoLuongMonKLD int
					--Tính số lượng món không làm được và chuyển về kiểu int
					set @SoLuongSeDung = ABS(@SoLuongSeDung) / @SoLuongMacDinh
					set @SoLuongMonKLD = CAST(@SoLuongSeDung as int)
					
					--Cộng lại số lượng nguyên liệu đã trừ 
					Declare curR cursor for Select MaSP, SoLuong From inserted order by SoLuong ASC
					Declare @MaSPR char(10)
					Declare @SoLuongR real
					
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
					
					--Bắt đầu trừ nguyên liệu với số dĩa làm được
					Declare curU cursor for Select STT, MaSP, SoLuong, SoLuongDungMotMon From inserted order by SoLuong ASC
					Declare @MaSPU char(10)
					Declare @SoLuongU real
					Declare @SoLuongMotMonU real
					Declare @STT int
					
					open curU
					fetch next from curU into @STT, @MaSPU, @SoLuongU, @SoLuongMotMonU
					
					while @@FETCH_STATUS = 0
					Begin
						Update SanPham set SoLuongTon = SoLuongTon - (@SoLuongU - @SoLuongMonKLD * @SoLuongMotMonU) where MaSP = @MaSPU
						Declare @SoLuongLamDuoc real
						set @SoLuongLamDuoc = @SoLuongU - @SoLuongMonKLD * @SoLuongMotMonU
						--Nếu số lượng làm được là 0 => không xài nguyên liệu đó vì kho không đủ => xóa dòng đó trong bảng nguyên liệu đã dùng
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
					--Trả về số dĩa không làm được
					Raiserror(50001, 16, 1, @SoLuongMonKLD)
					close cur
					deallocate cur
					return 
			End
			Else
			--Số lượng khác 0 = vẫn làm được => trừ số lượng tồn trong kho
			Begin
				Update SanPham set SoLuongTon = @SoLuongSeDung where MaSP = @MaSP
			End
		End
		Else
		-- Số lượng = 0 xóa dòng đó trong bảng vì số lượng nguyên liệu = 0
		Begin
			Delete LuuTruSanPhamDaDung where STT = @STT1
		End
		
		
		fetch next from cur into @STT1, @MaSP, @SoLuong, @SoLuongMacDinh
	End
	close cur
	deallocate cur
End
GO

--Table NhaCungCap
if OBJECT_ID('usp_TaoMaNhaCungCap') is not null
Begin
	Drop proc usp_TaoMaNhaCungCap
End
GO
create proc usp_TaoMaNhaCungCap @MaMoi char(10) output
As
Begin
	Declare @so int
	Select top 1 @MaMoi = MaNCC
	From NhaCungCap
	Order By MaNCC DESC
	
	if ISNULL(@MaMoi, '') = ''
	Begin
		set @MaMoi = 'NCC001'
		return 0
	End
	
	set @so = SUBSTRING(RTRIM(@MaMoi), PATINDEX('%[1-9]%', @MaMoi), LEN(@MaMoi) - PATINDEX('%[1-9]%', @MaMoi) + 1) + 1
	set @MaMoi = 'NCC' + REPLICATE('0', LEN(@MaMoi) - 3 - LEN(@so)) + CAST(@so as varchar(5))
End
GO

Declare @MaMoi char(10)
exec usp_TaoMaNhaCungCap @MaMoi output
print @MaMoi
GO

if OBJECT_ID('spNhaCungCapInsert') is not null
Begin
	drop proc spNhaCungCapInsert
End
GO
create proc spNhaCungCapInsert @TenNCC nvarchar(50), @DiaChi nvarchar(60), @ChietKhau decimal(3,2), @GhiChu nvarchar(50) = null
As
Begin
	Declare @MaMoi char(10)
	exec usp_TaoMaNhaCungCap @MaMoi output
	Insert into NhaCungCap values(@MaMoi, @TenNCC, @DiaChi, @ChietKhau, @GhiChu)
End
GO


if OBJECT_ID('spNhaCungCapSelect') is not null
Begin
	drop proc spNhaCungCapSelect
End
GO
create proc spNhaCungCapSelect
As
Begin
	Select NCC.MaNCC, NCC.TenNCC, NCC.DiaChi, NCC.ChietKhau, NCC.GhiChu, NCC.MaNCC As MaNCC_Email, NCC.MaNCC As MaNCC_SDT
	From NhaCungCap NCC
	where NCC.MaNCC <> 'NCC000'
End
GO

exec spNhaCungCapSelect

if OBJECT_ID('spNhaCungCapDelete') is not null
Begin
	drop proc spNhaCungCapDelete
End
GO
create proc spNhaCungCapDelete @MaNCC char(10)
As
Begin
	Delete NhaCungCap_DienThoai where MaNCC = @MaNCC
	Delete NhaCungCap_Email where MaNCC = @MaNCC
	Declare curNCC cursor for Select MaPN From PhieuNhap where MaNCC = @MaNCC
	Declare @MaPN char(10)
	open curNCC
	fetch next from curNCC into @MaPN
	while @@FETCH_STATUS = 0
	Begin
		Update PhieuNhap set MaNCC = 'NCC000' where MaPN = @MaPN
		
		fetch next from curNCC into @MaPN
	End
	close curNCC
	deallocate curNCC
	Delete NhaCungCap where MaNCC = @MaNCC
End
GO

if OBJECT_ID('spNhaCungCapUpdate') is not null
Begin
	drop proc spNhaCungCapUpdate
End
GO
create proc spNhaCungCapUpdate @MaNCC char(10), @TenNCC nvarchar(50), @DiaChi nvarchar(60), @ChietKhau decimal(3,2), @GhiChu nvarchar(50)
As
Begin
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
	Update NhaCungCap set TenNCC = @TenNCC, DiaChi = @DiaChi, ChietKhau = @ChietKhau, GhiChu = @GhiChu where MaNCC = @MaNCC
End
GO

--Table PhieuNhap
if OBJECT_ID('usp_TaoMaPhieuNhap') is not null
Begin
	Drop proc usp_TaoMaPhieuNhap
End
GO
create proc usp_TaoMaPhieuNhap @MaMoi char(10) output
As
Begin
	Declare @so int
	Select top 1 @MaMoi = MaPN
	From PhieuNhap
	Order By MaPN DESC
	
	if ISNULL(@MaMoi, '') = ''
	Begin
		set @MaMoi = 'PN0001'
		return 0
	End
	
	set @so = SUBSTRING(RTRIM(@MaMoi), PATINDEX('%[1-9]%', @MaMoi), LEN(@MaMoi) - PATINDEX('%[1-9]%', @MaMoi) + 1) + 1
	set @MaMoi = 'PN' + REPLICATE('0', LEN(@MaMoi) - 2 - LEN(@so)) + CAST(@so as varchar(5))
End
GO

Declare @MaDatMon char(10)
exec usp_TaoMaPhieuNhap @MaDatMon output
print N'Mã mới: ' + @MaDatMon
GO

if OBJECT_ID('spPhieuNhapSelect')is not null
Begin
	drop proc spPhieuNhapSelect
End
GO
create proc spPhieuNhapSelect
As
Begin
	Select PN.MaPN, PN.MaNV, NV.HoTen, PN.MaNCC, NCC.TenNCC, PN.NgayLap, PN.NgayGiaoDK, PN.TongTien, PN.TinhTrang
	From PhieuNhap PN, NhaCungCap NCC, NhanVien NV
	Where PN.MaNCC = NCC.MaNCC AND NV.MaNV = PN.MaNV
End
GO

exec spPhieuNhapSelect
GO

if OBJECT_ID('usp_LoadPhieuNhapChuaHoanThanh') is not null
Begin
	drop proc usp_LoadPhieuNhapChuaHoanThanh
End
GO
create proc usp_LoadPhieuNhapChuaHoanThanh
As
Begin
	Select MaPN
	From PhieuNhap
	Where TinhTrang = 0
End
GO

exec usp_LoadPhieuNhapChuaHoanThanh

if OBJECT_ID('spPhieuNhapInsert') is not null
Begin
	drop proc spPhieuNhapInsert
End
GO
create proc spPhieuNhapInsert @MaNV char(10), @MaNCC char(10), @NgayGiaoDK date
As
Begin
	if ISNULL(@MaNV,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaNCC,'') = ''
	Begin
		return 0
	End
	
	Declare @MaPN char(10)
	exec usp_TaoMaPhieuNhap @MaPN output
	insert into PhieuNhap values(@MaPN, @MaNV, @MaNCC, GETDATE(), @NgayGiaoDK, NULL, 0)
End
GO

if OBJECT_ID('spPhieuNhapDelete') is not null
Begin
	drop proc spPhieuNhapDelete
End
GO
create proc spPhieuNhapDelete @MaPN char(10)
As
Begin
	if ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	Insert into LuuTruCTPhieuNhan (MaPG, MaPN, MaSP, SoLuong) Select MaPG, MaPN, MaSP, SoLuong From LuuTruCTPhieuNhan where MaPN = @MaPN
	Insert into LuuTruCTPhieuNhap(MaPN, MaSP, SoLuong, MaDV, DonGia, ThanhTien) Select MaPN, MaSP, SoLuong, DonGia, MaDV, ThanhTien From ChiTietPhieuNhap where MaPN = @MaPN
	Delete ChiTietPhieuNhan where MaPN = @MaPN
	Insert into LuuTruPhieuNhan(MaPG, MaPN, MaNV, NgayLap, TongTien, GhiChu) Select MaPG, MaPN, MaNV, NgayLap, TongTien, GhiChu From PhieuNhan where MaPN = @MaPN
	Delete PhieuNhan where MaPN = @MaPN
	Delete ChiTietPhieuNhap where MaPN = @MaPN
	Insert into LuuTruPhieuNhap (MaPN, MaNV, MaNCC, NgayLap, NgayGiaoDK, TongTien, TinhTrang) Select MaPN, MaNV, MaNCC, NgayLap, NgayGiaoDK, TongTien, TinhTrang  From PhieuNhap where MaPN = @MaPN
	Delete PhieuNhap where MaPN = @MaPN
	
End
GO

if OBJECT_ID('spPhieuNhapUpdate') is not null
Begin
	drop proc spPhieuNhapUpdate
End
GO
create proc spPhieuNhapUpdate @MaPN char(10), @MaNCC char(10), @NgayGiaoDK date, @TongTien bigint
As
Begin
	if ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From PhieuNhap where MaPN = @MaPN AND TinhTrang = 1)
	Begin
		return 1
	End
	
	Update PhieuNhap set MaNCC = @MaNCC, NgayGiaoDK = @NgayGiaoDK, TongTien = @TongTien where MaPN = @MaPN AND TinhTrang = 0
End
GO

if OBJECT_ID('usp_LayTinhTrangPhieuNhap') is not null
Begin
	drop proc usp_LayTinhTrangPhieuNhap
End
GO
create proc usp_LayTinhTrangPhieuNhap @MaPN char(10)
As
Begin
	if ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	Select TinhTrang From PhieuNhap where MaPN = @MaPN
End
GO

if OBJECT_ID('usp_CapNhapTinhTrangPhieuNhap') is not null
Begin
	drop proc usp_CapNhapTinhTrangPhieuNhap
End
GO
create proc usp_CapNhapTinhTrangPhieuNhap @MaPN char(10), @TinhTrang bit
As
Begin
	if ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	Update PhieuNhap set TinhTrang = @TinhTrang where MaPN = @MaPN
End
GO

--Table ChiTietPhieuNhap
if OBJECT_ID('spChiTietPhieuNhapSelect') is not null
Begin
	drop proc spChiTietPhieuNhapSelect
End
GO
create proc spChiTietPhieuNhapSelect @MaPN char(10)
As
Begin
	if ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	Select CTPN.MaPN, CTPN.MaSP, SP.TenSP, CTPN.SoLuong, CTPN.MaDV, DV.TenDV, CTPN.DonGia, CTPN.ThanhTien
	From ChiTietPhieuNhap CTPN, SanPham SP, LoaiDonViTinh DV
	Where CTPN.MaSP = SP.MaSP AND CTPN.MaDV = DV.MaDV AND MaPN = @MaPN
End
GO
exec spChiTietPhieuNhapSelect 'PN0002'

GO
if OBJECT_ID('spChiTietPhieuNhapInsert') is not null
Begin
	drop proc spChiTietPhieuNhapInsert
End
GO
create proc spChiTietPhieuNhapInsert @MaPN char(10), @MaSP char(10), @SoLuong real, @MaDV int, @DonGia bigint, @ThanhTien bigint
As
Begin
	if ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaSP,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From PhieuNhap where MaPN = @MaPN AND TinhTrang = 1)
	Begin
		return 1
	End
	
	if exists(Select * From ChiTietPhieuNhap where MaPN = @MaPN AND MaSP = @MaSP)
	Begin
		return 2
	End
	
	Insert into ChiTietPhieuNhap values(@MaPN, @MaSP, @SoLuong, @MaDV, @DonGia, @ThanhTien)
End
GO

if OBJECT_ID('spChiTietPhieuNhapUpdate') is not null
Begin
	drop proc spChiTietPhieuNhapUpdate
End
GO
create proc spChiTietPhieuNhapUpdate @MaPN char(10), @MaSPCu char(10), @MaSPMoi char(10), @SoLuong real, @MaDV int, @DonGia bigint, @ThanhTien bigint
As
Begin
	if ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	if ISNULL(@MaSPCu,'') = '' OR ISNULL(@MaSPMoi, '') = ''
	Begin
		return 0
	End
	
	if exists(Select * From PhieuNhap where MaPN = @MaPN AND TinhTrang = 1)
	Begin
		return 1
	End
	
	if exists(Select * From ChiTietPhieuNhap where MaPN = @MaPN AND MaSP = @MaSPMoi)
	Begin
		return 2
	End
	
	Update ChiTietPhieuNhap set MaSP = @MaSPMoi, SoLuong = @SoLuong, DonGia = @DonGia, MaDV = @MaDV, ThanhTien = @ThanhTien Where MaSP = @MaSPCu AND MaPN = @MaPN
End
GO

if OBJECT_ID('spChiTietPhieuNhapDelete') is not null
Begin
	drop proc spChiTietPhieuNhapDelete
End
GO
create proc spChiTietPhieuNhapDelete @MaPN char(10), @MaSP char(10)
As
Begin
	if ISNULL(@MaPN,'') = '' OR ISNULL(@MaSP,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From PhieuNhap where MaPN = @MaPN AND TinhTrang = 1)
	Begin
		return 1
	End
	
	Insert into LuuTruCTPhieuNhap(MaPN, MaSP, SoLuong, MaDV, DonGia, ThanhTien) Select MaPN, MaSP, SoLuong, MaDV, DonGia, ThanhTien From ChiTietPhieuNhap where MaPN = @MaPN AND MaSP = @MaSP
	Delete ChiTietPhieuNhap where MaPN = @MaPN AND MaSP = @MaSP
End
GO

--Table PhieuNhan
if OBJECT_ID('spPhieuNhanSelect') is not null
Begin
	drop proc spPhieuNhanSelect
End
GO
create proc spPhieuNhanSelect
As
Begin
	Select PN.MaPG, PN.MaPN, PN.MaNV, NV.HoTen, PN.NgayLap, PN.TongTien, PN.GhiChu 
	From PhieuNhan PN, NhanVien NV
	Where PN.MaNV = NV.MaNV
End
GO

exec spPhieuNhanSelect

if OBJECT_ID('usp_TaoMaPhieuNhan') is not null
Begin
	Drop proc usp_TaoMaPhieuNhan
End
GO
create proc usp_TaoMaPhieuNhan @MaMoi char(10) output
As
Begin
	Declare @so int
	Select top 1 @MaMoi = MaPG
	From PhieuNhan
	Order By MaPG DESC
	
	if ISNULL(@MaMoi, '') = ''
	Begin
		set @MaMoi = 'SP0001'
		return 1
	End
	
	set @so = SUBSTRING(RTRIM(@MaMoi), PATINDEX('%[1-9]%', @MaMoi), LEN(@MaMoi) - PATINDEX('%[1-9]%', @MaMoi) + 1) + 1
	set @MaMoi = 'PG' + REPLICATE('0', LEN(@MaMoi) - 2 - LEN(@so)) + CAST(@so as varchar(5))
End
GO

Declare @MaMoi char(10)
exec usp_TaoMaPhieuNhan @MaMoi output
print @MaMoi

if OBJECT_ID('spPhieuNhanInsert') is not null
Begin
	drop proc spPhieuNhanInsert
End
GO
create proc spPhieuNhanInsert @MaPN char(10), @MaNV char(10), @GhiChu nvarchar(50), @MaPG char(10) output
As
Begin
	if ISNULL(@MaPN, '') = '' Or ISNULL(@MaNV,'') = ''
	Begin
		return 0
	End
	
	exec usp_TaoMaPhieuNhan @MaPG output
	Insert into PhieuNhan values(@MaPG, @MaPN, @MaNV, GETDATE(), NULL, @GhiChu)
End
GO

if OBJECT_ID('spPhieuNhanUpdate') is not null
Begin
	drop proc spPhieuNhanUpdate
End
GO
create proc spPhieuNhanUpdate @MaPG char(10), @MaPN char(10),  @GhiChu nvarchar(50)
As
Begin
	if ISNULL(@MaPG,'') = '' OR ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From PhieuNhap where MaPN = @MaPN AND TinhTrang = 1)
	Begin
		return 1
	End
	
	Update PhieuNhan set MaPN = @MaPN, GhiChu = @GhiChu where MaPG = @MaPG
End
GO

if OBJECT_ID('spPhieuNhanDelete') is not null
Begin
	drop proc spPhieuNhanDelete
End
GO
create proc spPhieuNhanDelete @MaPG char(10)
As
Begin
	if ISNULL(@MaPG,'') = ''
	Begin
		return 0
	End
	
	Insert into LuuTruCTPhieuNhan(MaPG, MaPN, MaSP, SoLuong) Select MaPG, MaPN, MaSP, SoLuong From ChiTietPhieuNhan where MaPG = @MaPG
	Delete ChiTietPhieuNhan where MaPG = @MaPG
	Insert into LuuTruPhieuNhan(MaPG, MaPN, MaNV, NgayLap, TongTien, GhiChu) Select MaPG, MaPN, MaNV, NgayLap, TongTien, GhiChu From PhieuNhan where MaPG = @MaPG
	Delete PhieuNhan where MaPG = @MaPG
End
GO

--Table ChiTietPhieuNhan
if OBJECT_ID('usp_LoadChiTietPhieuNhanSelect') is not null
Begin
	drop proc usp_LoadChiTietPhieuNhanSelect
End
GO
create proc usp_LoadChiTietPhieuNhanSelect @MaPN char(10)
As
Begin
	if ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	Select CTPN.MaPN, CTPN.MaSP, SP.TenSP, SP.MaDV, DV.TenDV, CTPN.SoLuong
	From ChiTietPhieuNhap CTPN, SanPham SP, LoaiDonViTinh DV
	Where MaPN = @MaPN AND SP.MaSP = CTPN.MaSP AND DV.MaDV = SP.MaDV
End
GO

exec usp_LoadChiTietPhieuNhanSelect 'PN0001'
GO

if OBJECT_ID('spChiTietPhieuNhanSelect') is not null
Begin
	drop proc spChiTietPhieuNhanSelect
End
GO
create proc spChiTietPhieuNhanSelect @MaPG char(10)
As
Begin
	if ISNULL(@MaPG,'') = ''
	Begin
		return 0
	End
	
	Select CTPN.MaPG, CTPN.MaPN, CTPN.MaSP, SP.TenSP, CTPN.SoLuong, SP.MaDV, LD.TenDV
	From ChiTietPhieuNhan CTPN, SanPham SP, LoaiDonViTinh LD
	WHere MaPG = @MaPG AND CTPN.MaSP = SP.MaSP AND SP.MaDV = LD.MaDV
End
GO

exec spChiTietPhieuNhanSelect 'PG0002'
GO

if OBJECT_ID('spChiTietPhieuNhanInsert') is not null
Begin
	drop proc spChiTietPhieuNhanInsert
End
GO
create proc spChiTietPhieuNhanInsert @MaPG char(10), @MaSP char(10), @SoLuong real, @MaPN char(10)
As
Begin
	if ISNULL(@MaPG,'') = '' OR ISNULL(@MaSP,'') = '' OR ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	if @SoLuong > 0
	Begin
		insert into ChiTietPhieuNhan values(@MaPG, @MaSP, @SoLuong, @MaPN)
	End
End
GO

if OBJECT_ID('usp_TinhTongTienPhieuNhan') is not null
Begin
	drop proc usp_TinhTongTienPhieuNhan
End
GO
create proc usp_TinhTongTienPhieuNhan @MaPG char(10)
As
Begin
	if ISNULL('@MaPG','') = ''
	Begin
		return 0
	End
	
	Declare @TongTien bigint
	Select @TongTien = SUM(CTPG.SoLuong * CTPN.DonGia)
	From ChiTietPhieuNhan CTPG, ChiTietPhieuNhap CTPN
	Where CTPG.MaPG = @MaPG AND CTPG.MaPN = CTPN.MaPN AND CTPN.MaSP = CTPG.MaSP
	
	Update PhieuNhan set TongTien = @TongTien where MaPG = @MaPG
End
GO

if OBJECT_ID('spChiTietPhieuNhanDelete') is not null
Begin
	drop proc spChiTietPhieuNhanDelete
End
GO
create proc spChiTietPhieuNhanDelete @MaPG char(10), @MaPN char(10), @MaSP char(10)
As
Begin
	if ISNULL(@MaPG,'') = '' OR ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From PhieuNhap where MaPN = @MaPN AND TinhTrang = 1)
	Begin
		return 1
	End
	
	Insert into LuuTruCTPhieuNhan(MaPG, MaPN, MaSP, SoLuong) Select MaPG, MaPN, MaSP, SoLuong From ChiTietPhieuNhan Where MaPG = @MaPG AND MaSP = @MaSP
	Delete ChiTietPhieuNhan where MaPG = @MaPG AND MaSP = @MaSP
End
GO

if OBJECT_ID('spChiTietPhieuNhanUpdate') is not null
Begin
	drop proc spChiTietPhieuNhanUpdate
End
GO
create proc spChiTietPhieuNhanUpdate @MaPG char(10), @MaPN char(10), @MaSPCu char(10), @MaSPMoi char(10) , @SoLuong real
As
Begin
	if ISNULL(@MaPG,'') = '' OR ISNULL(@MaPN,'') = ''
	Begin
		return 0
	End
	
	if exists(Select * From PhieuNhap where MaPN = @MaPN AND TinhTrang = 1)
	Begin
		return 1
	End
	
	if @MaSPCu <> @MaSPMoi
	Begin
		if exists(Select * From ChiTietPhieuNhan where MaPG = @MaPG AND MaSP = @MaSPMoi)
		Begin
			return 2
		End
	End
	
	Update ChiTietPhieuNhan set MaPN = @MaPN, MaSP = @MaSPMoi, SoLuong = @SoLuong where MaPG = @MaPG AND MaSP = @MaSPCu
End
GO

if OBJECT_ID('tg_ChiTietPhieuNhan_Them_SoLuong') is not null
Begin
	drop trigger tg_ChiTietPhieuNhan_Them_SoLuong
End
GO
create trigger tg_ChiTietPhieuNhan_Them_SoLuong on ChiTietPhieuNhan
for Insert
As
Begin
	if exists(Select * From PhieuNhap PN, inserted I where PN.MaPN = I.MaPN AND PN.TinhTrang = 1)
	Begin
		rollback tran
	End
	Declare cur cursor for Select MaSP, SoLuong From inserted
	Open cur
	Declare @MaSP char(10)
	Declare @SoLuong real
	
	fetch next from cur into @MaSP, @SoLuong
	
	while @@FETCH_STATUS = 0
	Begin
		Update SanPham set SoLuongTon = SoLuongTon + @SoLuong where MaSP = @MaSP
		fetch next from cur into @MaSP, @SoLuong
	End
	close cur
	deallocate cur
End
GO

if OBJECT_ID('tg_ChiTietPhieuNhan_CapNhap_SoLuong') is not null
Begin
	drop trigger tg_ChiTietPhieuNhan_CapNhap_SoLuong
End
GO
create trigger tg_ChiTietPhieuNhan_CapNhap_SoLuong on ChiTietPhieuNhan
for Update
As
Begin
	Declare cur cursor for Select I.MaSP, I.SoLuong, D.SoLuong From inserted I, deleted D where I.MaPG = D.MaPG AND I.MaSP = D.MaSP
	Declare @MaSP char(10)
	Declare @SoLuongThem real
	Declare @SoLuongXoa real
	
	open cur
	fetch next from cur into @MaSP, @SoLuongThem, @SoLuongXoa
	
	while @@FETCH_STATUS = 0
	Begin
		Update SanPham set SoLuongTon = SoLuongTon - @SoLuongXoa + @SoLuongThem where MaSP = @MaSP
		fetch next from cur into @MaSP, @SoLuongThem, @SoLuongXoa
	End
	close cur
	deallocate cur
End
GO

if OBJECT_ID('tg_ChiTietPhieuNhan_Xoa_SoLuong') is not null
Begin
	drop trigger tg_ChiTietPhieuNhan_Xoa_SoLuong
End
GO
create trigger tg_ChiTietPhieuNhan_Xoa_SoLuong on ChiTietPhieuNhan
for Delete
As
Begin
	if exists(Select * From PhieuNhap PN, deleted D where PN.MaPN = D.MaPN AND PN.TinhTrang = 1)
	Begin
		return
	End
	Declare cur cursor for Select MaSP, SoLuong From deleted 
	Open cur
	Declare @MaSP char(10)
	Declare @SoLuong real
	
	fetch next from cur into @MaSP, @SoLuong
	
	while @@FETCH_STATUS = 0
	Begin
		Update SanPham set SoLuongTon = SoLuongTon - @SoLuong where MaSP = @MaSP
		fetch next from cur into @MaSP, @SoLuong
	End
	close cur
	deallocate cur
End
GO

--Table LuuTruDanhSachMonAnSoLuongKHoanThanh
if TYPE_ID('dbo.DSMonAn') is not null
Begin
	if OBJECT_ID('spDanhSachMonAnKhongHoanThanhInsert') is not null
	Begin
		drop proc spDanhSachMonAnKhongHoanThanhInsert 
	End
	
	if OBJECT_ID('spDanhSachMonAnHoanThanhInsert') is not null
	Begin
		drop proc spDanhSachMonAnHoanThanhInsert 
	End

	drop type dbo.DSMonAn
End
GO
create type DSMonAn as Table
(
	MaMon char(10),
	SoLuongMon int
)
GO
if OBJECT_ID('spDanhSachMonAnKhongHoanThanhInsert') is not null
Begin
	drop proc spDanhSachMonAnKhongHoanThanhInsert 
End
GO
create proc spDanhSachMonAnKhongHoanThanhInsert @DS As DSMonAn Readonly
As
Begin
	if not exists(Select * From @DS)
	Begin
		return 0
	End
	
	Insert into LuuTruDanhSachMonAnSoLuongKHoanThanh(NgayLamMon, MaMon, SoLuongMon) Select GETDATE(), MaMon, SoLuongMon From @DS
End
GO

if OBJECT_ID('spDanhSachMonAnHoanThanhInsert') is not null
Begin
	drop proc spDanhSachMonAnHoanThanhInsert 
End
GO
create proc spDanhSachMonAnHoanThanhInsert @DS As DSMonAn Readonly
As
Begin
	if not exists(Select * From @DS)
	Begin
		return 0
	End
	
	Insert into LuuTruDanhSachMonAnNhaBepHoanThanh(NgayLamMon, MaMon, SoLuongMon) Select GETDATE(), MaMon, SoLuongMon From @DS
End
GO

--Các hàm thông kê
--Thống kê món ăn đã hoàn thành
if OBJECT_ID('usp_ThongKeMonAnHoanThanhTheoNgay') is not null
Begin
	drop proc usp_ThongKeMonAnHoanThanhTheoNgay
End
GO
create proc usp_ThongKeMonAnHoanThanhTheoNgay @Ngay date
As
Begin
	Select HT.MaMon, DA.TenMon, SUM(HT.SoLuongMon) as TongSoLuong
	From LuuTruDanhSachMonAnNhaBepHoanThanh HT, MonAnDoUong DA
	Where HT.MaMon = DA.MaMon AND HT.NgayLamMon = @Ngay
	Group by HT.MaMon, DA.TenMon
End
Go

exec usp_ThongKeMonAnHoanThanhTheoNgay '2015-01-30'

if OBJECT_ID('usp_ThongKeMonAnHoanThanhTheoNam') is not null
Begin
	drop proc usp_ThongKeMonAnHoanThanhTheoNam
End
GO
create proc usp_ThongKeMonAnHoanThanhTheoNam @Nam int
As
Begin
	Select HT.MaMon, DA.TenMon, SUM(HT.SoLuongMon) as TongSoLuong
	From LuuTruDanhSachMonAnNhaBepHoanThanh HT, MonAnDoUong DA
	Where HT.MaMon = DA.MaMon AND YEAR(HT.NgayLamMon) = @Nam
	Group by HT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeMonAnHoanThanhTheoNam 2015

if OBJECT_ID('usp_ThongKeMonAnHoanThanhTheoThang') is not null
Begin
	drop proc usp_ThongKeMonAnHoanThanhTheoThang
End
GO
create proc usp_ThongKeMonAnHoanThanhTheoThang @Thang int, @Nam int
As
Begin
	Select HT.MaMon, DA.TenMon, SUM(HT.SoLuongMon) as TongSoLuong
	From LuuTruDanhSachMonAnNhaBepHoanThanh HT, MonAnDoUong DA
	Where HT.MaMon = DA.MaMon AND MONTH(HT.NgayLamMon) = @Thang AND YEAR(HT.NgayLamMon) = @Nam
	Group by HT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeMonAnHoanThanhTheoThang 1, 2015

if OBJECT_ID('usp_ThongKeMonAnHoanThanhTheoQuy') is not null
Begin
	drop proc usp_ThongKeMonAnHoanThanhTheoQuy
End
GO
create proc usp_ThongKeMonAnHoanThanhTheoQuy @Quy int, @Nam int
As
Begin
	Declare @Thang1 int
	Declare @Thang2 int
	Declare @Thang3 int
	Declare @Thang4 int
	
	if @Quy = 1
	Begin
		set @Thang1 = 1
		set @Thang2 = 2
		set @Thang3 = 3
		set @Thang4 = 4
	End
	
	if @Quy = 2
	Begin
		set @Thang1 = 5
		set @Thang2 = 6
		set @Thang3 = 7
		set @Thang4 = 8
	End
	
	if @Quy = 3
	Begin
		set @Thang1 = 9
		set @Thang2 = 10
		set @Thang3 = 11
		set @Thang4 = 12
	End
	
	Select HT.MaMon, DA.TenMon, SUM(HT.SoLuongMon) as TongSoLuong
	From LuuTruDanhSachMonAnNhaBepHoanThanh HT, MonAnDoUong DA
	Where HT.MaMon = DA.MaMon AND YEAR(HT.NgayLamMon) = @Nam AND (MONTH(HT.NgayLamMon) = @Thang1 OR MONTH(HT.NgayLamMon) = @Thang2 OR MONTH(HT.NgayLamMon) = @Thang3 OR MONTH(HT.NgayLamMon) = @Thang4)
	Group by HT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeMonAnHoanThanhTheoQuy 1, 2015


--Thống kê món ăn chưa hoàn thành

if OBJECT_ID('usp_ThongKeMonAnKhongHoanThanhTheoNgay') is not null
Begin
	drop proc usp_ThongKeMonAnKhongHoanThanhTheoNgay
End
GO
create proc usp_ThongKeMonAnKhongHoanThanhTheoNgay @Ngay date
As
Begin
	Select HT.MaMon, DA.TenMon, SUM(HT.SoLuongMon) as TongSoLuong
	From LuuTruDanhSachMonAnSoLuongKHoanThanh HT, MonAnDoUong DA
	Where HT.MaMon = DA.MaMon AND HT.NgayLamMon = @Ngay
	Group by HT.MaMon, DA.TenMon
End
Go

if OBJECT_ID('usp_ThongKeMonAnKhongHoanThanhTheoNam') is not null
Begin
	drop proc usp_ThongKeMonAnKhongHoanThanhTheoNam
End
GO
create proc usp_ThongKeMonAnKhongHoanThanhTheoNam @Nam int
As
Begin
	Select HT.MaMon, DA.TenMon, SUM(HT.SoLuongMon) as TongSoLuong
	From LuuTruDanhSachMonAnSoLuongKHoanThanh HT, MonAnDoUong DA
	Where HT.MaMon = DA.MaMon AND YEAR(HT.NgayLamMon) = @Nam
	Group by HT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeMonAnKhongHoanThanhTheoNam 2015

if OBJECT_ID('usp_ThongKeMonAnKhongHoanThanhTheoThang') is not null
Begin
	drop proc usp_ThongKeMonAnKhongHoanThanhTheoThang
End
GO
create proc usp_ThongKeMonAnKhongHoanThanhTheoThang @Thang int, @Nam int
As
Begin
	Select HT.MaMon, DA.TenMon, SUM(HT.SoLuongMon) as TongSoLuong
	From LuuTruDanhSachMonAnSoLuongKHoanThanh HT, MonAnDoUong DA
	Where HT.MaMon = DA.MaMon AND MONTH(HT.NgayLamMon) = @Thang AND YEAR(HT.NgayLamMon) = @Nam
	Group by HT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeMonAnKhongHoanThanhTheoThang 1, 2015

if OBJECT_ID('usp_ThongKeMonAnKhongHoanThanhTheoQuy') is not null
Begin
	drop proc usp_ThongKeMonAnKhongHoanThanhTheoQuy
End
GO
create proc usp_ThongKeMonAnKhongHoanThanhTheoQuy @Quy int, @Nam int
As
Begin
	Declare @Thang1 int
	Declare @Thang2 int
	Declare @Thang3 int
	Declare @Thang4 int
	
	if @Quy = 1
	Begin
		set @Thang1 = 1
		set @Thang2 = 2
		set @Thang3 = 3
		set @Thang4 = 4
	End
	
	if @Quy = 2
	Begin
		set @Thang1 = 5
		set @Thang2 = 6
		set @Thang3 = 7
		set @Thang4 = 8
	End
	
	if @Quy = 3
	Begin
		set @Thang1 = 9
		set @Thang2 = 10
		set @Thang3 = 11
		set @Thang4 = 12
	End
	
	Select HT.MaMon, DA.TenMon, SUM(HT.SoLuongMon) as TongSoLuong
	From LuuTruDanhSachMonAnSoLuongKHoanThanh HT, MonAnDoUong DA
	Where HT.MaMon = DA.MaMon AND YEAR(HT.NgayLamMon) = @Nam AND (MONTH(HT.NgayLamMon) = @Thang1 OR MONTH(HT.NgayLamMon) = @Thang2 OR MONTH(HT.NgayLamMon) = @Thang3 OR MONTH(HT.NgayLamMon) = @Thang4)
	Group by HT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeMonAnKhongHoanThanhTheoQuy 1, 2015


--Thống kê nguyên liệu sử dụng

if OBJECT_ID('usp_ThongKeSanPhamDaDungTheoNgay') is not null
Begin
	drop proc usp_ThongKeSanPhamDaDungTheoNgay
End
GO
create proc usp_ThongKeSanPhamDaDungTheoNgay @Ngay date
As
Begin
	Select SPDD.MaSP, SP.TenSP, SUM(SPDD.SoLuong) as TongSoLuong, DV.TenDV
	From LuuTruSanPhamDaDung  SPDD, SanPham SP, LoaiDonViTinh DV
	Where SPDD.MaSP = SP.MaSP AND SPDD.NgayDung = @Ngay AND SP.MaDV = DV.MaDV
	Group by SPDD.MaSP, SP.TenSP, DV.TenDV
End
Go

exec usp_ThongKeSanPhamDaDungTheoNgay '2015-12-16'

if OBJECT_ID('usp_ThongKeSanPhamDaDungTheoNam') is not null
Begin
	drop proc usp_ThongKeSanPhamDaDungTheoNam
End
GO
create proc usp_ThongKeSanPhamDaDungTheoNam @Nam int
As
Begin
	Select SPDD.MaSP, SP.TenSP, SUM(SPDD.SoLuong) as TongSoLuong, DV.TenDV
	From LuuTruSanPhamDaDung  SPDD, SanPham SP, LoaiDonViTinh DV
	Where SPDD.MaSP = SP.MaSP AND YEAR(SPDD.NgayDung) = @Nam AND SP.MaDV = DV.MaDV
	Group by SPDD.MaSP, SP.TenSP, DV.TenDV
End
GO

exec usp_ThongKeSanPhamDaDungTheoNam 2015

if OBJECT_ID('usp_ThongKeSanPhamDaDungTheoThang') is not null
Begin
	drop proc usp_ThongKeSanPhamDaDungTheoThang
End
GO
create proc usp_ThongKeSanPhamDaDungTheoThang @Thang int, @Nam int
As
Begin
	Select SPDD.MaSP, SP.TenSP, SUM(SPDD.SoLuong) as TongSoLuong, DV.TenDV
	From LuuTruSanPhamDaDung  SPDD, SanPham SP, LoaiDonViTinh DV
	Where SPDD.MaSP = SP.MaSP AND MONTH(SPDD.NgayDung) = @Thang AND SP.MaDV = DV.MaDV AND YEAR(SPDD.NgayDung) = @Nam
	Group by SPDD.MaSP, SP.TenSP, DV.TenDV
End
GO

exec usp_ThongKeSanPhamDaDungTheoThang 11, 2015

if OBJECT_ID('usp_ThongKeSanPhamDaDungTheoQuy') is not null
Begin
	drop proc usp_ThongKeSanPhamDaDungTheoQuy
End
GO
create proc usp_ThongKeSanPhamDaDungTheoQuy @Quy int, @Nam int
As
Begin
	Declare @Thang1 int
	Declare @Thang2 int
	Declare @Thang3 int
	Declare @Thang4 int
	
	if @Quy = 1
	Begin
		set @Thang1 = 1
		set @Thang2 = 2
		set @Thang3 = 3
		set @Thang4 = 4
	End
	
	if @Quy = 2
	Begin
		set @Thang1 = 5
		set @Thang2 = 6
		set @Thang3 = 7
		set @Thang4 = 8
	End
	
	if @Quy = 3
	Begin
		set @Thang1 = 9
		set @Thang2 = 10
		set @Thang3 = 11
		set @Thang4 = 12
	End
	
	Select SPDD.MaSP, SP.TenSP, SUM(SPDD.SoLuong) as TongSoLuong, DV.TenDV
	From LuuTruSanPhamDaDung  SPDD, SanPham SP, LoaiDonViTinh DV
	Where SPDD.MaSP = SP.MaSP AND SP.MaDV = DV.MaDV AND YEAR(SPDD.NgayDung) = @Nam AND (MONTH(SPDD.NgayDung) = @Thang1 OR MONTH(SPDD.NgayDung) = @Thang2 OR MONTH(SPDD.NgayDung) = @Thang3 OR MONTH(SPDD.NgayDung) = @Thang4)
	Group by SPDD.MaSP, SP.TenSP, DV.TenDV
End
GO

exec usp_ThongKeSanPhamDaDungTheoQuy 3, 2015
GO


--Thống kê số lượng khách theo bàn

if OBJECT_ID('usp_ThongKeKhachTheoBanNam') is not null
Begin
	drop proc usp_ThongKeKhachTheoBanNam
End
GO
create proc usp_ThongKeKhachTheoBanNam @Nam int
As
Begin
	Select SoBan, SUM(SoLuongKhach) As TongSoKhach
	From HoaDon
	Where YEAR(ThoiGian) = @Nam
	Group by SoBan 
End
GO

exec usp_ThongKeKhachTheoBanNam 2015

if OBJECT_ID('usp_ThongKeKhachTheoBanThang') is not null
Begin
	drop proc usp_ThongKeKhachTheoBanThang
End
GO
create proc usp_ThongKeKhachTheoBanThang @Thang int, @Nam int
As
Begin
	Select SoBan, SUM(SoLuongKhach) As TongSoKhach
	From HoaDon
	Where YEAR(ThoiGian) = @Nam AND MONTH(ThoiGian) = @Thang
	Group by SoBan 
End
GO

exec usp_ThongKeKhachTheoBanThang 11, 2015

if OBJECT_ID('usp_ThongKeKhachTheoBanQuy') is not null
Begin
	drop proc usp_ThongKeKhachTheoBanQuy
End
GO
create proc usp_ThongKeKhachTheoBanQuy @Quy int, @Nam int
As
Begin
	Declare @Thang1 int
	Declare @Thang2 int
	Declare @Thang3 int
	Declare @Thang4 int
	
	if @Quy = 1
	Begin
		set @Thang1 = 1
		set @Thang2 = 2
		set @Thang3 = 3
		set @Thang4 = 4
	End
	
	if @Quy = 2
	Begin
		set @Thang1 = 5
		set @Thang2 = 6
		set @Thang3 = 7
		set @Thang4 = 8
	End
	
	if @Quy = 3
	Begin
		set @Thang1 = 9
		set @Thang2 = 10
		set @Thang3 = 11
		set @Thang4 = 12
	End
	
	Select SoBan, SUM(SoLuongKhach) As TongSoKhach
	From HoaDon
	Where YEAR(ThoiGian) = @Nam AND (MONTH(ThoiGian) = @Thang1 OR MONTH(ThoiGian) = @Thang2 OR MONTH(ThoiGian) = @Thang3 OR MONTH(ThoiGian) = @Thang4)
	Group by SoBan 
End
GO

exec usp_ThongKeKhachTheoBanQuy 3, 2015

--Thống kê số lượng khách của món ăn/nước uống

if OBJECT_ID('usp_ThongKeKhachTheoMonAnTheoNam') is not null
Begin
	drop proc usp_ThongKeKhachTheoMonAnTheoNam
End
GO
create proc usp_ThongKeKhachTheoMonAnTheoNam @Nam int
As
Begin
	Select CT.MaMon, DA.TenMon, SUM(HD.SoLuongKhach) As TongSoKhach
	From HoaDon HD, MonAnDoUong DA, ChiTietHoaDon CT
	Where YEAR(ThoiGian) = @Nam AND HD.MaHoaDon = CT.MaHoaDon AND CT.MaMon = DA.MaMon
	Group by CT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeKhachTheoMonAnTheoNam 2015

if OBJECT_ID('usp_ThongKeKhachTheoMonAnTheoThang') is not null
Begin
	drop proc usp_ThongKeKhachTheoMonAnTheoThang
End
GO
create proc usp_ThongKeKhachTheoMonAnTheoThang @Thang int, @Nam int
As
Begin
	Select CT.MaMon, DA.TenMon, SUM(HD.SoLuongKhach) As TongSoKhach
	From HoaDon HD, MonAnDoUong DA, ChiTietHoaDon CT
	Where YEAR(ThoiGian) = @Nam AND HD.MaHoaDon = CT.MaHoaDon AND CT.MaMon = DA.MaMon AND MONTH(ThoiGian) = @Thang
	Group by CT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeKhachTheoMonAnTheoThang 11, 2015

if OBJECT_ID('usp_ThongKeKhachTheoMonAnTheoQuy') is not null
Begin
	drop proc usp_ThongKeKhachTheoMonAnTheoQuy
End
GO
create proc usp_ThongKeKhachTheoMonAnTheoQuy @Quy int, @Nam int
As
Begin
	Declare @Thang1 int
	Declare @Thang2 int
	Declare @Thang3 int
	Declare @Thang4 int
	
	if @Quy = 1
	Begin
		set @Thang1 = 1
		set @Thang2 = 2
		set @Thang3 = 3
		set @Thang4 = 4
	End
	
	if @Quy = 2
	Begin
		set @Thang1 = 5
		set @Thang2 = 6
		set @Thang3 = 7
		set @Thang4 = 8
	End
	
	if @Quy = 3
	Begin
		set @Thang1 = 9
		set @Thang2 = 10
		set @Thang3 = 11
		set @Thang4 = 12
	End
	
	Select CT.MaMon, DA.TenMon, SUM(HD.SoLuongKhach) As TongSoKhach
	From HoaDon HD, MonAnDoUong DA, ChiTietHoaDon CT
	Where YEAR(ThoiGian) = @Nam AND HD.MaHoaDon = CT.MaHoaDon AND CT.MaMon = DA.MaMon AND (MONTH(HD.ThoiGian) = @Thang1 OR MONTH(HD.ThoiGian) = @Thang2 OR MONTH(HD.ThoiGian) = @Thang3 OR MONTH(HD.ThoiGian) = @Thang4)
	Group by CT.MaMon, DA.TenMon
End
GO

exec usp_ThongKeKhachTheoMonAnTheoQuy 3, 2015
GO

if OBJECT_ID('usp_ThongKeSoLuongKhachTheoNhanVienTrongMotTuan') is not null
Begin
	drop proc usp_ThongKeSoLuongKhachTheoNhanVienTrongMotTuan
End
GO
create proc usp_ThongKeSoLuongKhachTheoNhanVienTrongMotTuan @Ngay date
As
Begin
	Select HD.MaNV, NV.HoTen, NV.LoaiNhanVien, SUM(HD.SoLuongKhach) As TongSoKhach
	From HoaDon HD, NhanVien NV
	Where HD.MaNV = NV.MaNV AND HD.ThoiGian >= @Ngay AND HD.ThoiGian <= DATEADD(DAY, 7, @Ngay)
	Group by HD.MaNV, NV.HoTen, NV.LoaiNhanVien
End
GO

exec usp_ThongKeSoLuongKhachTheoNhanVienTrongMotTuan '2015-11-19'

--Thống kê doanh thu
if OBJECT_ID('usp_ThongKeDoanhThuTheoNam') is not null
Begin
	drop proc usp_ThongKeDoanhThuTheoNam
End
GO
create proc usp_ThongKeDoanhThuTheoNam @Nam int
As
Begin
	Select ISNULL(SUM(TongTien),0)
	From HoaDon HD
	Where YEAR(ThoiGian) = @Nam
End
GO

exec usp_ThongKeDoanhThuTheoNam 2015

if OBJECT_ID('usp_ThongKeDoanhThuTheoThang') is not null
Begin
	drop proc usp_ThongKeDoanhThuTheoThang
End
GO
create proc usp_ThongKeDoanhThuTheoThang @Thang int, @Nam int
As
Begin
	Select ISNULL(SUM(TongTien),0)
	From HoaDon HD
	Where YEAR(ThoiGian) = @Nam AND MONTH(ThoiGian) = @Thang
End
GO

exec usp_ThongKeDoanhThuTheoThang 11, 2015

if OBJECT_ID('usp_ThongKeDoanhThuTheoQuy') is not null
Begin
	drop proc usp_ThongKeDoanhThuTheoQuy
End
GO
create proc usp_ThongKeDoanhThuTheoQuy @Quy int, @Nam int
As
Begin
	Declare @Thang1 int
	Declare @Thang2 int
	Declare @Thang3 int
	Declare @Thang4 int
	
	if @Quy = 1
	Begin
		set @Thang1 = 1
		set @Thang2 = 2
		set @Thang3 = 3
		set @Thang4 = 4
	End
	
	if @Quy = 2
	Begin
		set @Thang1 = 5
		set @Thang2 = 6
		set @Thang3 = 7
		set @Thang4 = 8
	End
	
	if @Quy = 3
	Begin
		set @Thang1 = 9
		set @Thang2 = 10
		set @Thang3 = 11
		set @Thang4 = 12
	End
	
	Select ISNULL(SUM(TongTien), 0)
	From HoaDon HD
	Where YEAR(ThoiGian) = @Nam AND (MONTH(ThoiGian) = @Thang1 OR MONTH(ThoiGian) = @Thang2 OR MONTH(ThoiGian) = @Thang3 OR MONTH(ThoiGian) = @Thang4)
End
GO

exec usp_ThongKeDoanhThuTheoQuy 3, 2015