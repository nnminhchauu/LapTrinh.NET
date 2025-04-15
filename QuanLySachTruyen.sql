CREATE DATABASE QuanLySachTruyen;
GO

USE QuanLySachTruyen;
GO

CREATE TABLE LinhVuc (
    MaLinhVuc INT PRIMARY KEY,
    TenLinhVuc VARCHAR(255)
);

CREATE TABLE SachTruyen (
    MaSach INT PRIMARY KEY,
    TenSach VARCHAR(255),
    MaLoaiSach INT,
    MaLinhVuc INT,
    MaTG INT,
    MaNXB INT,
    SoTrang INT,
    GiaSach DECIMAL(10,2),
    FOREIGN KEY (MaLinhVuc) REFERENCES LinhVuc(MaLinhVuc),
    FOREIGN KEY (MaTG) REFERENCES TacGia(MaTG),
    FOREIGN KEY (MaNXB) REFERENCES NXB(MaNXB)
);

CREATE TABLE TacGia (
    MaTG INT PRIMARY KEY,
    TenTG VARCHAR(255),
    NgaySinh DATE,
    GioiTinh VARCHAR(10),
    DiaChi VARCHAR(255)
);

CREATE TABLE NXB (
    MaNXB INT PRIMARY KEY,
    TenNXB VARCHAR(255),
    DiaChi VARCHAR(255),
    DienThoai VARCHAR(15)
);

CREATE TABLE NgonNgu (
    MaNgonNgu INT PRIMARY KEY,
    TenNgonNgu VARCHAR(255)
);

CREATE TABLE TraSach (
    MaTra INT PRIMARY KEY,
    MaThue INT,
    MaSach INT,
    MaViPham INT,
    FOREIGN KEY (MaSach) REFERENCES SachTruyen(MaSach)
);

CREATE TABLE ThueSach (
    MaThue INT PRIMARY KEY,
    MaKhach INT,
    NgayThue DATE,
    TienDatCoc DECIMAL(10,2),
    FOREIGN KEY (MaKhach) REFERENCES KhachHang(MaKhach)
);

CREATE TABLE ChiTietThueSach (
    MaThue INT,
    MaSach INT,
    MaTinhTrang INT,
    DaTra BIT,
    PRIMARY KEY (MaThue, MaSach)
);

CREATE TABLE KhachHang (
    MaKhach INT PRIMARY KEY,
    TenKhach VARCHAR(255),
    NgaySinh DATE,
    GioiTinh VARCHAR(10),
    DiaChi VARCHAR(255)
);

CREATE TABLE ViPham (
    MaViPham INT PRIMARY KEY,
    TenViPham VARCHAR(255),
    TienPhat DECIMAL(10,2)
);

CREATE TABLE TinhTrang (
    MaTinhTrang INT PRIMARY KEY,
    TenTinhTrang VARCHAR(255)
);

CREATE TABLE CaLam (
	MaCa INT,
	TenCa VARCHAR (20)
);

CREATE TABLE NhanVien (
	MaNV VARCHAR PRIMARY KEY,
	TenNV VARCHAR(50),
	MaCa INT,
	FOREIGN KEY (MaCa) REFERENCES CaLam(MaCa),
	NamSinh INT,
	GioiTinh BIT,
	DiaChi VARCHAR(50),
	DienThoai VARCHAR (10),
	LuongThang INT
);


SELECT * FROM SachTruyen;
SELECT * FROM TinhTrang;
SELECT * FROM ViPham;
SELECT * FROM KhachHang;
SELECT * FROM ChiTietThueSach;
SELECT * FROM ThueSach;
SELECT * FROM TraSach;
SELECT * FROM NXB;
SELECT * FROM NgonNgu;
SELECT * FROM TacGia;
SELECT * FROM LinhVuc;
SELECT * FROM NhanVien;
SELECT * FROM CaLam;
SELECT * FROM NhanVien;