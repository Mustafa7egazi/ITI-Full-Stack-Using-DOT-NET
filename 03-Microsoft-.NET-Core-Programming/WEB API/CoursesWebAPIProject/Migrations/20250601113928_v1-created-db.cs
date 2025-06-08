using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIProject.Migrations
{
    /// <inheritdoc />
    public partial class v1createddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crs_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Crs_desc = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Crs_duration = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
