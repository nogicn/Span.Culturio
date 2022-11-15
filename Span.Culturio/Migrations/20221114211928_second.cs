using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Span.Culturio.Api.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CultureObject",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    companyId = table.Column<int>(type: "int", nullable: false),
                    contactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipCode = table.Column<int>(type: "int", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adminUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CultureObject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    packageId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activeFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activeTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recordedVisits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.userId);
                });

            migrationBuilder.InsertData(
                table: "CultureObject",
                columns: new[] { "id", "address", "adminUserId", "city", "companyId", "contactEmail", "name", "zipCode" },
                values: new object[] { 1, "string", 0, "string", 0, "string", "string", 0 });

            migrationBuilder.InsertData(
                table: "Subscription",
                columns: new[] { "userId", "activeFrom", "activeTo", "name", "packageId", "recordedVisits", "state" },
                values: new object[] { 1, "2022-11-11T10:29:43.317Z", "2022-11-11T10:29:43.317Z", "ayo", 0, 0, "active" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "email", "firstName", "lastName", "password", "username" },
                values: new object[] { "admin@among.us", "susy", "baki", "12344321", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CultureObject");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "email", "firstName", "lastName", "password", "username" },
                values: new object[] { "admin@fairbank.eu", "Admin", "User", "123123", "sysadmin" });
        }
    }
}
