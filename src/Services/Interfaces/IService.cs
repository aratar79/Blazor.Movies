using Blazor.Movies.Shared;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IService
    {
        List<Movie> GetMovies();
    }
}
