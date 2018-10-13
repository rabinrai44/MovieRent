using MovieRent.Models;
using System.Collections.Generic;

namespace MovieRent.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}