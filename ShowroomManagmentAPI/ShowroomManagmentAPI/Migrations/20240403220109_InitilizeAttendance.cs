using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class InitilizeAttendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeOut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_Attendances_Employees_FKEmployeeId",
                        column: x => x.FKEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_FKEmployeeId",
                table: "Attendances",
                column: "FKEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");
        }
    }
}
