using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientDonation.web.Migrations
{
    /// <inheritdoc />
    public partial class Sa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Logins",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Logins",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Logins");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Logins",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Logins",
                newName: "email");
        }
    }
}
