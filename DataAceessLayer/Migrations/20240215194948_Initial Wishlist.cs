using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAceessLayer.Migrations
{
    public partial class InitialWishlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_ApplicationUser_ApplicationUserID",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Cart_CartID",
                table: "CartProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_ApplicationUserID",
                table: "Carts",
                newName: "IX_Carts_ApplicationUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Wishlists_ApplicationUser_ApplicationUserID",
                        column: x => x.ApplicationUserID,
                        principalTable: "ApplicationUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishedItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    WishlistID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishedItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WishedItem_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishedItem_Wishlists_WishlistID",
                        column: x => x.WishlistID,
                        principalTable: "Wishlists",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WishedItem_ProductID",
                table: "WishedItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_WishedItem_WishlistID",
                table: "WishedItem",
                column: "WishlistID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_ApplicationUserID",
                table: "Wishlists",
                column: "ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Carts_CartID",
                table: "CartProduct",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_ApplicationUser_ApplicationUserID",
                table: "Carts",
                column: "ApplicationUserID",
                principalTable: "ApplicationUser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Carts_CartID",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_ApplicationUser_ApplicationUserID",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "WishedItem");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ApplicationUserID",
                table: "Cart",
                newName: "IX_Cart_ApplicationUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_ApplicationUser_ApplicationUserID",
                table: "Cart",
                column: "ApplicationUserID",
                principalTable: "ApplicationUser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Cart_CartID",
                table: "CartProduct",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "ID");
        }
    }
}
