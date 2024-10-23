using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserREv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "UserNAme",
                table: "Users",
                newName: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "UserNAme");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Password", "SurName", "UserNAme" },
                values: new object[] { 1, "admin@gmail.com", true, "Bilge", "0661", "Karaca", "blgkrc61" });
        }
    }
}
