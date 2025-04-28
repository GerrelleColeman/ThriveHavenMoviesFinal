using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThriveHavenMovies.Migrations
{


    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert seeding data for Concession table
            migrationBuilder.InsertData(
                table: "Concessions",
                columns: new[] { "ItemID", "ItemName", "Cost", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "Popcorn", 4.56, "/Images/Concessions/Popcorn.jpg" },
                    { 2, "Fountain Drink", 4.12, "/Images/Concessions/drink.jpg" },
                    { 3, "Hotdog", 5.12, "/Images/Concessions/Hotdog.jpg" },
                    { 4, "Soda", 5.50, "/Images/Concessions/Soda.jpg" },
                    { 5, "M&M", 2.50, "/Images/Concessions/M&M.jpg" },
                    { 6, "Slushy", 5.0, "/Images/Concessions/Slushy.jpg" }
                });

            // Insert seeding data for Movie table
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Name", "Genre", "Year", "Rating", "TimeFrame", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "La La Land", "Musical/Romance", "2016", "PG-13", "2h 8m", "/Images/MovieList/La La Land.jpg" },
                    { 2, "Ocean's 8", "Action", "2018", "PG-13", "1hr 51m", "/Images/MovieList/Oceans8.png" },
                    { 3, "She's all that", "Romance/Drama", "1999", "PG-13", "1h 35m", "/Images/MovieList/she's all that.jpg" },
                    { 4, "Arrival", "Sci-Fi/Thriller", "2016", "PG-13", "1h 56m", "/Images/MovieList/Arrival.jpg" },
                    { 5, "Baby Driver", "Action/Thriller", "2017", "PG-13", "1h 55m", "/Images/MovieList/Baby driver.jpg" },
                    { 6, "Captain America: Civil War", "Action/Sci-Fi", "2016", "PG-13", "2h 28m", "/Images/MovieList/Civil war.jpg" },
                    { 7, "Crazy Rich Asians", "Romance/Drama", "2018", "PG-13", "2h 1m", "/Images/MovieList/Crazy Rich Asians.jpg" },
                    { 8, "Fast and Furious 6", "Action", "2013", "PG-13", "2h 10m", "/Images/MovieList/Fast and Furious 6.jpg" },
                    { 9, "Grown ups", "Drama/Comedy", "2010", "PG-13", "1h 42m", "/Images/MovieList/Grown Ups.jpg" },
                    { 10, "Hairspray", "Musical", "2007", "PG-13", "1h 57m", "/Images/MovieList/HairSpray.jpg" },
                    { 11, "Hamilton", "Musical/Drama", "2020", "PG-13", "2h 40m", "/Images/MovieList/Hamilton.jpg" },
                    { 12, "Hunger Games", "Action", "2012", "PG-13", "2h 56m", "/Images/MovieList/Hunger Games.jpg" },
                    { 13, "Mrs.Doubtfire", "Drama", "1993", "PG-13", "2h 6m", "/Images/MovieList/Mrs.Doubtfire.jpg" },
                    { 14, "Rush Hour", "Action/Thriller", "1998", "PG-13", "1h 35m", "/Images/MovieList/Rush Hour.jpg" },
                    { 15, "Star Wars: The Rise of SkyWalker", "Sci-Fi/Action", "2019", "PG-13", "2h 22m", "/Images/MovieList/Star wars.jpg" },
                    { 16, "The Great Gatsby", "Romance/Drama", "2013", "PG-13", "2h 22m", "/Images/MovieList/The Great Gatsby.jpg" },
                    { 17, "The Martian", "Sci-Fi", "2015", "PG-13", "2h 31m", "/Images/MovieList/The Martian.jpg" },
                    { 18, "Tower Heist", "Action", "2011", "PG-13", "1h 44m", "/Images/MovieList/Tower Heist.jpg" },
                    { 19, "West side Story", "Musical/Romance", "2021", "PG-13", "2h 36m", "/Images/MovieList/West Side Story.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove the inserted data in Down migration
            migrationBuilder.DeleteData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValues: new object[] { 1, 2, 3 });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 });
        }
    }

}
