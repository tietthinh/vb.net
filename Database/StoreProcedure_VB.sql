if OBJECT_ID('usp_TaoMaCTDM') is not null
Begin
	Drop proc usp_TaoMaCTDM
End
GO
create proc usp_TaoMaCTDM @SoBan int, @MaMoi char(10) output
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
Declare @MaMoi char(10)
exec usp_TaoMaCTDM 8, @MaMoi output
print N'Mã mới: ' + @MaMoi
GO

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