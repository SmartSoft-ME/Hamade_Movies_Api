using System.ComponentModel.DataAnnotations;

namespace Movies
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Required]
        public int Year { get; set; }

        public Movie(int id, string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
            Id = id;
        }
    }

   
}