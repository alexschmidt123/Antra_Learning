using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services
{
    public class MovieService: IMovieService
    {
        //method that returns top movies to the caller
        //movie list 
        public List<MovieCardModel> GetTopGrossingMovies(){
            var movies = new List<MovieCardModel>{
                new MovieCardModel
            { Id = 1, Posterurl = "", Title = ""},
            { Id = 1, Posterurl = "", Title = ""},
            { Id = 1, Posterurl = "", Title = ""}
        };
        }
    }
}
