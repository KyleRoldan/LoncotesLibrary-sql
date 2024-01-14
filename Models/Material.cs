using System;
using System.ComponentModel.DataAnnotations;
using LoncotesLibrary.Models.DTOs;

namespace LoncotesLibrary.Models
{
    public class Material
    {
        public int Id { get; set; }
        [Required]
        public string? MaterialName { get; set; }

        [Required]
        public int MaterialTypeId { get; set; }

        public MaterialType? MaterialType { get; set;}

         [Required]
        public int GenreId { get; set; }

        public Genre? Genre { get; set; }

        public List<Checkout>? Checkouts { get; set; }

        public DateTime? OutOfCirculationSince { get; set; }

        
    }
}
