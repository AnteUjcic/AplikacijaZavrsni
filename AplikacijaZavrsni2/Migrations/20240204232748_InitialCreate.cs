using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplikacijaZavrsni2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    IDVehicle = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfWheels = table.Column<int>(type: "INTEGER", nullable: false),
                    EngineType = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfDoors = table.Column<int>(type: "INTEGER", nullable: false),
                    BodyStyle = table.Column<string>(type: "TEXT", nullable: false),
                    DriveType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.IDVehicle);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    OIB = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WorkerName = table.Column<string>(type: "TEXT", nullable: false),
                    WorkerSurname = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.OIB);
                });

            migrationBuilder.CreateTable(
                name: "LoginInfos",
                columns: table => new
                {
                    IDLogin = table.Column<long>(type: "INTEGER", nullable: false),
                    OIB = table.Column<long>(type: "INTEGER", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginInfos", x => new { x.OIB, x.IDLogin });
                    table.ForeignKey(
                        name: "FK_LoginInfos_Workers_OIB",
                        column: x => x.OIB,
                        principalTable: "Workers",
                        principalColumn: "OIB",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    OIB = table.Column<long>(type: "INTEGER", nullable: false),
                    IDVehicle = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceType = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfservice = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    KMService = table.Column<double>(type: "REAL", nullable: false),
                    NextKMService = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => new { x.OIB, x.IDVehicle });
                    table.ForeignKey(
                        name: "FK_Services_Vehicle_IDVehicle",
                        column: x => x.IDVehicle,
                        principalTable: "Vehicle",
                        principalColumn: "IDVehicle");
                    table.ForeignKey(
                        name: "FK_Services_Workers_OIB",
                        column: x => x.OIB,
                        principalTable: "Workers",
                        principalColumn: "OIB");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoginInfos_OIB",
                table: "LoginInfos",
                column: "OIB",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_IDVehicle",
                table: "Services",
                column: "IDVehicle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginInfos");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
