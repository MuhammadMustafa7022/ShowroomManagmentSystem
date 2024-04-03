using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    public partial class Initialize_Vehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mileage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WheelCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleCategorys_FKCategoryId",
                        column: x => x.FKCategoryId,
                        principalTable: "VehicleCategorys",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FKCategoryId",
                table: "Vehicles",
                column: "FKCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
