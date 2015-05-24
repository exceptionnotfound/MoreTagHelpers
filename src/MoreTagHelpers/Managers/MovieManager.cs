using MoreTagHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreTagHelpers.Managers
{
    public static class MovieManager
    {
        public static List<Movie> GetAll()
        {
            return new List<Movie>()
            {
                new Movie() { ID = 1, Title = "Star Wars", ReleaseDate = new DateTime(1977,5,25), RunningTime = 121 },
                new Movie() { ID = 2, Title = "Blade Runner", ReleaseDate = new DateTime(1982, 6, 25), RunningTime = 120 },
                new Movie() { ID = 3, Title = "Edge of Tomorrow", ReleaseDate = new DateTime(2014, 5, 28), RunningTime = 113 }
            };
        }

        public static void Add(int id, string title, DateTime releaseDate, int runningTime)
        {
            //TODO
        }
    }
}
