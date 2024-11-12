using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Description", "Director", "Path", "Rating", "Release", "Tag", "Title", "Type", "Writers" },
                values: new object[,]
                {
                    { 94605, "Alex Johnson, Emma Williams", "Amid the stark discord of twin cities Piltover and Zaun, two sisters fight on rival sides of a war between magic technologies and clashing convictions.", "John Doe", "/abf8tHznhSvl9BAElD2cQeRr7do.jpg", 8.8000000000000007, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "Arcane", "tv", "Jane Smith" },
                    { 154084, "Richard Madden, Priyanka Chopra", "When stuntman Bunny recruits struggling actress Honey for a side gig, they are hurled into a high-stakes world...", "Anthony Russo", "/lzZ9J2FOsaq1DCuD7k2f4ogbXdD.jpg", 7.5, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "Citadel Honey Bunny", "tv", "Josh Appelbaum, Bryan Oh" },
                    { 194764, "David Harris, Rachel Adams", "With the city in peril following the seawall's collapse, Oswald \"Oz\" Cobb’s quest seeks to fill the power vacuum left by the death of Carmine Falcone and finally give his mother Francis the life he's always promised. But first, Oz must confront his enemies and his own demoralizing reputation as \"the Penguin.\"", "Alice Cooper", "/vOWcqC4oDQws1doDWLO7d3dh5qc.jpg", 8.5, new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "The Penguin", "tv", "Martin King" },
                    { 222766, "Edward Fox, Michael Lonsdale", "An unrivalled and highly elusive lone assassin, the Jackal, makes his living carrying out hits...", "Jean-Pierre Melville", "/tYLecM3WSEjlkKhkGiH5G68Dprm.jpg", 7.9000000000000004, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "The Day of the Jackal", "tv", "Frederick Forsyth" },
                    { 592831, "Adam Driver, Nathalie Emmanuel", "Genius artist Cesar Catilina seeks to leap the City of New Rome into a utopian, idealistic future...", "Francis Ford Coppola", "/8Sok3HNA3r1GHnK2lCytHyBz1A.jpg", 5.5999999999999996, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "Megalopolis", "movie", "Francis Ford Coppola" },
                    { 845781, "Tom Green, Olivia Brown", "After Santa Claus (codename: Red One) is kidnapped, the North Pole's Head of Security must team up with the world's most infamous bounty hunter in a globe-trotting, action-packed mission to save Christmas.", "Robert Black", "/cdqLnri3NEGcmfnqwk2TSIYtddg.jpg", 6.5999999999999996, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "Red One", "movie", "Chris White" },
                    { 889737, "Joaquin Phoenix, Lady Gaga", "While struggling with his dual identity, Arthur Fleck not only stumbles upon true love, but also finds the music that's always been inside him.", "Todd Phillips", "/if8QiqCI7WAGImKcJCfzp6VTyKA.jpg", 5.6509999999999998, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "Joker: Folie à Deux", "movie", "Todd Phillips, Scott Silver" },
                    { 933260, "John Smith, Lucy Lee", "A fading celebrity decides to use a black market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.", "Michael Brown", "/lqoMzCcZYEFK729d6qzt349fB4o.jpg", 7.2949999999999999, new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "The Substance", "movie", "Linda Green" },
                    { 947891, "Florence Pugh, Saoirse Ronan", "An 18th birthday mushroom trip brings free-spirited Elliott face-to-face with her wisecracking 39-year-old self...", "Greta Gerwig", "/yUs4Sw9AyTg2sA1qWBkNpD2mGSj.jpg", 6.5999999999999996, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "My Old Ass", "movie", "Greta Gerwig" },
                    { 1184918, "Voice of Roz, various animal voices", "After a shipwreck, an intelligent robot called Roz is stranded on an uninhabited island...", "Chris Sanders", "/wTnV3PCVW5O92JMrFvvrRcV39RU.jpg", 8.5120000000000005, new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "The Wild Robot", "movie", "Peter Brown" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94605);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 154084);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 194764);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 222766);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 592831);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 845781);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 889737);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 933260);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 947891);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1184918);
        }
    }
}
