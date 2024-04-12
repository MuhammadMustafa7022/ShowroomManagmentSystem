using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class InitilizeServiceAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceAppointments",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKCustomerId = table.Column<int>(type: "int", nullable: false),
                    FKVehicleId = table.Column<int>(type: "int", nullable: false),
                    FKEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceAppointments", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_ServiceAppointments_Customers_FKCustomerId",
                        column: x => x.FKCustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceAppointments_Employees_FKEmployeeId",
                        column: x => x.FKEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceAppointments_Vehicles_FKVehicleId",
                        column: x => x.FKVehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehiicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionType = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKPurchaseOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_Transactions_PurchaseOrdrs_FKPurchaseOrderId",
                        column: x => x.FKPurchaseOrderId,
                        principalTable: "PurchaseOrdrs",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_FKRoleId",
                        column: x => x.FKRoleId,
                        principalTable: "Roles",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAppointments_FKCustomerId",
                table: "ServiceAppointments",
                column: "FKCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAppointments_FKEmployeeId",
                table: "ServiceAppointments",
                column: "FKEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAppointments_FKVehicleId",
                table: "ServiceAppointments",
                column: "FKVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_FKPurchaseOrderId",
                table: "Transactions",
                column: "FKPurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FKRoleId",
                table: "Users",
                column: "FKRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceAppointments");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
