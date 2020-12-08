using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataBase.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_Cars_CarId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_Shops_ShopId",
                table: "Availabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities");

            migrationBuilder.DropIndex(
                name: "IX_Availabilities_CarId",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Availabilities");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Shops",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ShopId",
                table: "Availabilities",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CarId",
                table: "Availabilities",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Availabilities",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities",
                columns: new[] { "CarId", "ShopId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_Cars_CarId",
                table: "Availabilities",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_Shops_ShopId",
                table: "Availabilities",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_Cars_CarId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_Shops_ShopId",
                table: "Availabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Availabilities");

            migrationBuilder.AlterColumn<long>(
                name: "ShopId",
                table: "Availabilities",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CarId",
                table: "Availabilities",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "Availabilities",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_CarId",
                table: "Availabilities",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_Cars_CarId",
                table: "Availabilities",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_Shops_ShopId",
                table: "Availabilities",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
