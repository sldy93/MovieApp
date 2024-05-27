namespace MovieApp.Models
{
    public class SeedData
    {
        public static List<Movie> Movies = new List<Movie>()
        {
                new Movie
                {
                    MovieId = 4,
                    Name = "Casablanca",
                    Year = 1943,
                    Rating = 5,
                    Genre = "Drama"
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Wonder Woman",
                    Year = 2017,
                    Rating = 3,
                    Genre = "Action"
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Moonstruck",
                    Year = 1988,
                    Rating = 4,
                    Genre = "RomCom"
                }
        };

    }
}
