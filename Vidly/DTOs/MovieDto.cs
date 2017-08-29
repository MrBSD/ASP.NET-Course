using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }
       
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdd { get; set; }

        [Required]
        [Range(1, 20)]
        public int InStock { get; set; }
    }
}