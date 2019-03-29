using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;


namespace dotnet_core_theater.Classes
{
    public class TmdbApi
    {
        private static TmdbApi TMDBAPI;
        private const string API_KEY = "e258118e7ffb2fce1531e8cd8e44eed6";
        private TMDbClient TMDbClient { get; }

        public TmdbApi()
        {
            TMDbClient = new TMDbClient(API_KEY, true);
        }

        public SearchContainerWithDates<SearchMovie> GetNowInTheater()
        {
              return TMDbClient.GetMovieNowPlayingListAsync().Result;
        }

        public SearchContainerWithDates<SearchMovie> GetUpcoming()
        {
            return TMDbClient.GetMovieUpcomingListAsync().Result;
        }

        public void GetMovieByTitle(string title)
        {
            SearchContainer<SearchMovie> movie = TMDbClient.SearchMovieAsync(title).Result;
        }

        public TMDbLib.Objects.Movies.Movie GetMovieByID(int id)
        {
            return TMDbClient.GetMovieAsync(id, MovieMethods.Videos|MovieMethods.Credits).Result;
        }

        public static TmdbApi Instance
        {
            get
            {
                if (TMDBAPI == null)
                {
                    TMDBAPI = new TmdbApi();
                }
                return TMDBAPI;
            }
        }
    }
}