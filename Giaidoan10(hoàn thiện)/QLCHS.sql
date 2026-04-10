IF DB_ID(N'QLCHS') IS NULL
BEGIN
    CREATE DATABASE QLCHS;
END
GO
USE QLCHS;
GO
DECLARE
    @TacGia1ID INT, @TacGia2ID INT,
    @LinhVuc1ID INT, @LinhVuc2ID INT,
    @Loai1ID INT, @Loai2ID INT,
    @NhaXuatBan1ID INT, @NhaXuatBan2ID INT,
    @Sach1ID INT, @Sach2ID INT,
    @Sach1MaSach NVARCHAR(450), @Sach2MaSach NVARCHAR(450),
    @NhanVien1ID INT, @KhachHang1ID INT,
    @HoaDon1ID INT;
-- ===== TacGia =====
IF NOT EXISTS (SELECT 1 FROM dbo.TacGia WHERE TenTacGia = N'Tac Gia 1')
BEGIN
    INSERT INTO dbo.TacGia (MaTacGia, TenTacGia, QueQuan, NgaySinh, NgayMat)
    VALUES (N'0', N'Tac Gia 1', N'Hanoi', '2000-01-01', NULL);
    SET @TacGia1ID = SCOPE_IDENTITY();
    UPDATE dbo.TacGia SET MaTacGia = CAST(@TacGia1ID AS NVARCHAR(MAX)) WHERE ID = @TacGia1ID;
    INSERT INTO dbo.TacGia (MaTacGia, TenTacGia, QueQuan, NgaySinh, NgayMat)
    VALUES (N'0', N'Tac Gia 2', N'HCM', '1999-01-01', NULL);
    SET @TacGia2ID = SCOPE_IDENTITY();
    UPDATE dbo.TacGia SET MaTacGia = CAST(@TacGia2ID AS NVARCHAR(MAX)) WHERE ID = @TacGia2ID;
END
ELSE
BEGIN
    SELECT TOP(1) @TacGia1ID = ID FROM dbo.TacGia WHERE TenTacGia = N'Tac Gia 1';
    SELECT TOP(1) @TacGia2ID = ID FROM dbo.TacGia WHERE TenTacGia = N'Tac Gia 2';
    -- đảm bảo MaTacGia dạng số để form cast int không lỗi
    UPDATE dbo.TacGia SET MaTacGia = CAST(ID AS NVARCHAR(MAX)) WHERE ID IN (@TacGia1ID, @TacGia2ID);
END
-- ===== LinhVuc =====
IF NOT EXISTS (SELECT 1 FROM dbo.LinhVuc WHERE TenLinhVuc = N'Công nghệ')
BEGIN
    INSERT INTO dbo.LinhVuc (MaLinhVuc, TenLinhVuc) VALUES (0, N'Công nghệ');
    SET @LinhVuc1ID = SCOPE_IDENTITY();
    UPDATE dbo.LinhVuc SET MaLinhVuc = @LinhVuc1ID WHERE ID = @LinhVuc1ID;
    INSERT INTO dbo.LinhVuc (MaLinhVuc, TenLinhVuc) VALUES (0, N'Kinh tế');
    SET @LinhVuc2ID = SCOPE_IDENTITY();
    UPDATE dbo.LinhVuc SET MaLinhVuc = @LinhVuc2ID WHERE ID = @LinhVuc2ID;
END
ELSE
BEGIN
    SELECT TOP(1) @LinhVuc1ID = ID FROM dbo.LinhVuc WHERE TenLinhVuc = N'Công nghệ';
    SELECT TOP(1) @LinhVuc2ID = ID FROM dbo.LinhVuc WHERE TenLinhVuc = N'Kinh tế';
    UPDATE dbo.LinhVuc SET MaLinhVuc = ID WHERE ID IN (@LinhVuc1ID, @LinhVuc2ID);
END
-- ===== Loai =====
IF NOT EXISTS (SELECT 1 FROM dbo.Loai WHERE TenLoai = N'Sách kỹ năng')
BEGIN
    INSERT INTO dbo.Loai (MaLoai, TenLoai) VALUES (0, N'Sách kỹ năng');
    SET @Loai1ID = SCOPE_IDENTITY();
    UPDATE dbo.Loai SET MaLoai = @Loai1ID WHERE ID = @Loai1ID;
    INSERT INTO dbo.Loai (MaLoai, TenLoai) VALUES (0, N'Sách quản trị');
    SET @Loai2ID = SCOPE_IDENTITY();
    UPDATE dbo.Loai SET MaLoai = @Loai2ID WHERE ID = @Loai2ID;
END
ELSE
BEGIN
    SELECT TOP(1) @Loai1ID = ID FROM dbo.Loai WHERE TenLoai = N'Sách kỹ năng';
    SELECT TOP(1) @Loai2ID = ID FROM dbo.Loai WHERE TenLoai = N'Sách quản trị';
    UPDATE dbo.Loai SET MaLoai = ID WHERE ID IN (@Loai1ID, @Loai2ID);
END
-- ===== NhaXuatBan =====
IF NOT EXISTS (SELECT 1 FROM dbo.NhaXuatBan WHERE TenNXB = N'NXB Trẻ')
BEGIN
    INSERT INTO dbo.NhaXuatBan (MaNXB, TenNXB, DiaChi, DienThoai, Email, SachID)
    VALUES (0, N'NXB Trẻ', N'Hanoi', '0900000001', 'tre@example.com', NULL);
    SET @NhaXuatBan1ID = SCOPE_IDENTITY();
    UPDATE dbo.NhaXuatBan SET MaNXB = @NhaXuatBan1ID WHERE ID = @NhaXuatBan1ID;
    INSERT INTO dbo.NhaXuatBan (MaNXB, TenNXB, DiaChi, DienThoai, Email, SachID)
    VALUES (0, N'NXB Giáo Dục', N'HCM', '0900000002', 'gd@example.com', NULL);
    SET @NhaXuatBan2ID = SCOPE_IDENTITY();
    UPDATE dbo.NhaXuatBan SET MaNXB = @NhaXuatBan2ID WHERE ID = @NhaXuatBan2ID;
END
ELSE
BEGIN
    SELECT TOP(1) @NhaXuatBan1ID = ID FROM dbo.NhaXuatBan WHERE TenNXB = N'NXB Trẻ';
    SELECT TOP(1) @NhaXuatBan2ID = ID FROM dbo.NhaXuatBan WHERE TenNXB = N'NXB Giáo Dục';
    UPDATE dbo.NhaXuatBan SET MaNXB = ID WHERE ID IN (@NhaXuatBan1ID, @NhaXuatBan2ID);
END
-- ===== Sach + Kho =====
IF NOT EXISTS (SELECT 1 FROM dbo.Sach WHERE TenSach = N'Lap trinh C# co ban')
BEGIN
    INSERT INTO dbo.Sach
    (
        MaSach, TenSach,
        MaTacGia, TacGiaID,
        MaLinhVuc, LinhVucID,
        MaLoai, LoaiID,
        MaNXB, NhaXuatBanID,
        GiaMua, GiaBia, DonGiaBan, LanTaiBan, NamXB
    )
    VALUES
    (
        N'0', N'Lap trinh C# co ban',
        0, @TacGia1ID,
        0, @LinhVuc1ID,
        0, @Loai1ID,
        0, @NhaXuatBan1ID,
        50000, 65000, 70000, 1, '2021-01-01'
    );
    SET @Sach1ID = SCOPE_IDENTITY();
    UPDATE dbo.Sach
        SET MaSach = CAST(@Sach1ID AS NVARCHAR(450)),
            MaTacGia = @TacGia1ID,
            MaLinhVuc = @LinhVuc1ID,
            MaLoai = @Loai1ID,
            MaNXB = @NhaXuatBan1ID
    WHERE ID = @Sach1ID;
    SET @Sach1MaSach = CAST(@Sach1ID AS NVARCHAR(450));
    INSERT INTO dbo.Sach
    (
        MaSach, TenSach,
        MaTacGia, TacGiaID,
        MaLinhVuc, LinhVucID,
        MaLoai, LoaiID,
        MaNXB, NhaXuatBanID,
        GiaMua, GiaBia, DonGiaBan, LanTaiBan, NamXB
    )
    VALUES
    (
        N'0', N'Quản trị dự án phần mềm',
        0, @TacGia2ID,
        0, @LinhVuc2ID,
        0, @Loai2ID,
        0, @NhaXuatBan2ID,
        60000, 80000, 90000, 1, '2022-01-01'
    );
    SET @Sach2ID = SCOPE_IDENTITY();
    UPDATE dbo.Sach
        SET MaSach = CAST(@Sach2ID AS NVARCHAR(450)),
            MaTacGia = @TacGia2ID,
            MaLinhVuc = @LinhVuc2ID,
            MaLoai = @Loai2ID,
            MaNXB = @NhaXuatBan2ID
    WHERE ID = @Sach2ID;
    SET @Sach2MaSach = CAST(@Sach2ID AS NVARCHAR(450));
END
ELSE
BEGIN
    SELECT TOP(1) @Sach1ID = ID FROM dbo.Sach WHERE TenSach = N'Lap trinh C# co ban';
    SELECT TOP(1) @Sach2ID = ID FROM dbo.Sach WHERE TenSach = N'Quản trị dự án phần mềm';
    SET @Sach1MaSach = CAST(@Sach1ID AS NVARCHAR(450));
    SET @Sach2MaSach = CAST(@Sach2ID AS NVARCHAR(450));
END
IF NOT EXISTS (SELECT 1 FROM dbo.Kho WHERE TenKho = N'Kho A')
BEGIN
    INSERT INTO dbo.Kho (MaKho, TenKho, MaSach, SachID, SoLuong)
    VALUES (1, N'Kho A', @Sach1MaSach, @Sach1ID, 50);
    INSERT INTO dbo.Kho (MaKho, TenKho, MaSach, SachID, SoLuong)
    VALUES (2, N'Kho B', @Sach2MaSach, @Sach2ID, 30);
END
-- ===== NhanVien + KhachHang =====
IF NOT EXISTS (SELECT 1 FROM dbo.NhanVien WHERE TenDangNhap = N'nv01')
BEGIN
    INSERT INTO dbo.NhanVien (HoVaTen, DienThoai, DiaChi, TenDangNhap, MatKhau, QuyenHan)
    VALUES (N'NV 1', N'0900000001', N'Hanoi', N'nv01', N'123', 0);
    SET @NhanVien1ID = SCOPE_IDENTITY();
END
ELSE
BEGIN
    SELECT TOP(1) @NhanVien1ID = ID FROM dbo.NhanVien WHERE TenDangNhap = N'nv01';
END
IF NOT EXISTS (SELECT 1 FROM dbo.KhachHang WHERE HoVaTen = N'KH 1')
BEGIN
    INSERT INTO dbo.KhachHang (HoVaTen, SDT, DiaChi)
    VALUES (N'KH 1', N'0911111111', N'Hanoi');
    SET @KhachHang1ID = SCOPE_IDENTITY();
END
ELSE
BEGIN
    SELECT TOP(1) @KhachHang1ID = ID FROM dbo.KhachHang WHERE HoVaTen = N'KH 1';
END
-- ===== HoaDon + ChiTietHoaDon =====
IF NOT EXISTS (
    SELECT 1 FROM dbo.HoaDon
    WHERE HoVaTenNhanVien = N'NV 1' AND HoVaTenKhachHang = N'KH 1'
)
BEGIN
    INSERT INTO dbo.HoaDon
    (
        NhanVienID, KhachHangID, NgayLap,
        GhiChuHoaDon,
        HoVaTenNhanVien, HoVaTenKhachHang,
        XemChiTiet, TongTienHoaDon
    )
    VALUES
    (
        @NhanVien1ID, @KhachHang1ID, GETDATE(),
        N'Tao du lieu mau',
        N'NV 1', N'KH 1',
        NULL, NULL
    );
    SET @HoaDon1ID = SCOPE_IDENTITY();
    INSERT INTO dbo.ChiTietHoaDon
    (
        MaCTHD, MaHoaDon, MaSach,
        SoLuong, DonGiaBan,
        SachID, GiaBan,
        HoaDonID, SanPhamID,
        TenSach, SoLuongBan, ThanhTien
    )
    VALUES
    (
        1, @HoaDon1ID, @Sach1ID,
        2, 70000,
        @Sach1ID, 70000,
        @HoaDon1ID, @Sach1ID,
        N'Lap trinh C# co ban',
        2, 140000
    );
    INSERT INTO dbo.ChiTietHoaDon
    (
        MaCTHD, MaHoaDon, MaSach,
        SoLuong, DonGiaBan,
        SachID, GiaBan,
        HoaDonID, SanPhamID,
        TenSach, SoLuongBan, ThanhTien
    )
    VALUES
    (
        2, @HoaDon1ID, @Sach2ID,
        1, 90000,
        @Sach2ID, 90000,
        @HoaDon1ID, @Sach2ID,
        N'Quản trị dự án phần mềm',
        1, 90000
    );
END
ELSE
BEGIN
    SELECT TOP(1) @HoaDon1ID = ID
    FROM dbo.HoaDon
    WHERE HoVaTenNhanVien = N'NV 1' AND HoVaTenKhachHang = N'KH 1';
END