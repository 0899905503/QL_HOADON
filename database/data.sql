 USE [QLHOADON]
 CREATE TABLE PHONGBAN (
  MAPHONG nvarchar(10) NOT NULL PRIMARY KEY,
  TENPHONG nvarchar(50) NOT NULL,
  DIENTHOAI nvarchar(11) NULL
);

CREATE TABLE NHANVIEN (
  MANV nvarchar(10) NOT NULL PRIMARY KEY,
  HOTEN nvarchar(50) NOT NULL,
  PHAI bit NOT NULL,
  NGAYSINH date NOT NULL,
  HSLUONG float NOT NULL,
  HSCHUCVU float NOT NULL,
  MAPHONG nvarchar(10) NOT NULL,
  FOREIGN KEY (MAPHONG) REFERENCES PHONGBAN(MAPHONG)
);

CREATE TABLE HANGHOA (
  MAHH nvarchar(10) NOT NULL PRIMARY KEY,
  TENHH nvarchar(50) NOT NULL,
  NGAYSX date NOT NULL,
  DONGIA float NOT NULL
);

CREATE TABLE HOADON (
  SOHD nvarchar(10) NOT NULL PRIMARY KEY,
  KHACHHANG nvarchar(50) NOT NULL,
  DIACHI nvarchar(50) NOT NULL,
  DIENTHOAI nvarchar(10) NULL,
  NGAYHD date NOT NULL,
  MANV nvarchar(10) NOT NULL,
  FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

CREATE TABLE CTHOADON (
  SOHD nvarchar(10) NOT NULL,
  MAHH nvarchar(10) NOT NULL,
  SOLUONG int NOT NULL,
  PRIMARY KEY (SOHD, MAHH),
  FOREIGN KEY (SOHD) REFERENCES HOADON(SOHD),
  FOREIGN KEY (MAHH) REFERENCES HANGHOA(MAHH)
);

CREATE TABLE TAIKHOAN (
  USER_NAME varchar(50) NOT NULL PRIMARY KEY,
  PASSWORD varchar(50) NOT NULL,
  NAME nvarchar(50) NOT NULL,
  PERMISSON varchar(20),
  CONSTRAINT CHECK_PERMISSON CHECK (PERMISSON IN ('USER', 'ADMIN'))
);

--
INSERT INTO PHONGBAN (MAPHONG, TENPHONG, DIENTHOAI)
VALUES (N'QHKH', N'Quan hệ khách hàng', '02573827890'),
       (N'TBKT', N'Phòng thiết bị kỹ thuật', '02573826641'),
       (N'TCHC', N'Phòng tổ chức hành chính', '20573825678'),
       (N'TCKT', N'Phòng kế toán Tài chính', '02573829087');

INSERT INTO NHANVIEN (MANV, HOTEN, PHAI, NGAYSINH, HSLUONG, HSCHUCVU, MAPHONG)
VALUES 
        ('NV001', N'Lê Anh Tú', 1, '1985-09-23', 3.99, 0.4, N'TCKT'),
        ('NV002', N'Trần Thanh Hoa', 0, '1987-02-27', 3.99, 0.3, N'QHKH'),
        ('NV003', N'Nguyễn Lan Hương', 1, '1977-09-30', 2.67, 0, N'TCKT'),
        ('NV004', N'Trần Quang Nghị', 1, '1978-02-01', 4.32, 0.5, N'TCHC'),
        ('NV005', N'Hồ Minh Cảnh', 1, '1984-10-10', 3.33, 0.2, N'TBKT'),
        ('NV006', N'Trần Thái Bao', 1, '1979-07-23', 3, 0.02, N'QHKH'),
        ('NV007', N'Trần Thái Phong', 1, '1988-01-28', 3, 0.02, N'TCHC'),
        ('NV008', N'Trần Phú', 1, '1986-05-12', 4.32, 0.5, N'TBKT'),
        ('NV009', N'Lê Thanh Tùng', 1, '1986-10-22', 3.66, 0, N'TBKT'),
        ('NV010', N'Trần Thái Sơn', 1, '1977-04-30', 3.99, 0.5, N'TCKT'),
        ('NV011', N'Huỳnh Thị Kim Chung', 0, '1982-06-02', 3.33, 0.3, N'QHKH'),
        ('NV013', N'Tran Long An', 1, '1995-07-20', 2.34, 0.4, N'TCKT'),
        ('NV014', N'Trần Minh Hoàng', 1, '1979-10-04', 4.32, 0.5, N'TCHC'),
        ('NV015', N'Tô Thành Trung', 1, '1996-07-23', 3.99, 0.3, N'TCHC'),
        ('NV018', N'Trần Minh Hoàng', 1, '1986-10-15', 3.99, 0.3, N'QHKH');

INSERT INTO HANGHOA (MAHH, TENHH, NGAYSX, DONGIA)
VALUES
        (N'AM1100', N'Âm ly California', '2015-10-10', 4000000),
        (N'AT0011', N'Máy nóng lạnh Ariston', '2013-10-28', 2200000),
        (N'FN0099', N'Máy nóng lạng Fenoli', '2017-10-01', 2800000),
        (N'LG1122', N'TV LG 65 inches', '2018-01-01', 18000000),
        (N'PA1100', N'TV Panasonic 42 inches', '2018-07-25', 7200000),
        (N'PA2200', N'Máy giặt Panasonic 7.2Kg', '2018-10-12', 7200000),
        (N'SM0022', N'Máy giặt SamSung 6.8 Kg', '2014-05-01', 4200000),
        (N'SM0033', N'TV SamSung 42 inches', '2016-08-12', 5400000),
        (N'SM0044', N'TV SamSung 65 inches', '2018-10-15', 5400000),
        (N'SY0011', N'Tủ Lạnh Sanyo FJ14', '2016-05-11', 3800000),
        (N'SY0022', N'Tủ Lạnh Sanyo FJ18', '2015-10-20', 4500000),
        (N'TCL123', N'TV TCL 48 inches', '2016-10-15', 3200000),
        (N'123456', N'Hàng mới', '2023-11-10', 10000000);

INSERT INTO HOADON (SOHD, KHACHHANG, DIACHI, DIENTHOAI, NGAYHD, MANV)
VALUES
        ('HD001', N'Lê Anh Tuấn', N'Phú Yên', '0986804133', '2018-09-12', 'NV001'),
        ('HD002', N'Bùi Long Thành', N'Nha Trang', '0980789128', '2018-08-22', 'NV001'),
        ('HD003', N'Nguyễn Thành Trung', N'Nha Trang', '0987678677', '2018-07-23', 'NV001'),
        ('HD004', N'Trần Thái Phong', N'Phú Yên', '0970908921', '2018-09-09', 'NV002'),
        ('HD005', N'Trần Nguyễn Thảo', N'Bình Định.', '0912456709', '2018-04-04', 'NV002'),
        ('HD006', N'Lê Hồng Anh', N'Phú Yên', '0912345678', '2018-02-02', 'NV003'),
        ('HD007', N'Trần Thành Long', N'Nha Trang', '0912345678', '2018-01-11', 'NV007'),
        ('HD008', N'Nguyễn Lan Hương', N'Phú Yên', '0912090989', '2018-03-04', 'NV003'),
        ('HD009', N'Trần Thái Nguyên', N'Bình Định', '0981907845', '2018-06-06', 'NV005'),
        ('HD010', N'Trần Quang Nghị', N'Phú Yên', '0986804138', '2018-08-20', 'NV006'),
        ('HD011', N'Lê Thái Hòa', N'Nha Trang', '0912986789', '2018-04-04', 'NV003');


INSERT INTO CTHOADON (SOHD, MAHH, SOLUONG)
VALUES
        ('HD001', 'AM1100', 10),
        ('HD001', 'AT0011', 5),
        ('HD001', 'FN0099', 20),
        ('HD001', 'SM0022', 10),
        ('HD002', 'FN0099', 10),
        ('HD002', 'SM0033', 20),
        ('HD002', 'SM0044', 10),
        ('HD003', 'AM1100', 50),
        ('HD003', 'FN0099', 20),
        ('HD004', 'SM0022', 20),
        ('HD004', 'SY0011', 10),
        ('HD004', 'SY0022', 40),
        ('HD005', 'FN0099', 10),
        ('HD005', 'SY0011', 10),
        ('HD006', 'FN0099', 30),
        ('HD006', 'SY0011', 10),
        ('HD006', 'SM0022', 20),
        ('HD007', 'AM1100', 20),
        ('HD007', 'AT0011', 10),
        ('HD008', 'FN0099', 30),
        ('HD008', 'SM0044', 30);
