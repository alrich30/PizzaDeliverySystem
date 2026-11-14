using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDeliverySystem.Infrastructure.Migrations;

public partial class PricePrecision : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<decimal>(
            name: "ExtraPrice",
            table: "Ingredients",
            type: "decimal(18,2)",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "decimal(65,30)");

        migrationBuilder.AlterColumn<decimal>(
            name: "BasePrice",
            table: "Pizzas",
            type: "decimal(18,2)",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "decimal(65,30)");

        migrationBuilder.AlterColumn<decimal>(
            name: "UnitPrice",
            table: "OrderItems",
            type: "decimal(18,2)",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "decimal(65,30)");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<decimal>(
            name: "ExtraPrice",
            table: "Ingredients",
            type: "decimal(65,30)",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "decimal(18,2)");

        migrationBuilder.AlterColumn<decimal>(
            name: "BasePrice",
            table: "Pizzas",
            type: "decimal(65,30)",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "decimal(18,2)");

        migrationBuilder.AlterColumn<decimal>(
            name: "UnitPrice",
            table: "OrderItems",
            type: "decimal(65,30)",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "decimal(18,2)");
    }
}
