using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public int? GenreId { get; set; }
      
        [Required]
        public DateTime? ReleaseDate { get; set; }


        [Required]
        [Range(1, 20)]
        public int? InStock { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public string Title
        {
            get
            {
                if (Id!=0)
                {
                    return "Edit movie";
                }
                return "New movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            InStock = movie.InStock;
            GenreId = movie.GenreId;
        }

    }
}