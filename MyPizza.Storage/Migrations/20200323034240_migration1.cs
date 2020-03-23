using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPizza.Storage.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Storeid = table.Column<long>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Sizeid = table.Column<long>(nullable: false),
                    Crustid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topping",
                columns: table => new
                {
                    Toppingid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topping", x => x.Toppingid);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Crust",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PizzaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crust", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crust_Pizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PizzaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Size_Pizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "Id", "Name", "PizzaId" },
                values: new object[,]
                {
                    { 1L, "Cheese Stuffed", null },
                    { 2L, "Thin Crust", null }
                });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "Id", "Crustid", "Name", "Price", "Sizeid", "Storeid" },
                values: new object[,]
                {
                    { 1L, 1L, "Cheese Pizza", 0.0, 1L, 1L },
                    { 2L, 2L, "Pepperoni Pizza", 0.0, 2L, 1L }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "Name", "PizzaId" },
                values: new object[,]
                {
                    { 1L, "Small", null },
                    { 2L, "Medium", null },
                    { 3L, "Large", null }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Pizza Hut" },
                    { 2L, "Domino's" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 1L, "Pizza Hut", null, null },
                    { 2L, "Domino's", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crust_PizzaId",
                table: "Crust",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Size_PizzaId",
                table: "Size",
                column: "PizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crust");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "Topping");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Pizza");
        }
    }
}
