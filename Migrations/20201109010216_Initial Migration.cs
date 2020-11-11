using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tour.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiPhis",
                columns: table => new
                {
                    chiphi_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doan_id = table.Column<int>(nullable: false),
                    tongchiphi = table.Column<float>(nullable: false),
                    chitiet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhis", x => x.chiphi_id);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTours",
                columns: table => new
                {
                    chitiet_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(nullable: false),
                    diadiem_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTours", x => x.chitiet_id);
                });

            migrationBuilder.CreateTable(
                name: "DiaDiems",
                columns: table => new
                {
                    diadiem_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thanhpho = table.Column<string>(nullable: false),
                    ten = table.Column<string>(nullable: false),
                    mota = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDiems", x => x.diadiem_id);
                });

            migrationBuilder.CreateTable(
                name: "Doans",
                columns: table => new
                {
                    doan_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(nullable: false),
                    ten = table.Column<string>(nullable: false),
                    NgayDi = table.Column<DateTime>(nullable: false),
                    NgayVe = table.Column<DateTime>(nullable: false),
                    ChiTietChuongTrinh = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doans", x => x.doan_id);
                });

            migrationBuilder.CreateTable(
                name: "Gias",
                columns: table => new
                {
                    gia_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sotien = table.Column<int>(nullable: false),
                    tungay = table.Column<DateTime>(nullable: false),
                    denngay = table.Column<DateTime>(nullable: false),
                    toud_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gias", x => x.gia_id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    kh_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kh_ten = table.Column<string>(maxLength: 50, nullable: false),
                    kh_sdt = table.Column<string>(maxLength: 50, nullable: false),
                    kh_ngaysinh = table.Column<string>(maxLength: 50, nullable: true),
                    kh_email = table.Column<string>(maxLength: 50, nullable: true),
                    kh_cmnd = table.Column<string>(fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LoaiChiPhis",
                columns: table => new
                {
                    chiphi_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(nullable: false),
                    mota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiChiPhis", x => x.chiphi_id);
                });

            migrationBuilder.CreateTable(
                name: "Loais",
                columns: table => new
                {
                    loai_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(nullable: false),
                    mota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loais", x => x.loai_id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDis",
                columns: table => new
                {
                    nguoidi_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doan_id = table.Column<int>(nullable: false),
                    danhsachnhanvien = table.Column<string>(nullable: true),
                    danhsachkhach = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDis", x => x.nguoidi_id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    nv_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nv_ten = table.Column<string>(maxLength: 50, nullable: false),
                    nv_sdt = table.Column<string>(maxLength: 50, nullable: true),
                    nv_ngaysinh = table.Column<string>(maxLength: 50, nullable: false),
                    nv_email = table.Column<string>(maxLength: 50, nullable: true),
                    nv_nhiemvu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(nullable: false),
                    mota = table.Column<string>(nullable: false),
                    loai_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiPhis");

            migrationBuilder.DropTable(
                name: "ChiTietTours");

            migrationBuilder.DropTable(
                name: "DiaDiems");

            migrationBuilder.DropTable(
                name: "Doans");

            migrationBuilder.DropTable(
                name: "Gias");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "LoaiChiPhis");

            migrationBuilder.DropTable(
                name: "Loais");

            migrationBuilder.DropTable(
                name: "NguoiDis");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
