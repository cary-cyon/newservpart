using Microsoft.EntityFrameworkCore.Migrations;

namespace servPart.Migrations
{
    public partial class QrDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductQrcodes",
                columns: table => new
                {
                    Qrcode = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductQrcodes", x => x.Qrcode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductQrcodes");
        }
    }
}
