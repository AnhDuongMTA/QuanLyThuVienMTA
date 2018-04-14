CREATE PROC XemThongTinViTri 
AS
BEGIN
	SELECT*FROM dbo.ViTriSach
END
GO
CREATE PROC ThemViTri (@MaVT VARCHAR(10),@TenKe NVARCHAR(50),@ViTri NVARCHAR(50))
AS
BEGIN
	INSERT INTO dbo.ViTriSach
	        ( MaVT, TenKe,ViTri )
	VALUES  (@MaVT,@TenKe,@ViTri)
END
GO
CREATE PROC SuaViTri (@MaVT VARCHAR(10),@TenKe NVARCHAR(50),@ViTri NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.ViTriSach
	SET TenKe =@TenKe,ViTri =@ViTri
	WHERE MaVT = @MaVT
END
GO
CREATE PROC XoaViTri (@Ma VARCHAR(10))
AS
BEGIN
	DELETE dbo.ViTriSach WHERE MaVT = @Ma
END
GO

DELETE dbo.ChiTietPhieuMuon
DELETE dbo.ChiTietSach
DELETE dbo.ViTriSach
GO

CREATE PROC TTViTri (@Ma varchar(10))
AS
BEGIN
	SELECT ViTriSach.MaVT,TenKe,ViTri,SUM(SoLuong) AS SoLuong FROM dbo.ViTriSach,dbo.ChiTietSach
	WHERE ChiTietSach.MaVT = ViTriSach.MaVT AND ViTriSach.MaVT = @Ma
	GROUP BY ViTriSach.MaVT,TenKe,ViTri
END
GO 
ALTER PROC TTSach(@Ma VARCHAR(10))
AS
BEGIN
	SELECT MaSach,TenSach,TacGia,TheLoai,NXB,NgonNgu,LinhVuc,NamXB,TenKe,SoLuong FROM dbo.ChiTietSach, dbo.ViTriSach 
	WHERE ChiTietSach.MaVT = @Ma AND ChiTietSach.MaVT=ViTriSach.MaVT
END