using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Respositories
{
    public interface IMovieRepository: IRepository<Movie>
    {
        IEnumerable<Movie> Get30HighestGrossingMovies();
        IEnumerable<Movie> Get30HighestRatedMovies();
    }
}
