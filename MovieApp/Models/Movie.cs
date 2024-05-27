using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        [Range(1888, 3000, ErrorMessage = "Year must be a positive number between 1888 and 3000.")]
        public int Year { get; set; }
        [Range(1, 5, ErrorMessage = "Rating must be an integer between 1 and 5.")]
        public int Rating { get; set; }
        public string Genre { get; set; }
    }
}
