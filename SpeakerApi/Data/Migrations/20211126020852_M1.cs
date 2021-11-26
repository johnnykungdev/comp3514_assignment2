using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerApi.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    SpeakerId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    MobileNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Specialization = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Province = table.Column<string>(type: "TEXT", nullable: true),
                    Employer = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.SpeakerId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province", "Specialization" },
                values: new object[] { "42f47adf-e619-430f-ab1c-5d002f585fba", "Chilliwack", "jim@bar.ca", "BC Hydro", "Jim", "Bar", "2223334444", "BC", "Software engineer" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province", "Specialization" },
                values: new object[] { "2f45d79a-b7ea-4579-b7b8-ad8c2f4816b1", "Vancouver", "jane@amazon.ca", "Amazon", "Jane", "Douglas", "3334445555", "BC", "Software engineer" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province", "Specialization" },
                values: new object[] { "c5ebbc74-0849-4218-901a-e666d25e2189", "Richmond", "tom@ubc.ca", "UBC", "Tom", "Gardner", "4445556666", "BC", "Software Architecture" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
