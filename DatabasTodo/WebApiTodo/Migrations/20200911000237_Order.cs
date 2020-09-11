using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiTodo.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresss",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresss", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CusName = table.Column<string>(nullable: false),
                    CusInfo = table.Column<string>(nullable: false),
                    CusEmail = table.Column<string>(nullable: false),
                    CusPhone = table.Column<string>(nullable: false),
                    CusCompany = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CusId);
                    table.ForeignKey(
                        name: "FK_Customers_Addresss_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresss",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDescription = table.Column<string>(nullable: false),
                    OrderResponse = table.Column<string>(nullable: false),
                    OrderAccept = table.Column<bool>(nullable: false),
                    OrderEstTime = table.Column<DateTime>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderStart = table.Column<DateTime>(nullable: false),
                    OrderEnd = table.Column<DateTime>(nullable: false),
                    OrderComplete = table.Column<bool>(nullable: false),
                    OrderPrice = table.Column<double>(nullable: false),
                    CustomerCusId = table.Column<int>(nullable: true),
                    AddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Addresss_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresss",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerCusId",
                        column: x => x.CustomerCusId,
                        principalTable: "Customers",
                        principalColumn: "CusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderHistorys",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDescription = table.Column<string>(nullable: false),
                    OrderResponse = table.Column<string>(nullable: false),
                    OrderAccept = table.Column<bool>(nullable: false),
                    OrderStart = table.Column<DateTime>(nullable: false),
                    OrderEnd = table.Column<DateTime>(nullable: false),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    OrderComplete = table.Column<bool>(nullable: false),
                    OrderPrice = table.Column<double>(nullable: false),
                    OrderId1 = table.Column<int>(nullable: true),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistorys", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrderHistorys_Addresss_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresss",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderHistorys_Orders_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistorys_AddressId",
                table: "OrderHistorys",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistorys_OrderId1",
                table: "OrderHistorys",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerCusId",
                table: "Orders",
                column: "CustomerCusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderHistorys");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Addresss");
        }
    }
}
