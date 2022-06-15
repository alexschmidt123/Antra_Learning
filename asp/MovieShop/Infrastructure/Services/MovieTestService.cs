using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services
{
    public class MovieTestService : IMovieService
    {
        public MovieDetailsModel GetMovieDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public List<MovieCardModel> GetTopGrossingMovies()
        {
            // going to no SQL database and getting the data
            var movies = new List<MovieCardModel> {
                new MovieCardModel { Id = 11, Posterurl = "http://images.tmdb.org/t/p/w342//9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg", Title = "Inception"},
                new MovieCardModel { Id = 12, Posterurl = "", Title = ""},
                new MovieCardModel { Id = 13, Posterurl = "", Title = ""},
                new MovieCardModel { Id = 14, Posterurl = "", Title = ""},
                new MovieCardModel { Id = 15, Posterurl = "", Title = ""}
            };
            return movies;
        }
    }
}
