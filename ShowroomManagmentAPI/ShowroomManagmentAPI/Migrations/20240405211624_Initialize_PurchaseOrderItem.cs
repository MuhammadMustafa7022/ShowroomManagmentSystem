using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class Initialize_PurchaseOrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "PurchaseOrderItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    FKPurchaseOrderId = table.Column<int>(type: "int", nullable: false),
                    FkProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderItems", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderItems_Products_FkProductId",
                        column: x => x.FkProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderItems_PurchaseOrdrs_FKPurchaseOrderId",
                        column: x => x.FKPurchaseOrderId,
                        principalTable: "PurchaseOrdrs",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

           

          

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_FkProductId",
                table: "PurchaseOrderItems",
                column: "FkProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_FKPurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "FKPurchaseOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "PurchaseOrderItems");
        }
    }
}
