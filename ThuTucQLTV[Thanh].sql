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
CREATE PROC SP_ThemCTPM (@MaPM nvarchar(15), @MaSach VARCHAR(15),@NgayMuon DATE,@NgayTra DATE,@TienPhat INT)
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

-- xóa phiếu mượn không có chi tiết phiếu mượn
GO
CREATE PROC [dbo].[SP_XoaPhieuMuon] @MaPM VARCHAR(15)
 AS
 BEGIN
	DELETE dbo.PhieuMuonSach
	WHERE MaPM = @MaPM AND @MaPM NOT IN (SELECT MaPM FROM dbo.ChiTietPhieuMuon)
 END 


 --cập nhật số lượng sách sau khi mượn trả
 GO 
 CREATE PROC SP_CapNhatSoLuongSach @MaSach VARCHAR(5), @SoLuong INT 
 AS
 BEGIN
	UPDATE dbo.ChiTietSach SET SoLuong = SoLuong + @SoLuong
	WHERE MaSach = @MaSach
 end
 
 GO
  DELETE dbo.PhieuMuonSach 
  WHERE MaPM NOT IN (SELECT MaPM FROM dbo.ChiTietPhieuMuon)

  GO 
