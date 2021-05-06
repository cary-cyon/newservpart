using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace servPart.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Producters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stocks1_1",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks1_1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserClasses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_sum = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClasses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    typeID = table.Column<int>(type: "int", nullable: true),
                    ProducterID = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "StocksOfType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksOfType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StocksOfType_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeProductID = table.Column<int>(type: "int", nullable: true),
                    TypeProductID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserTypes_Types_TypeProductID",
                        column: x => x.TypeProductID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTypes_Types_TypeProductID1",
                        column: x => x.TypeProductID1,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    br_day = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    sum_buy = table.Column<double>(type: "float", nullable: false),
                    num_buy = table.Column<int>(type: "int", nullable: false),
                    typeID = table.Column<int>(type: "int", nullable: true),
                    userClassID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_UserClasses_userClassID",
                        column: x => x.userClassID,
                        principalTable: "UserClasses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_typeID",
                        column: x => x.typeID,
                        principalTable: "UserTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    TimeDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Histories_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductQrcodes",
                columns: table => new
                {
                    Qrcode = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    ProducterID = table.Column<int>(type: "int", nullable: true),
                    ImageID = table.Column<int>(type: "int", nullable: true),
                    HistoryID = table.Column<int>(type: "int", nullable: true),
                    Stock1_1ID = table.Column<int>(type: "int", nullable: true),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductQrcodes", x => x.Qrcode);
                    table.ForeignKey(
                        name: "FK_ProductQrcodes_Histories_HistoryID",
                        column: x => x.HistoryID,
                        principalTable: "Histories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductQrcodes_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductQrcodes_Producters_ProducterID",
                        column: x => x.ProducterID,
                        principalTable: "Producters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductQrcodes_Stocks1_1_Stock1_1ID",
                        column: x => x.Stock1_1ID,
                        principalTable: "Stocks1_1",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductQrcodewithTypeTypeProduct",
                columns: table => new
                {
                    ProductsQrcode = table.Column<string>(type: "nvarchar(13)", nullable: false),
                    TypesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductQrcodewithTypeTypeProduct", x => new { x.ProductsQrcode, x.TypesID });
                    table.ForeignKey(
                        name: "FK_ProductQrcodewithTypeTypeProduct_ProductQrcodes_ProductsQrcode",
                        column: x => x.ProductsQrcode,
                        principalTable: "ProductQrcodes",
                        principalColumn: "Qrcode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductQrcodewithTypeTypeProduct_Types_TypesID",
                        column: x => x.TypesID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productQrcode = table.Column<string>(type: "nvarchar(13)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stocks_ProductQrcodes_productQrcode",
                        column: x => x.productQrcode,
                        principalTable: "ProductQrcodes",
                        principalColumn: "Qrcode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UserID",
                table: "Histories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProducterID",
                table: "Product",
                column: "ProducterID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_typeID",
                table: "Product",
                column: "typeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQrcodes_HistoryID",
                table: "ProductQrcodes",
                column: "HistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQrcodes_ImageID",
                table: "ProductQrcodes",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQrcodes_ProducterID",
                table: "ProductQrcodes",
                column: "ProducterID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQrcodes_Stock1_1ID",
                table: "ProductQrcodes",
                column: "Stock1_1ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQrcodewithTypeTypeProduct_TypesID",
                table: "ProductQrcodewithTypeTypeProduct",
                column: "TypesID");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_productQrcode",
                table: "Stocks",
                column: "productQrcode");

            migrationBuilder.CreateIndex(
                name: "IX_StocksOfType_TypeID",
                table: "StocksOfType",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_typeID",
                table: "Users",
                column: "typeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_userClassID",
                table: "Users",
                column: "userClassID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypes_TypeProductID",
                table: "UserTypes",
                column: "TypeProductID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypes_TypeProductID1",
                table: "UserTypes",
                column: "TypeProductID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductQrcodewithTypeTypeProduct");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "StocksOfType");

            migrationBuilder.DropTable(
                name: "ProductQrcodes");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Producters");

            migrationBuilder.DropTable(
                name: "Stocks1_1");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserClasses");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
