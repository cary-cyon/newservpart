using Microsoft.EntityFrameworkCore.Migrations;

namespace servPart.Migrations
{
    public partial class AddClassStok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "end_sum",
                table: "UserClasses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "StockByClassID",
                table: "ProductQrcodes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "count",
                table: "ProductQrcodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StocksByClass",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _classID = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksByClass", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StocksByClass_UserClasses__classID",
                        column: x => x._classID,
                        principalTable: "UserClasses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductQrcodes_StockByClassID",
                table: "ProductQrcodes",
                column: "StockByClassID");

            migrationBuilder.CreateIndex(
                name: "IX_StocksByClass__classID",
                table: "StocksByClass",
                column: "_classID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductQrcodes_StocksByClass_StockByClassID",
                table: "ProductQrcodes",
                column: "StockByClassID",
                principalTable: "StocksByClass",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductQrcodes_StocksByClass_StockByClassID",
                table: "ProductQrcodes");

            migrationBuilder.DropTable(
                name: "StocksByClass");

            migrationBuilder.DropIndex(
                name: "IX_ProductQrcodes_StockByClassID",
                table: "ProductQrcodes");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "end_sum",
                table: "UserClasses");

            migrationBuilder.DropColumn(
                name: "StockByClassID",
                table: "ProductQrcodes");

            migrationBuilder.DropColumn(
                name: "count",
                table: "ProductQrcodes");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducterID = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    typeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Producters_ProducterID",
                        column: x => x.ProducterID,
                        principalTable: "Producters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Types_typeID",
                        column: x => x.typeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProducterID",
                table: "Product",
                column: "ProducterID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_typeID",
                table: "Product",
                column: "typeID");
        }
    }
}
