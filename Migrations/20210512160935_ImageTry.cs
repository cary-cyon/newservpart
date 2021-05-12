using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace servPart.Migrations
{
    public partial class ImageTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "ProductQrcodes",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "ProductQrcodes");
        }
    }
}
