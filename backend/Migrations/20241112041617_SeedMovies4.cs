using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Path",
                value: "/cdqLnri3NEGcmfnqwk2TSIYtddg1.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Path", "Rating", "Title" },
                values: new object[] { "After Santa Claus (codename: Red One) is kidnapped, the North Pole's Head of Security must team up with the world's most infamous bounty hunter in a globe-trotting, action-packed mission to save Christmas.", "/rOmUuQEZfPXglwFs5ELLLUDKodL.jpg", 6.5999999999999996, "Red One" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Path",
                value: "/cdqLnri3NEGcmfnqwk2TSIYtddg.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Path", "Rating", "Title" },
                values: new object[] { "A fading celebrity decides to use a black market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.", "/7h6TqPB3ESmjuVbxCxAeB1c9OB1.jpg", 7.2999999999999998, "The Substance" });
        }
    }
}
