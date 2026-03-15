using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Lich_Lam_Viec.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chuc_Vu",
                columns: table => new
                {
                    MaChucVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chuc_Vu", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "Dia_Diem",
                columns: table => new
                {
                    MaDiaDiem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDiaDiem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChiCuThe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucChua = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dia_Diem", x => x.MaDiaDiem);
                });

            migrationBuilder.CreateTable(
                name: "Loai_Cong_Viec",
                columns: table => new
                {
                    MaLoaiCV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai_Cong_Viec", x => x.MaLoaiCV);
                });

            migrationBuilder.CreateTable(
                name: "Phan_Quyen",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phan_Quyen", x => x.MaQuyen);
                });

            migrationBuilder.CreateTable(
                name: "Phong_Ban",
                columns: table => new
                {
                    MaPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong_Ban", x => x.MaPhong);
                });

            migrationBuilder.CreateTable(
                name: "Lich_Lam_Viec",
                columns: table => new
                {
                    MaLich = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongDuKien = table.Column<int>(type: "int", nullable: false),
                    MaLoaiCV = table.Column<int>(type: "int", nullable: false),
                    MaDiaDiem = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lich_Lam_Viec", x => x.MaLich);
                    table.ForeignKey(
                        name: "FK_Lich_Lam_Viec_Dia_Diem_MaDiaDiem",
                        column: x => x.MaDiaDiem,
                        principalTable: "Dia_Diem",
                        principalColumn: "MaDiaDiem");
                    table.ForeignKey(
                        name: "FK_Lich_Lam_Viec_Loai_Cong_Viec_MaLoaiCV",
                        column: x => x.MaLoaiCV,
                        principalTable: "Loai_Cong_Viec",
                        principalColumn: "MaLoaiCV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nhan_Vien",
                columns: table => new
                {
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    MaChucVu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhan_Vien", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_Nhan_Vien_Chuc_Vu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "Chuc_Vu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nhan_Vien_Phong_Ban_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phong_Ban",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tien_Do_Cong_Viec",
                columns: table => new
                {
                    MaTienDo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLich = table.Column<int>(type: "int", nullable: false),
                    PhanTramHoanThanh = table.Column<int>(type: "int", nullable: false),
                    LyDoTreHan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tien_Do_Cong_Viec", x => x.MaTienDo);
                    table.ForeignKey(
                        name: "FK_Tien_Do_Cong_Viec_Lich_Lam_Viec_MaLich",
                        column: x => x.MaLich,
                        principalTable: "Lich_Lam_Viec",
                        principalColumn: "MaLich",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chi_Tiet_Phan_Cong",
                columns: table => new
                {
                    MaPhanCong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    MaLich = table.Column<int>(type: "int", nullable: false),
                    Vai_Tro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Da_Xac_Nhan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chi_Tiet_Phan_Cong", x => x.MaPhanCong);
                    table.ForeignKey(
                        name: "FK_Chi_Tiet_Phan_Cong_Lich_Lam_Viec_MaLich",
                        column: x => x.MaLich,
                        principalTable: "Lich_Lam_Viec",
                        principalColumn: "MaLich",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chi_Tiet_Phan_Cong_Nhan_Vien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "Nhan_Vien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lich_Su_He_Thong",
                columns: table => new
                {
                    MaLog = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<int>(type: "int", nullable: true),
                    HanhDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lich_Su_He_Thong", x => x.MaLog);
                    table.ForeignKey(
                        name: "FK_Lich_Su_He_Thong_Nhan_Vien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "Nhan_Vien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "Tai_Khoan",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tai_Khoan", x => x.Username);
                    table.ForeignKey(
                        name: "FK_Tai_Khoan_Nhan_Vien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "Nhan_Vien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tai_Khoan_Phan_Quyen_MaQuyen",
                        column: x => x.MaQuyen,
                        principalTable: "Phan_Quyen",
                        principalColumn: "MaQuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chi_Tiet_Phan_Cong_MaLich",
                table: "Chi_Tiet_Phan_Cong",
                column: "MaLich");

            migrationBuilder.CreateIndex(
                name: "IX_Chi_Tiet_Phan_Cong_MaNhanVien",
                table: "Chi_Tiet_Phan_Cong",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Lich_Lam_Viec_MaDiaDiem",
                table: "Lich_Lam_Viec",
                column: "MaDiaDiem");

            migrationBuilder.CreateIndex(
                name: "IX_Lich_Lam_Viec_MaLoaiCV",
                table: "Lich_Lam_Viec",
                column: "MaLoaiCV");

            migrationBuilder.CreateIndex(
                name: "IX_Lich_Su_He_Thong_MaNhanVien",
                table: "Lich_Su_He_Thong",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Nhan_Vien_MaChucVu",
                table: "Nhan_Vien",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_Nhan_Vien_MaPhong",
                table: "Nhan_Vien",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Tai_Khoan_MaNhanVien",
                table: "Tai_Khoan",
                column: "MaNhanVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tai_Khoan_MaQuyen",
                table: "Tai_Khoan",
                column: "MaQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_Tien_Do_Cong_Viec_MaLich",
                table: "Tien_Do_Cong_Viec",
                column: "MaLich");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chi_Tiet_Phan_Cong");

            migrationBuilder.DropTable(
                name: "Lich_Su_He_Thong");

            migrationBuilder.DropTable(
                name: "Tai_Khoan");

            migrationBuilder.DropTable(
                name: "Tien_Do_Cong_Viec");

            migrationBuilder.DropTable(
                name: "Nhan_Vien");

            migrationBuilder.DropTable(
                name: "Phan_Quyen");

            migrationBuilder.DropTable(
                name: "Lich_Lam_Viec");

            migrationBuilder.DropTable(
                name: "Chuc_Vu");

            migrationBuilder.DropTable(
                name: "Phong_Ban");

            migrationBuilder.DropTable(
                name: "Dia_Diem");

            migrationBuilder.DropTable(
                name: "Loai_Cong_Viec");
        }
    }
}
