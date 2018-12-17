using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    ChangeDate = table.Column<string>(nullable: true),
                    Deeplink = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChangeCode = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FeatureID = table.Column<string>(nullable: true),
                    LogicalValue = table.Column<int>(nullable: false),
                    NumericValue = table.Column<int>(nullable: false),
                    RangeLowerValue = table.Column<int>(nullable: false),
                    RangeUpperValue = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    UnitDescription = table.Column<string>(nullable: true),
                    UnitID = table.Column<string>(nullable: true),
                    UnitShortNotation = table.Column<string>(nullable: false),
                    ValueDescription = table.Column<int>(nullable: false),
                    ValueID = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Features_ProductId",
                table: "Features",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
