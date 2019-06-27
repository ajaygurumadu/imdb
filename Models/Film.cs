using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IMDB.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        public string Genre { get; set; }

        [Required]
        [MinLength(1)]
        public string Hero { get; set; }

        [Required]
        [MinLength(1)]
        public string Producer { get; set; }

        [Range(1900, 2100)]
        public int Year { get; set; }
    }

    public class Actors
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        public string Sex { get; set; }

        [Required]
        [MinLength(1)]
        public string DOB { get; set; }

        [Range(1900, 2100)]
        public int BIO { get; set; }
    }
    public class Producers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        public string Sex { get; set; }

        [Required]
        [MinLength(1)]
        public string DOB { get; set; }

        [Range(1900, 2100)]
        public int BIO { get; set; }
    }
}
