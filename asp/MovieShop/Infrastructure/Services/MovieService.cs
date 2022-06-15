﻿using System;
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
        public MovieDetailsModel GetMovieDetails(int Id)
        {
            var movie = new MovieDetailsModel()
            {

            };

            return movie;
        }

        //method that returns top movies to the caller
        //movie list 
        public List<MovieCardModel> GetTopGrossingMovies()
        {
            //call the movie repository to get the data from database
            var movies = new List<MovieCardModel> {
                new MovieCardModel { Id = 1, Posterurl = "http://images.tmdb.org/t/p/w342//9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg", Title = "Inception"},
                new MovieCardModel { Id = 2, Posterurl = "", Title = ""},
                new MovieCardModel { Id = 3, Posterurl = "", Title = ""},
                new MovieCardModel { Id = 4, Posterurl = "", Title = ""},
                new MovieCardModel { Id = 5, Posterurl = "", Title = ""}
            };
            return movies;
        }
    }
}
