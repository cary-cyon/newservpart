using Microsoft.EntityFrameworkCore.Migrations;

namespace servPart.Migrations
{
    public partial class HistioryManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductQrcodes_Histories_HistoryID",
                table: "ProductQrcodes");

            migrationBuilder.DropIndex(
                name: "IX_ProductQrcodes_HistoryID",
                table: "ProductQrcodes");

            migrationBuilder.DropColumn(
                name: "HistoryID",
                table: "ProductQrcodes");

            migrationBuilder.AddColumn<string>(
                name: "addres",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HistoryProductQrcodewithType",
                columns: table => new
                {
                    HistoriesID = table.Column<int>(type: "int", nullable: false),
                    ProductsQrcode = table.Column<string>(type: "nvarchar(13)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryProductQrcodewithType", x => new { x.HistoriesID, x.ProductsQrcode });
                    table.ForeignKey(
                        name: "FK_HistoryProductQrcodewithType_Histories_HistoriesID",
                        column: x => x.HistoriesID,
                        principalTable: "Histories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryProductQrcodewithType_ProductQrcodes_ProductsQrcode",
                        column: x => x.ProductsQrcode,
                        principalTable: "ProductQrcodes",
                        principalColumn: "Qrcode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoryProductQrcodewithType_ProductsQrcode",
                table: "HistoryProductQrcodewithType",
                column: "ProductsQrcode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryProductQrcodewithType");

            migrationBuilder.DropColumn(
                name: "addres",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "HistoryID",
                table: "ProductQrcodes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductQrcodes_HistoryID",
                table: "ProductQrcodes",
                column: "HistoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductQrcodes_Histories_HistoryID",
                table: "ProductQrcodes",
                column: "HistoryID",
                principalTable: "Histories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
