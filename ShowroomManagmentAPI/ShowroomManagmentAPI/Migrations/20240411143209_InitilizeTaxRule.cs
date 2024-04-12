using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class InitilizeTaxRule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaxRules",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicableProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKTaxRateId = table.Column<int>(type: "int", nullable: false),
                    FKTaxExemption = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRules", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_TaxRules_TaxExemptions_FKTaxExemption",
                        column: x => x.FKTaxExemption,
                        principalTable: "TaxExemptions",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxRules_TaxRates_FKTaxRateId",
                        column: x => x.FKTaxRateId,
                        principalTable: "TaxRates",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaxRules_FKTaxExemption",
                table: "TaxRules",
                column: "FKTaxExemption");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRules_FKTaxRateId",
                table: "TaxRules",
                column: "FKTaxRateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaxRules");
        }
    }
}
