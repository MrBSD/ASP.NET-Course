using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        public ApplicationDbContext _context { get; set; }

        public NewRentalsController()
        {
            _context= new ApplicationDbContext();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateNewRantal(NewRentalDto newRentalDto)
        {
           
            var customer = _context.Customers
                .Single(c => c.Id == newRentalDto.CustomerId);

            var movies = _context.Movies.Where(
                m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.Available == 0)
                    return BadRequest("Movie is not available");
                movie.Available--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
                
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
