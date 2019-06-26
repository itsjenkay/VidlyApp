using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyApp.Dtos;
using VidlyApp.Models;
using AutoMapper;

namespace VidlyApp.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private VidlyContext _context;

        public MoviesController()
        {
            _context = new VidlyContext();
        }
        // Api/Movies/
        public IEnumerable<MoviesDto> GetMovies()
        {
            return _context.movies.ToList().Select(Mapper.Map<Movie, MoviesDto>);
        }

        // Api/Movies/1
        public IHttpActionResult GetMovie(int id)
        {
           var movies = _context.movies.SingleOrDefault(c => c.Id == id);

            if (movies == null)
                return BadRequest();

            else
                return Ok(Mapper.Map<Movie,MoviesDto>(movies));
        }

        //POST Api/movies/
        [HttpPost]
        public IHttpActionResult CreateMovies(MoviesDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var movies = Mapper.Map<MoviesDto, Movie>(movieDto);
           _context.movies.Add(movies);
           _context.SaveChanges();
            movieDto.Id = movies.Id;

            return Created(new Uri(Request.RequestUri + "/" + movies.Id), movieDto);
        }

        //PUT Api/movies/1
        [HttpPut]
        public void UpdateMovie(int id,MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var moviesInDb = _context.movies.SingleOrDefault(c => c.Id == id);
            if (moviesInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(moviesDto, moviesInDb);
            _context.SaveChanges();
   
        }

        //DELETE Api/movies/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
         var MoviesInDB=_context.movies.SingleOrDefault(c => c.Id == id);
            if (MoviesInDB == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
                
            }
            _context.movies.Remove(MoviesInDB);
            _context.SaveChanges();
        }
    }
}
