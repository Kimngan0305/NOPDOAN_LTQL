using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LTQL_DOAN.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKho = table.Column<int>(type: "int", nullable: false),
                    TenKho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LinhVuc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLinhVuc = table.Column<int>(type: "int", nullable: false),
                    TenLinhVuc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhVuc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoai = table.Column<int>(type: "int", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuyenHan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TacGia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayMat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    KhachHangID = table.Column<int>(type: "int", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChuHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoVaTenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoVaTenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XemChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTienHoaDon = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCTHD = table.Column<int>(type: "int", nullable: false),
                    MaHoaDon = table.Column<int>(type: "int", nullable: false),
                    MaSach = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<int>(type: "int", nullable: false),
                    SachID = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    HoaDonID = table.Column<int>(type: "int", nullable: false),
                    SanPhamID = table.Column<int>(type: "int", nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongBan = table.Column<short>(type: "smallint", nullable: false),
                    ThanhTien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_HoaDonID",
                        column: x => x.HoaDonID,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhaXuatBan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNXB = table.Column<int>(type: "int", nullable: false),
                    TenNXB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SachID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXuatBan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaTacGia = table.Column<int>(type: "int", nullable: false),
                    MaLinhVuc = table.Column<int>(type: "int", nullable: false),
                    MaLoai = table.Column<int>(type: "int", nullable: false),
                    MaNXB = table.Column<int>(type: "int", nullable: false),
                    GiaMua = table.Column<int>(type: "int", nullable: false),
                    GiaBia = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<int>(type: "int", nullable: false),
                    LanTaiBan = table.Column<int>(type: "int", nullable: false),
                    NamXB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TacGiaID = table.Column<int>(type: "int", nullable: false),
                    LinhVucID = table.Column<int>(type: "int", nullable: false),
                    LoaiID = table.Column<int>(type: "int", nullable: false),
                    NhaXuatBanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sach_LinhVuc_LinhVucID",
                        column: x => x.LinhVucID,
                        principalTable: "LinhVuc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_Loai_LoaiID",
                        column: x => x.LoaiID,
                        principalTable: "Loai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_NhaXuatBan_NhaXuatBanID",
                        column: x => x.NhaXuatBanID,
                        principalTable: "NhaXuatBan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_TacGia_TacGiaID",
                        column: x => x.TacGiaID,
                        principalTable: "TacGia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_HoaDonID",
                table: "ChiTietHoaDon",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_SachID",
                table: "ChiTietHoaDon",
                column: "SachID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangID",
                table: "HoaDon",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienID",
                table: "HoaDon",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_NhaXuatBan_SachID",
                table: "NhaXuatBan",
                column: "SachID");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_LinhVucID",
                table: "Sach",
                column: "LinhVucID");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_LoaiID",
                table: "Sach",
                column: "LoaiID");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_NhaXuatBanID",
                table: "Sach",
                column: "NhaXuatBanID");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TacGiaID",
                table: "Sach",
                column: "TacGiaID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_Sach_SachID",
                table: "ChiTietHoaDon",
                column: "SachID",
                principalTable: "Sach",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhaXuatBan_Sach_SachID",
                table: "NhaXuatBan",
                column: "SachID",
                principalTable: "Sach",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhaXuatBan_Sach_SachID",
                table: "NhaXuatBan");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "Kho");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "LinhVuc");

            migrationBuilder.DropTable(
                name: "Loai");

            migrationBuilder.DropTable(
                name: "NhaXuatBan");

            migrationBuilder.DropTable(
                name: "TacGia");
        }
    }
}
