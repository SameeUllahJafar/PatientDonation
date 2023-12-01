using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientDonation.web.Migrations
{
    /// <inheritdoc />
    public partial class updatingstuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donars_Needies_Needy_Id",
                table: "Donars");

            migrationBuilder.DropIndex(
                name: "IX_Donars_Needy_Id",
                table: "Donars");

            migrationBuilder.AddColumn<int>(
                name: "Needy_Id",
                table: "Donars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donars_Needy_Id",
                table: "Donars",
                column: "Needy_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Donars_Needies_Needy_Id",
                table: "Donars",
                column: "Needy_Id1",
                principalTable: "Needies",
                principalColumn: "Needy_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donars_Needies_Needy_Id",
                table: "Donars");

            migrationBuilder.DropIndex(
                name: "IX_Donars_Needy_Id",
                table: "Donars");

            migrationBuilder.DropColumn(
                name: "Needy_Id",
                table: "Donars");

            migrationBuilder.CreateIndex(
                name: "IX_Donars_Needy_Id",
                table: "Donars",
                column: "Needy_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Donars_Needies_Needy_Id",
                table: "Donars",
                column: "Needy_Id",
                principalTable: "Needies",
                principalColumn: "Needy_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
