CREATE DATABASE bancaphe
GO
USE bancaphe
GO
CREATE TABLE nhanvien
(
     manv INT IDENTITY PRIMARY KEY,
	 name NVARCHAR(50) DEFAULT N'Quốc Đạt'
)
GO

CREATE TABLE quanly
(
     ID INT IDENTITY PRIMARY KEY,
	 name NVARCHAR(50) DEFAULT N'Đạt Quốc'
)
GO
CREATE TABLE admin1
(
     ID INT IDENTITY PRIMARY KEY,
	 name NVARCHAR(50) DEFAULT N'Đạt Quốc'
)
GO

INSERT INTO dbo.nhanvien
        ( manv, name )
VALUES  ( '3118410069', -- manv - varchar(20)
          N'Quốc Đạt' ) -- name - nvarchar(50)
INSERT INTO dbo.nhanvien
        ( manv, name )
VALUES  ( '3118410070',
          N'Quốc Đạt 1' )
INSERT INTO dbo.nhanvien
        ( manv, name )
VALUES  ( '3118410071',
          N'Quốc Đạt 2' )
INSERT INTO dbo.nhanvien
        ( manv, name )
VALUES  ( '3118410072',
          N'Quốc Đạt 3' )
DROP TABLE dbo.quanly
GO
INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Quốc Đạt'  -- name - nvarchar(50)
          )
		  INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Tường Hải'  -- name - nvarchar(50)
          )
		  INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Hồng Xương'  -- name - nvarchar(50)
          )
		  INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Quốc Huy'  -- name - nvarchar(50)
          )
		  	  INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Quốc Hùng'  -- name - nvarchar(50)
          )
		  	  INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Huy Hoàng'  -- name - nvarchar(50)
          )
		  	  INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Quốc Dũng'  -- name - nvarchar(50)
          )
		  	  INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Thùy Linh'  -- name - nvarchar(50)
          )
		  	  INSERT INTO dbo.admin1
        ( name )
VALUES  ( N'Quốc Thắng'  -- name - nvarchar(50)
          )
DROP TABLE dbo.nhanvien
GO
CREATE TABLE nhanvien
(
     manv VARCHAR(20),
	 ten NVARCHAR(30)
)
GO
INSERT INTO dbo.nhanvien
        ( manv, ten )
VALUES  ( '3118410069', -- manv - varchar(20)
          N'Quốc Đat'  -- name - nvarchar(50)
          )
INSERT INTO dbo.nhanvien
        ( manv, ten )
VALUES  ( '3118410102', -- manv - varchar(20)
          N'Tường Hải'  -- name - nvarchar(50)
          )
		  INSERT INTO dbo.nhanvien
        ( manv, ten )
VALUES  ( '3118410349', -- manv - varchar(20)
          N'Hồng Xương'  -- name - nvarchar(50)
          )
		  




          
