using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientDonation.web.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Needies",
                newName: "Needy_Id");

            migrationBuilder.AddColumn<int>(
                name: "Needy_Id",
                table: "Donars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Needy_Id1",
                table: "Donars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Donars_Needy_Id1",
                table: "Donars",
                column: "Needy_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Donars_Needies_Needy_Id1",
                table: "Donars",
                column: "Needy_Id1",
                principalTable: "Needies",
                principalColumn: "Needy_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donars_Needies_Needy_Id1",
                table: "Donars");

            migrationBuilder.DropIndex(
                name: "IX_Donars_Needy_Id1",
                table: "Donars");

            migrationBuilder.DropColumn(
                name: "Needy_Id",
                table: "Donars");

            migrationBuilder.DropColumn(
                name: "Needy_Id1",
                table: "Donars");

            migrationBuilder.RenameColumn(
                name: "Needy_Id",
                table: "Needies",
                newName: "Id");
        }
    }
}
