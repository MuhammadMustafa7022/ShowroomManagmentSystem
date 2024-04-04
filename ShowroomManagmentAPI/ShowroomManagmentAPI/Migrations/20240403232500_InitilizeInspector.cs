using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class InitilizeInspector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inspectors",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FkDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspectors", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_Inspectors_Departments_FkDepartmentId",
                        column: x => x.FkDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inspectors_FkDepartmentId",
                table: "Inspectors",
                column: "FkDepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspectors");
        }
    }
}
