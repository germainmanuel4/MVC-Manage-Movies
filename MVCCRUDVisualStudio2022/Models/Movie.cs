using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCRUDVisualStudio2022.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; } //the question mark after the string means its nullable

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } 
    }
}
