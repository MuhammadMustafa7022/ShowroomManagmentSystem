using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class Inialize_saleOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaleOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FkCustomerID = table.Column<int>(type: "int", nullable: false),
                    FkEmpolyeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_SaleOrders_Customers_FkCustomerID",
                        column: x => x.FkCustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleOrders_Employees_FkEmpolyeeID",
                        column: x => x.FkEmpolyeeID,
                        principalTable: "Employees",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrders_FkCustomerID",
                table: "SaleOrders",
                column: "FkCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrders_FkEmpolyeeID",
                table: "SaleOrders",
                column: "FkEmpolyeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleOrders");
        }
    }
}
