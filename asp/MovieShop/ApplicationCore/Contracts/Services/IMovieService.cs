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
        Task<List<MovieCardModel>> GetTopGrossingMovies();

        // get movie details
        Task<MovieDetailsModel> GetMovieDetails(int id);
        Task<List<MovieCardModel>> PaginatedResultSet(int id, int pageSize, int pageNumber);
    }
}
