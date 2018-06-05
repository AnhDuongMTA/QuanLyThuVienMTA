USE QuanLyThuVienMTA
GO

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

		--------------Phieu Muon Sach
INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM01','NV01','15150001','2017-12-09')

INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM02','NV02','15150002','2017-12-09')

INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM03','NV02','15150003','2017-12-09')

INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM04','NV01','15150004','2017-12-09')

INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM05','NV03','15150005','2017-12-09')

INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM06','NV04','15150006','2017-12-09')

INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM07','NV04','15150007','2017-12-09')

INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM08','NV03','15150008','2017-12-09')

INSERT dbo.PhieuMuonSach( MaPM, MaNV, MaSV, NgayMuon )
VALUES  ('PM09','NV05','15150009','2017-12-09')


--------Chi tiet phieu muon sach-----------
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM01','MS01','2017-12-09','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM01','MS02','2017-12-09','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM01','MS03','2017-12-09','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM01','MS04','2017-12-09','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM01','MS05','2017-12-09','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM01','MS06','2017-12-09','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM01','MS07','2017-12-09','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM01','MS08','2017-12-09','2018-7-09','2018-7-09',0)

INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM02','MS01','2017-12-08','2018-7-09','2018-8-09',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM02','MS02','2017-12-08','2018-7-09','2018-8-09',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM02','MS03','2017-12-08','2018-7-09','2018-8-09',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM02','MS04','2017-12-08','2018-7-09','2018-8-09',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM02','MS05','2017-12-08','2018-7-09','2018-8-09',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM02','MS06','2017-12-08','2018-7-09','2018-8-09',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM02','MS07','2017-12-08','2018-7-09','2018-8-09',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM02','MS08','2017-12-08','2018-7-09','2018-8-09',10000)

INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM03','MS01','2017-12-08','2018-7-09','2018-8-07',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM03','MS02','2017-12-08','2018-7-09','2018-8-07',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM03','MS03','2017-12-08','2018-7-09','2018-8-07',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM03','MS04','2017-12-08','2018-7-09','2018-8-07',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM03','MS05','2017-12-08','2018-7-09','2018-8-07',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM03','MS06','2017-12-08','2018-7-09','2018-8-07',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM03','MS07','2017-12-08','2018-7-09','2018-8-07',10000)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM03','MS08','2017-12-08','2018-7-09','2018-8-07',10000)

INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM04','MS01','2017-12-07','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM04','MS02','2017-12-07','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM04','MS03','2017-12-07','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM04','MS04','2017-12-07','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM04','MS05','2017-12-07','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM04','MS06','2017-12-07','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM04','MS07','2017-12-07','2018-7-09','2018-7-09',0)
INSERT dbo.ChiTietPhieuMuon ( MaPM ,MaSach ,NgayMuon ,HanMuon ,NgayTra ,TienPhat)
VALUES  ('PM04','MS08','2017-12-07','2018-7-09','2018-7-09',0)


GO
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV01','Nguyễn Hồng Sơn','Nam','1997/06/09','0123456789','KHMT')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV02','Vương Văn Thanh','Nam','1997/09/06','0123456789','KHMT')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV03','Phan Duy Dương','Nam','1997/09/06','0123456789','MMT')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV04','Nguyễn Thị Ngọc Ánh','Nữ','1997/06/09','0123456789','KTPM')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV05','Phạm Quang Minh','Nam','1997/09/06','0123456789','KHMT')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV06','Ngô Mạnh Cường','Nam','1997/06/09','0123456789','KHMT')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV07','Nguyễn Thái Sơn','Nam','1997/09/06','0123456789','KHMT')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV08','Trịnh Viết Quốc','Nam','1997/06/09','0123456789','KHMT')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV09','Nguyễn Văn Trường','Nam','1997/09/06','0123456789','KHMT')
INSERT dbo.SinhVien
        ( MaSV ,TenSV ,GioiTinh ,NgaySinh , SoDT ,Lop)
VALUES  ( 'SV10','Trọng Thị Hảo','Nữ','1997/06/09','0123456789','KHMT')


INSERT dbo.ChiTietSach
VALUES  ( 'MS01' , -- MaSach - varchar(50)
          N'Lập Trình Với Scratch' , -- TenSach - nvarchar(50)
          N' Lifelong Kindergarten Scratch' , -- TacGia - nvarchar(50)
          N'Sách CNTT' , -- TheLoai - nvarchar(50)
          N'Nhi Đồng' , -- NXB - nvarchar(50)
          N'tiếng việt' , -- NgonNgu - nvarchar(50)
          N'Khoa học công nghệ' , -- LinhVuc - nvarchar(50)
          2000, -- NamXB - int
          'VT01' , -- MaVT - varchar(50)
          1000  -- SoLuong - int
        )
INSERT dbo.ChiTietSach
VALUES  ( 'MS01' , -- MaSach - varchar(50)
          N'Design Layout Volume 1' , -- TenSach - nvarchar(50)
          N'Kindergarten' , -- TacGia - nvarchar(50)
          N'Sách CNTT' , -- TheLoai - nvarchar(50)
          N'Kim Đồng' , -- NXB - nvarchar(50)
          N'Tiếng anh' , -- NgonNgu - nvarchar(50)
          N'Khoa học công nghệ' , -- LinhVuc - nvarchar(50)
          1999 , -- NamXB - int
          'VT01' , -- MaVT - varchar(50)
          50  -- SoLuong - int
        )
INSERT dbo.ChiTietSach
VALUES  ( 'MS03' , -- MaSach - varchar(50)
          N'Giáo trình Truyền động Điện Tự động' , -- TenSach - nvarchar(50)
          N'Khương Công Minh' , -- TacGia - nvarchar(50)
          N'Sách điện điện tử' , -- TheLoai - nvarchar(50)
          N'Kim Đồng' , -- NXB - nvarchar(50)
          N'Tiếng việt' , -- NgonNgu - nvarchar(50)
          N'Khoa học kỹ thuật' , -- LinhVuc - nvarchar(50)
          1999 , -- NamXB - int
          'VT02' , -- MaVT - varchar(50)
          50  -- SoLuong - int
        )
INSERT dbo.ChiTietSach
VALUES  ( 'MS03' , -- MaSach - varchar(50)
          N'Giáo trình Kỹ thuật xung -số' , -- TenSach - nvarchar(50)
          N'LÂM TĂNG ĐỨC' , -- TacGia - nvarchar(50)
          N'Sách điện điện tử' , -- TheLoai - nvarchar(50)
          N'Tuổi trẻ' , -- NXB - nvarchar(50)
          N'Tiếng việt' , -- NgonNgu - nvarchar(50)
          N'Khoa học kỹ thuật' , -- LinhVuc - nvarchar(50)
          1990 , -- NamXB - int
          'VT02' , -- MaVT - varchar(50)
          120  -- SoLuong - int
        )
INSERT dbo.ChiTietSach
VALUES  ( 'MS04' , -- MaSach - varchar(50)
          N'Bê tông cường độ cao và chất lượng cao' , -- TenSach - nvarchar(50)
          N'GS. Phạm Duy Hữu ' , -- TacGia - nvarchar(50)
          N'Sách xây dựng' , -- TheLoai - nvarchar(50)
          N'Tuổi trẻ' , -- NXB - nvarchar(50)
          N'Tiếng việt' , -- NgonNgu - nvarchar(50)
          N'Xây dựng' , -- LinhVuc - nvarchar(50)
          1991 , -- NamXB - int
          'VT03' , -- MaVT - varchar(50)
          150  -- SoLuong - int
        )
INSERT dbo.ChiTietSach
VALUES  ( 'MS05' , -- MaSach - varchar(50)
          N'Công nghệ tiện và gia công lỗ' , -- TenSach - nvarchar(50)
          N'Trần Minh Thế Uyên' , -- TacGia - nvarchar(50)
          N'Sách cơ khí' , -- TheLoai - nvarchar(50)
          N'Đại học Quốc gia TP. HCM' , -- NXB - nvarchar(50)
          N'Tiếng việt' , -- NgonNgu - nvarchar(50)
          N'Cơ khí' , -- LinhVuc - nvarchar(50)
          1990 , -- NamXB - int
          'VT04' , -- MaVT - varchar(50)
          95  -- SoLuong - int
        )
INSERT dbo.ChiTietSach
VALUES  ( 'MS06' , -- MaSach - varchar(50)
          N'English for the Automobile Industry' , -- TenSach - nvarchar(50)
          N'Express Series,' , -- TacGia - nvarchar(50)
          N'Sách ô tô' , -- TheLoai - nvarchar(50)
          N'Oxford Business English.' , -- NXB - nvarchar(50)
          N'Tiếng anh' , -- NgonNgu - nvarchar(50)
          N'Ô tô' , -- LinhVuc - nvarchar(50)
          1980 , -- NamXB - int
          'VT05' , -- MaVT - varchar(50)
          90  -- SoLuong - int
        )

INSERT dbo.ChiTietSach
VALUES  ( 'MS07' , -- MaSach - varchar(50)
          N'Cơ bản về hàng không vũ trụ' , -- TenSach - nvarchar(50)
          N'Rouker,' , -- TacGia - nvarchar(50)
          N'Sách hàng không' , -- TheLoai - nvarchar(50)
          N'Tuổi trẻ.' , -- NXB - nvarchar(50)
          N'Tiếng việt' , -- NgonNgu - nvarchar(50)
          N'hàng không vũ trụ' , -- LinhVuc - nvarchar(50)
          2002 , -- NamXB - int
          'VT07' , -- MaVT - varchar(50)
          100  -- SoLuong - int
        )
INSERT dbo.ChiTietSach
VALUES  ( 'MS08' , -- MaSach - varchar(50)
          N'Giới thiệu sách "Chuyên ngành Cơ Điện Tử' , -- TenSach - nvarchar(50)
          N'Omen,' , -- TacGia - nvarchar(50)
          N'Sách cơ điện tử' , -- TheLoai - nvarchar(50)
          N'Tuổi trẻ.' , -- NXB - nvarchar(50)
          N'Tiếng việt' , -- NgonNgu - nvarchar(50)
          N'Cơ điện tử' , -- LinhVuc - nvarchar(50)
          2000 , -- NamXB - int
          'VT08' , -- MaVT - varchar(50)
          100  -- SoLuong - int
        )
INSERT dbo.ChiTietSach
VALUES  ( 'MS09' , -- MaSach - varchar(50)
          N'HÓA HỌC VÔ CƠ ' , -- TenSach - nvarchar(50)
          N'HOÀNG NHÂM,' , -- TacGia - nvarchar(50)
          N'Sách hóa học' , -- TheLoai - nvarchar(50)
          N'Kim đồng.' , -- NXB - nvarchar(50)
          N'Tiếng việt' , -- NgonNgu - nvarchar(50)
          N'Hóa học' , -- LinhVuc - nvarchar(50)
          1995 , -- NamXB - int
          'VT06' , -- MaVT - varchar(50)
          100  -- SoLuong - int
        )