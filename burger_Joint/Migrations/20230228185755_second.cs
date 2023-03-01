using Microsoft.EntityFrameworkCore.Migrations;

namespace burger_Joint.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cus_Id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerCus_Id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrderPayment",
                columns: table => new
                {
                    OrdersOrder_Id = table.Column<int>(type: "int", nullable: false),
                    PaymentsPayment_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPayment", x => new { x.OrdersOrder_Id, x.PaymentsPayment_Id });
                    table.ForeignKey(
                        name: "FK_OrderPayment_Orders_OrdersOrder_Id",
                        column: x => x.OrdersOrder_Id,
                        principalTable: "Orders",
                        principalColumn: "Order_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPayment_Payments_PaymentsPayment_Id",
                        column: x => x.PaymentsPayment_Id,
                        principalTable: "Payments",
                        principalColumn: "Payment_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerCus_Id",
                table: "Orders",
                column: "CustomerCus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayment_PaymentsPayment_Id",
                table: "OrderPayment",
                column: "PaymentsPayment_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerCus_Id",
                table: "Orders",
                column: "CustomerCus_Id",
                principalTable: "Customers",
                principalColumn: "Cus_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerCus_Id",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderPayment");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerCus_Id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Cus_Id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerCus_Id",
                table: "Orders");
        }
    }
}
