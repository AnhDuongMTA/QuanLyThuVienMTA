--quan ly thu vien
USE QuanLyThuVienMTA
GO 
--Dương
--xem
CREATE PROC SP_XemThongTinSach
AS
BEGIN
SELECT * FROM dbo.ChiTietSach
END 
GO
------------------
--Thêm
CREATE PROC SP_ThemSach(@MaSach NVARCHAR(50), @TenSach NVARCHAR(50),@TacGia NVARCHAR(50),@TheLoai NVARCHAR(50),@NXB NVARCHAR(50),@NgonNgu NVARCHAR(50),@LinhVuc NVARCHAR(50),@NamXB INT,@MaViTri NVARCHAR(50),@SoLuong INT )
AS
BEGIN
INSERT dbo.ChiTietSach
VALUES  ( @MaSach ,  @TenSach ,@TacGia , @TheLoai ,@NXB ,@NgonNgu , @LinhVuc , @NamXB, @MaViTri,@SoLuong )
END
GO
--sửa
CREATE PROC SP_SuaSach(@MaSach NVARCHAR(50), @TenSach NVARCHAR(50),@TacGia NVARCHAR(50),@TheLoai NVARCHAR(50),@NXB NVARCHAR(50),@NgonNgu NVARCHAR(50),@LinhVuc NVARCHAR(50),@NamXB INT,@MaViTri NVARCHAR(50),@SoLuong INT)
AS
BEGIN
UPDATE dbo.ChiTietSach
SET TenSach=@TenSach,TacGia=@TacGia,TheLoai=@TheLoai,NXB=@NXB,NgonNgu=@NgonNgu,LinhVuc=@LinhVuc,NamXB=@NamXB,MaVT=@MaViTri,SoLuong=@SoLuong
WHERE MaSach=@MaSach
END 
GO 
--xóa
CREATE PROC SP_XoaSach(@MaSach NVARCHAR(50))
AS
BEGIN
	DELETE dbo.ChiTietSach
	WHERE MaSach=@MaSach
END