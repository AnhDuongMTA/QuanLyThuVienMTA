USE QuanLyThuVienMTA
GO

CREATE TABLE NguoiDung
(
	TaiKhoan VARCHAR(50),
	MatKhau VARCHAR(50),
	PhanQuyen INT
)
GO

INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau, PhanQuyen )
VALUES  ( 'admin', -- TaiKhoan - varchar(50)
          'admin', -- MatKhau - varchar(50)
          1  -- PhanQuyen - int
          )
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau, PhanQuyen )
VALUES  ( N'user1', -- TaiKhoan - nvarchar(30)
          N'123',  -- MatKhau - nvarchar(30)
		   0  -- PhanQuyen - int
          )

CREATE PROC DangNhap(@TaiKhoan NCHAR(50),@MatKhau NCHAR(50))
AS
BEGIN
SELECT * FROM dbo.NguoiDung WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau
END
GO
