-- T?o cõ s? d? li?u m?i
CREATE DATABASE QuanLySinhVien;
GO

-- S? d?ng cõ s? d? li?u v?a t?o
USE QlSinhVien;
GO

-- T?o b?ng ThongTinSV
CREATE TABLE ThongTinSV (
    MaSV VARCHAR(10) PRIMARY KEY,
    TenSV NVARCHAR(100) NOT NULL,
    Lop NVARCHAR(20),
    Diem float,
    SoTinChi INT,
    GioiTinh NVARCHAR(10),
    QueQuan NVARCHAR(100),
    KhoaHoc INT
);
GO
-- Chèn 10 b?n ghi vào b?ng ThongTinSV
INSERT INTO ThongTinSV (MaSV, TenSV, Lop, Diem, SoTinChi, GioiTinh, QueQuan, KhoaHoc) VALUES
('SV001', N'Nguy?n Vãn A', N'CNTT1', 8.5, 60, N'Nam', N'Hà N?i', 2022),
('SV002', N'Tr?n Th? B', N'KT2', 7.8, 55, N'N?', N'TP. H? Chí Minh', 2021),
('SV003', N'Lê Vãn C', N'XD3', 9.1, 65, N'Nam', N'Ðà N?ng', 2022),
('SV004', N'Ph?m Th? D', N'CNTT1', 8.9, 60, N'N?', N'H?i Ph?ng', 2022),
('SV005', N'Hoàng Minh E', N'KT2', 7.5, 50, N'Nam', N'C?n Thõ', 2021),
('SV006', N'Ð? Ng?c F', N'XD3', 8.2, 70, N'N?', N'Ngh? An', 2022),
('SV007', N'V? Ð?nh G', N'CNTT1', 7.9, 60, N'Nam', N'Hà T?nh', 2021),
('SV008', N'L? Th? H', N'KT2', 9.5, 55, N'N?', N'Qu?ng Ninh', 2021),
('SV009', N'Ngô Gia K', N'XD3', 8.0, 65, N'Nam', N'Thanh Hóa', 2022),
('SV010', N'Bùi Th? L', N'CNTT1', 7.7, 60, N'N?', N'Nam Ð?nh', 2022);
GO
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(50)
);
GO

-- Chèn m?t tài kho?n m?u
INSERT INTO TaiKhoan (TenDangNhap, MatKhau)
VALUES ('admin', '123456');
GO