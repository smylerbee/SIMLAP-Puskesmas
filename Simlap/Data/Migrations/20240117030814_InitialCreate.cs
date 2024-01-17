using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simlap.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LapSpms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpmInfoId = table.Column<int>(type: "int", nullable: false),
                    Mmodified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpmId = table.Column<int>(type: "int", nullable: false),
                    SpmReq = table.Column<int>(type: "int", nullable: false),
                    SpmVal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapSpms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pegawais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GolPangkat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pegawais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpmHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpmHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpmInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tahun = table.Column<int>(type: "int", nullable: false),
                    Triwulan = table.Column<int>(type: "int", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpmInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpmHeaderId = table.Column<int>(type: "int", nullable: false),
                    IndexOfHeader = table.Column<int>(type: "int", nullable: false),
                    Indikator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Satuan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uptds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puskesmas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uptds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPkms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPkms", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LapSpms");

            migrationBuilder.DropTable(
                name: "Pegawais");

            migrationBuilder.DropTable(
                name: "SpmHeaders");

            migrationBuilder.DropTable(
                name: "SpmInfos");

            migrationBuilder.DropTable(
                name: "Spms");

            migrationBuilder.DropTable(
                name: "Uptds");

            migrationBuilder.DropTable(
                name: "UserPkms");
        }
    }
}
