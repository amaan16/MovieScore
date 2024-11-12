using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations.Users
{
    /// <inheritdoc />
    public partial class SeedPrivateUsers2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Password", "Username", "base64Creds", "hash" },
                values: new object[,]
                {
                    { 1, "password1", "user1", "dXNlcjE6cGFzc3dvcmQ=", "hash_of_password" },
                    { 2, "password2", "user2", "dXNlcjI6cGFzc3dvcmQ=", "hash_of_password" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
