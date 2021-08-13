using Blazor.Movies.Shared;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Classes
{
    public class Service : IService
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
{
                    new Movie()
                    {
                        Title = "Spider-Man: Far From Home",
                        Release  = new DateTime(2019, 7, 2),
                        PosterURL = "https://www.imdb.com/title/tt6320628?ref_=nv_sr_srsg_0"
                    },
                    new Movie()
                    {
                        Title = "Moana",
                        Release  = new DateTime(2016, 11, 23),
                        PosterURL = "https://www.imdb.com/title/tt3521164/mediaviewer/rm618728448/?ref_=tt_ov_i"
                    },
                    new Movie()
                    {
                        Title = "Inception",
                        Release  = new DateTime(2010, 7, 16),
                        PosterURL = "https://www.imdb.com/title/tt1375666/mediaviewer/rm3426651392/?ref_=tt_ov_i"
                    }
                };
        }
    }
}
