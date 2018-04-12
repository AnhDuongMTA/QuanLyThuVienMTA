GO 
USE QuanLyThuVienMTA

GO 
CREATE PROC SP_CTPMselectAll 
AS
BEGIN

	SELECT cm.MaPM, cm.MaSach, cm.NgayMuon,cm.NgayTra,cm.HanMuon,cm.TienPhat,pm.MaNV,pm.MaSV
	FROM dbo.ChiTietPhieuMuon cm, dbo.PhieuMuonSach pm
	WHERE cm.MaPM = pm.MaPM
END

GO 
CREATE PROC SP_ThemPhieuMuon (@MaPM varchar(15),@MaNV VARCHAR(15),@MaSV VARCHAR(15),@NgayMuon DATE)
AS
BEGIN 		
		INSERT dbo.PhieuMuonSach (MaPM, MaNV,MaSV, NgayMuon )
		VALUES  (@MaPM,@MaNV,@MaSV,@NgayMuon)
END 
GO
EXEC dbo.SP_ThemPhieuMuon @MaPM = N'PM9', -- nvarchar(5)
    @MaNV = N'NV01', -- nvarchar(5)
    @MaSV ='15150023', -- nvarchar(5)
    @NgayMuon = '2018-04-12 03:37:34' -- date


GO
ALTER PROC SP_ThemCTPM (@MaPM nvarchar(15), @MaSach VARCHAR(15),@NgayMuon DATE,@NgayTra DATE,@TienPhat INT)
AS
BEGIN 			
		INSERT dbo.ChiTietPhieuMuon( MaPM ,MaSach ,NgayMuon ,NgayTra ,TienPhat)
		VALUES  (@MaPM,@MaSach,@NgayMuon,@NgayTra,@TienPhat) 		
END 

GO
CREATE PROC SP_XoaCTPM @MaPM VARCHAR(5), @MaSach VARCHAR(15) 
AS
BEGIN 
		DELETE dbo.ChiTietPhieuMuon WHERE MaPM = @MaPM AND MaSach = @MaSach
END 