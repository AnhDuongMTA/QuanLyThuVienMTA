-- Ánh--
-- Thủ tục--
GO
CREATE PROC NV_SelectAll
AS
BEGIN
	SELECT * FROM dbo.NhanVien
END

-- Thêm NV
GO
CREATE PROC ThemNV(@MaNV VARCHAR(50), @TenNV NVARCHAR(50), @GioiTinh NVARCHAR(10), @NgaySinh DATE, @DienThoai NVARCHAR(15))
AS
BEGIN
	INSERT INTO dbo.NhanVien
	        ( MaNV ,
	          TenNV ,
	          GioiTinh ,
	          NgaySinh ,
	          DienThoai
	        )
	VALUES  (@MaNV,@TenNV,@GioiTinh,@NgaySinh,@DienThoai)
END

-- Thủ tục sửa
GO
CREATE PROC SuaNV(@MaNV VARCHAR(50), @TenNV NVARCHAR(50), @GioiTinh NVARCHAR(10), @NgaySinh DATE, @DienThoai NVARCHAR(15))
AS
BEGIN
	UPDATE dbo.NhanVien
	SET TenNV=@TenNV,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DienThoai=@DienThoai
	WHERE MaNV=@MaNV
END

-- Thủ tục xóa
GO
CREATE PROC XoaNV(@MaNV VARCHAR(50))
AS
BEGIN
	UPDATE dbo.PhieuMuonSach
	SET MaNV=NULL
	WHERE MaNV=@MaNV
	DELETE dbo.NhanVien
	WHERE MaNV=@MaNV
END