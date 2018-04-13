USE QuanLyThuVienMTA
GO
CREATE PROC Xem_SV
AS
BEGIN
	SELECT * FROM dbo.SinhVien
END

GO

CREATE PROC Them_SV(@masv VARCHAR(50),@tensv NVARCHAR(50),@gioitinh NVARCHAR(10),@ngaysinh DATE,@sdt NCHAR(15),@lop NVARCHAR(10))
AS
BEGIN
	INSERT dbo.SinhVien
	    
	VALUES (@masv,@tensv,@gioitinh,@ngaysinh,@sdt,@lop)
END

GO
CREATE PROC Sua_SV(@masv VARCHAR(50),@tensv NVARCHAR(50),@gioitinh NVARCHAR(10),@ngaysinh DATE,@sdt NCHAR(15),@lop NVARCHAR(10))
AS
BEGIN
	UPDATE dbo.SinhVien SET TenSV=@tensv,GioiTinh=@gioitinh,NgaySinh=@ngaysinh,SoDT=@sdt,Lop=@lop
	WHERE MaSV=@masv
END

GO
CREATE PROC Xoa_SV(@masv VARCHAR(50))
AS
BEGIN
	DELETE dbo.SinhVien
	WHERE MaSV=@masv
END
