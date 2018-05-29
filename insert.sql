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