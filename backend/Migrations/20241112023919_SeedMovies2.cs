using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 845781,
                columns: new[] { "Actors", "Director", "Rating", "Tag", "Writers" },
                values: new object[] { "Dwayne Johnson, Chris Evans", "Jake Kasdan", 6.9000000000000004, "action", "Chris Morgan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Description", "Director", "Path", "Rating", "Release", "Tag", "Title", "Type", "Writers" },
                values: new object[,]
                {
                    { 335983, "Tom Hardy, Michelle Williams", "Investigative journalist Eddie Brock attempts a comeback following a scandal, but accidentally becomes the host of Venom, a violent, super powerful alien symbiote. Soon, he must rely on his newfound powers to protect the world from a shadowy organization looking for a symbiote of their own.", "Ruben Fleischer", "/2uNW4WbgBXL25BAbXGLnLqX71Sw.jpg", 6.7999999999999998, new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Venom", "movie", "Jeff Pinkner, Scott Rosenberg" },
                    { 519182, "Steve Carell, Taraji P. Henson", "Gru and Lucy and their girls—Margo, Edith and Agnes—welcome a new member to the Gru family, Gru Jr., who is intent on tormenting his dad. Gru also faces a new nemesis in Maxime Le Mal and his femme fatale girlfriend Valentina, forcing the family to go on the run.", "Kyle Balda", "/wWba3TaojhK7NdycRhoQpsG0FaH.jpg", 7.0999999999999996, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Despicable Me 4", "movie", "Matthew Fogel" },
                    { 533535, "Ryan Reynolds, Hugh Jackman", "A listless Wade Wilson toils away in civilian life with his days as the morally flexible mercenary, Deadpool, behind him. But when his homeworld faces an existential threat, Wade must reluctantly suit-up again with an even more reluctant Wolverine.", "David Leitch", "/8cdWjvZQUExUUTzyp4t6EDMubfO.jpg", 7.7000000000000002, new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Deadpool & Wolverine", "movie", "Rhett Reese, Paul Wernick" },
                    { 580489, "Tom Hardy, Woody Harrelson", "After finding a host body in investigative reporter Eddie Brock, the alien symbiote must face a new enemy, Carnage, the alter ego of serial killer Cletus Kasady.", "Andy Serkis", "/1MJNcPZy46hIy2CmSqOeru0yr5C.jpg", 6.7999999999999998, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Venom: Let There Be Carnage", "movie", "Kelly Marcel" },
                    { 912649, "Tom Hardy, Michelle Williams", "Eddie and Venom are on the run. Hunted by both of their worlds and with the net closing in, the duo are forced into a devastating decision that will bring the curtains down on Venom and Eddie's last dance.", "Tim Scott", "/aosm8NMQ3UyoBVpSxyimorCQykC.jpg", 6.5, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Venom: The Last Dance", "movie", "David White" },
                    { 976734, "Jessica Chastain, John Boyega", "Top level CIA agent Avery Graves is blackmailed by terrorists into betraying her own country to save her kidnapped husband. Cut off from her team, she turns to her underworld contacts to survive and help locate the coveted intelligence that the kidnappers want.", "Mark Williams", "/hhiR6uUbTYYvKoACkdAIQPS5c6f.jpg", 6.2999999999999998, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Canary Black", "movie", "Mark Williams" },
                    { 1051896, "Ethan Hawke, Jack Dylan Grazer", "In the near future, on a decimated Earth, Paul and his twin sons face terror at night when ferocious creatures awaken. When Paul is nearly killed, the boys come up with a plan for survival, using everything their father taught them to keep him alive.", "Mark Johnson", "/spWV1eRzlDxvai8LbxwAWR0Vst4.jpg", 6.0, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Arcadian", "movie", "Chris Davis" },
                    { 1084736, "Jim Caviezel, Guy Pearce", "Edmond Dantes becomes the target of a sinister plot and is arrested on his wedding day for a crime he did not commit. After 14 years in the island prison of Château d’If, he manages a daring escape. Now rich beyond his dreams, he assumes the identity of the Count of Monte-Cristo and exacts his revenge on the three men who betrayed him.", "Kevin Reynolds", "/zw4kV7npGtaqvUxvJE9IdqdFsNc.jpg", 8.3000000000000007, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "The Count of Monte-Cristo", "movie", "Alexandre Dumas" },
                    { 1094974, "Sophie Turner, Matthew Goode", "A burned-out professional sniper finds himself trapped in an all-glass penthouse by a lethal competitor and must find a way to survive and escape with little to no cover between him and the killer.", "Tom Paton", "/xNLiMNyFzKTL9PVIEulG55Hei8j.jpg", 6.5999999999999996, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Take Cover", "movie", "Tom Paton" },
                    { 1118031, "Raúl Jiménez, Ana María Rivas", "When a kind of rabies that transforms people into aggressive creatures spreads across the planet, Manel isolates himself at home with his cat, relying on his wits to survive; but soon they must go out in search of food, by land and by sea, dodging many dangers.", "Carlos Muñoz", "/wIGJnIFQlESkC2rLpfA8EDHqk4g.jpg", 6.9000000000000004, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Apocalypse Z: The Beginning of the End", "movie", "Luis Hernández" },
                    { 1196470, "Nicolas Duvauchelle, Mélanie Thierry", "A couple celebrates their son’s birthday in the middle of the ocean on their boat. A violent storm hits and it brings up hungry creatures from the depths and they fight for their survival.", "Éric Rochant", "/7fR3KxswtY8OHHZuOUB9td58CRX.jpg", 5.0, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "action", "Survive", "movie", "Éric Rochant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 335983);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 519182);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 533535);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 580489);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 912649);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 976734);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1051896);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1084736);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1094974);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1118031);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1196470);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 845781,
                columns: new[] { "Actors", "Director", "Rating", "Tag", "Writers" },
                values: new object[] { "Tom Green, Olivia Brown", "Robert Black", 6.5999999999999996, "trending", "Chris White" });

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
                    { 889737, "Joaquin Phoenix, Lady Gaga", "While struggling with his dual identity, Arthur Fleck not only stumbles upon true love, but also finds the music that's always been inside him.", "Todd Phillips", "/if8QiqCI7WAGImKcJCfzp6VTyKA.jpg", 5.6509999999999998, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "Joker: Folie à Deux", "movie", "Todd Phillips, Scott Silver" },
                    { 933260, "John Smith, Lucy Lee", "A fading celebrity decides to use a black market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.", "Michael Brown", "/lqoMzCcZYEFK729d6qzt349fB4o.jpg", 7.2949999999999999, new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "The Substance", "movie", "Linda Green" },
                    { 947891, "Florence Pugh, Saoirse Ronan", "An 18th birthday mushroom trip brings free-spirited Elliott face-to-face with her wisecracking 39-year-old self...", "Greta Gerwig", "/yUs4Sw9AyTg2sA1qWBkNpD2mGSj.jpg", 6.5999999999999996, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "My Old Ass", "movie", "Greta Gerwig" },
                    { 1184918, "Voice of Roz, various animal voices", "After a shipwreck, an intelligent robot called Roz is stranded on an uninhabited island...", "Chris Sanders", "/wTnV3PCVW5O92JMrFvvrRcV39RU.jpg", 8.5120000000000005, new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "trending", "The Wild Robot", "movie", "Peter Brown" }
                });
        }
    }
}
