namespace MovieScore.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime Release { get; set; } // Date type for release date
        public string Description { get; set; }
        public string Writers { get; set; }
        public string Actors { get; set; }
        public double Rating { get; set; } // Assuming rating as a decimal value
        public string Tag { get; set; }
        public string Type { get; set; } // e.g., Genre
        public string Path { get; set; } // Path to movie image or file
    }
}