using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientDonation.web.Migrations
{
    /// <inheritdoc />
    public partial class w : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donars_Needies_Needy_Id1",
                table: "Donars");

            migrationBuilder.AlterColumn<int>(
                name: "Needy_Id1",
                table: "Donars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Donars_Needies_Needy_Id1",
                table: "Donars",
                column: "Needy_Id1",
                principalTable: "Needies",
                principalColumn: "Needy_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donars_Needies_Needy_Id1",
                table: "Donars");

            migrationBuilder.AlterColumn<int>(
                name: "Needy_Id1",
                table: "Donars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donars_Needies_Needy_Id1",
                table: "Donars",
                column: "Needy_Id1",
                principalTable: "Needies",
                principalColumn: "Needy_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
