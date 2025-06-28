using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CousrePrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Average = table.Column<double>(type: "float", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "CousrePrice" },
                values: new object[,]
                {
                    { 1, "C++", 150 },
                    { 2, "front end ", 60 },
                    { 3, "Math", 80 },
                    { 4, "Web Programming", 300 },
                    { 5, "Embeded System", 190 },
                    { 6, "Java", 160 },
                    { 7, "Network Programming", 90 },
                    { 8, "Lenux", 90 },
                    { 9, "Python", 130 },
                    { 10, "Project Managment", 110 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Average", "CourseId", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 92.0, 1, "maha", "123" },
                    { 2, 99.0, 1, "mohammed", "212" },
                    { 3, 97.0, 6, "shahd", "262" },
                    { 4, 89.0, 4, "suha", "762" },
                    { 5, 97.0, 7, "Rawan", "292" },
                    { 6, 74.0, 2, "Noor", "202" },
                    { 7, 97.0, 3, "Raghad", "202" },
                    { 8, 67.0, 3, "bushra", "162" },
                    { 9, 88.0, 3, "misk", "200" },
                    { 10, 57.0, 2, "yazan", "772" },
                    { 11, 91.0, 2, "yara", "777" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
