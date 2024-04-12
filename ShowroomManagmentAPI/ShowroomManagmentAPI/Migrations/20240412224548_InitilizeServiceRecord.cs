using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class InitilizeServiceRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceRecords",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKServiceTypeId = table.Column<int>(type: "int", nullable: false),
                    FKServiceAppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecords", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_ServiceRecords_ServiceAppointments_FKServiceAppointmentId",
                        column: x => x.FKServiceAppointmentId,
                        principalTable: "ServiceAppointments",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRecords_ServiceTypes_FKServiceTypeId",
                        column: x => x.FKServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_FKServiceAppointmentId",
                table: "ServiceRecords",
                column: "FKServiceAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_FKServiceTypeId",
                table: "ServiceRecords",
                column: "FKServiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceRecords");
        }
    }
}
