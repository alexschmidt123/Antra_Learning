using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services
{
    public interface IMovieService
    {
        List<MovieCardModel> GetTopGrossingMovies();

        // get movie details
        MovieDetailsModel GetMovieDetails(int id);
    }
}
