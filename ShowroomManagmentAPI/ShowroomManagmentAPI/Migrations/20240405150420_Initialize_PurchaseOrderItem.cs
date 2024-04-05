using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class Initialize_PurchaseOrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrdrs_PurchaseOrdrPurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrdrPurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropColumn(
                name: "PurchaseOrdrPurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_FKPurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "FKPurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrdrs_FKPurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "FKPurchaseOrderId",
                principalTable: "PurchaseOrdrs",
                principalColumn: "PurchaseOrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrdrs_FKPurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderItems_FKPurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrdrPurchaseOrderId",
                table: "PurchaseOrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrdrPurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrdrPurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrdrs_PurchaseOrdrPurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrdrPurchaseOrderId",
                principalTable: "PurchaseOrdrs",
                principalColumn: "PurchaseOrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
