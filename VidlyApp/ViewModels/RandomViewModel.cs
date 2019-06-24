using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyApp.Models;
namespace VidlyApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}