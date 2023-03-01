using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace burger_Joint.Migrations
{
    /// <inheritdoc />
    public partial class my_final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPayment");

            migrationBuilder.AddColumn<int>(
                name: "Order_Id",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order_Id1",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Employee_ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Employee_ID1",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Administrator_ID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Administrator_ID1",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeeStore",
                columns: table => new
                {
                    KEEPSEmployee_ID = table.Column<int>(type: "int", nullable: false),
                    KEEPSItem_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeStore", x => new { x.KEEPSEmployee_ID, x.KEEPSItem_ID });
                    table.ForeignKey(
                        name: "FK_EmployeeStore_Employees_KEEPSEmployee_ID",
                        column: x => x.KEEPSEmployee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeStore_Stores_KEEPSItem_ID",
                        column: x => x.KEEPSItem_ID,
                        principalTable: "Stores",
                        principalColumn: "Item_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Order_Id1",
                table: "Payments",
                column: "Order_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Employee_ID1",
                table: "Orders",
                column: "Employee_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Administrator_ID1",
                table: "Employees",
                column: "Administrator_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeStore_KEEPSItem_ID",
                table: "EmployeeStore",
                column: "KEEPSItem_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Administrators_Administrator_ID1",
                table: "Employees",
                column: "Administrator_ID1",
                principalTable: "Administrators",
                principalColumn: "Administrator_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_Employee_ID1",
                table: "Orders",
                column: "Employee_ID1",
                principalTable: "Employees",
                principalColumn: "Employee_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_Order_Id1",
                table: "Payments",
                column: "Order_Id1",
                principalTable: "Orders",
                principalColumn: "Order_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Administrators_Administrator_ID1",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_Employee_ID1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_Order_Id1",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "EmployeeStore");

            migrationBuilder.DropIndex(
                name: "IX_Payments_Order_Id1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Employee_ID1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Administrator_ID1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Order_Id",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Order_Id1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Employee_ID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Employee_ID1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Administrator_ID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Administrator_ID1",
                table: "Employees");

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
                name: "IX_OrderPayment_PaymentsPayment_Id",
                table: "OrderPayment",
                column: "PaymentsPayment_Id");
        }
    }
}
