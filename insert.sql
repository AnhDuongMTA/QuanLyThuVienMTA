INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
          NgaySinh ,
          DienThoai
        )
VALUES  ( '' , -- MaNV - varchar(50)
          N'' , -- TenNV - nvarchar(50)
          N'' , -- GioiTinh - nvarchar(10)
          GETDATE() , -- NgaySinh - date
          N''  -- DienThoai - nvarchar(15)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV01' , -- MaNV - nchar(10)
          N'Hoàng Mạnh Nam' , -- TenNV - nvarchar(50)     
          N'Nam' , -- GioiTinh - nvarchar(5)
		   '1993-09-02' , -- NgaySinh - date       
          N'0987654987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV02' , -- MaNV - nchar(10)
          N'Nguyễn Văn Mạnh' , -- TenNV - nvarchar(50)
		 N'Nam' , -- GioiTinh - nvarchar(5)
          '1992-05-12' , -- NgaySinh - date
          N'0987659107'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV03' , -- MaNV - nchar(10)
          N'Lý Thị Huyền' , -- TenNV - nvarchar(50)
		   N'Nữ' , -- GioiTinh - nvarchar(5)
          '1993-11-02' , -- NgaySinh - date    
          N'0989014987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV04' , -- MaNV - nchar(10)
          N'Lý Ngọc Minh' , -- TenNV - nvarchar(50)
		   N'Nữ' , -- GioiTinh - nvarchar(5)
          '1991-01-24' , -- NgaySinh - date
          N'0989010987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV05' , -- MaNV - nchar(10)
          N'Đào Văn Huấn' , -- TenNV - nvarchar(50)
		   N'Nam' , -- GioiTinh - nvarchar(5)
          '1991-09-02' , -- NgaySinh - date
          N'0987894987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV06' , -- MaNV - nchar(10)
          N'Trần Văn Mạnh' , -- TenNV - nvarchar(50)
		  N'Nam' , -- GioiTinh - nvarchar(5)
          '1993-01-12' , -- NgaySinh - date
          N'0989356987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV07' , -- MaNV - nchar(10)
          N'Nguyễn Huy Hoàng' , -- TenNV - nvarchar(50)
		   N'Nam' , -- GioiTinh - nvarchar(5)
          '1992-06-04' , -- NgaySinh - date
         N'09901254987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV08' , -- MaNV - nchar(10)
          N'Trần Văn Toàn' , -- TenNV - nvarchar(50)
		   N'Nam' , -- GioiTinh - nvarchar(5)
          '1995-07-03' , -- NgaySinh - date
         N'0986824987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV09' , -- MaNV - nchar(10)
          N'Trần Hữu Quyết' , -- TenNV - nvarchar(50)
		   N'Nam' , -- GioiTinh - nvarchar(5)
          '1995-02-03' , -- NgaySinh - date
         N'0990824987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
		  NgaySinh ,
          DienThoai
        )
VALUES  ( N'NV10' , -- MaNV - nchar(10)
          N'Lê Văn Huy' , -- TenNV - nvarchar(50)
		  N'Nam' , -- GioiTinh - nvarchar(5)
          '1989-04-09' , -- NgaySinh - date
          N'0986345687'  -- SoDT - nchar(20)
        )