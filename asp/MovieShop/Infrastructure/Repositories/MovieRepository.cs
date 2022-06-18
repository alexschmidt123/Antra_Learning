﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Respositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext): base(dbContext)
        {

        }
        public IEnumerable<Movie> Get30HighestGrossingMovies()
        {

            // LINQ code to get top 30 grossing movies
            // select top 30 * from Movie order by Revenue

            var movies = _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToList();
            return movies;
        }

        public IEnumerable<Movie> Get30HighestRatedMovies()
        {
            throw new NotImplementedException();
        }

        public override Movie GetById(int id)
        {
            //select * from Movie
            //join cast and Moviecast
            //join Trailer
            //Genre and MovieGenre
            //where id = id
            var movieDetails = _dbContext.Movies
                .Include(m => m.GenresOfMovie).ThenInclude(mbox => mbox.Genre)
                .Include(m => m.Trailers)
                .FirstOrDefault(m => m.Id == id);
            //FirstOrDefault
            //First = ex when there are no matching records

            //SingleOrDefault ok for 0 or 1, ex when more than one matching record
            //Single ex when more than one matching record
            return movieDetails;
        }
    }
}