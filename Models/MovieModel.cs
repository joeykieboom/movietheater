using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using System.ComponentModel.DataAnnotations;
using dotnet_core_theater.Classes;

namespace dotnet_core_theater.Models
{
    public class MovieModel
    {
        public int MovieID { get; set; }
        public int TMDBID { get; set; }
        public string ImgSource { get; set; }
        public string TrailerSource { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Information { get; set; }
        public List<Cast> Cast { get; set; }

        public MovieModel(SearchMovie _movie)
        {
            TMDBID = _movie.Id;
            ImgSource = "https://image.tmdb.org/t/p/w500/" + _movie.PosterPath;
            Title = _movie.Title;
            ReleaseDate = _movie.ReleaseDate.Value.ToLongDateString();
            //Genre = _movie.GenreIds
            Information = _movie.Overview;
        }

        public MovieModel(TMDbLib.Objects.Movies.Movie _movie)
        {
            TMDBID = _movie.Id;
            ImgSource = "https://image.tmdb.org/t/p/w500/" + _movie.PosterPath;
            Title = _movie.Title;
            ReleaseDate = _movie.ReleaseDate.Value.ToLongDateString();
            //Genre = _movie.GenreIds
            Information = _movie.Overview;
          
            if (_movie.Credits.Cast.Count <= 10)
            {
                Cast = _movie.Credits.Cast;
            }
            else if (_movie.Credits.Cast.Count > 10)
            {
                Cast = _movie.Credits.Cast.GetRange(0, 10);
            }
            
            if (_movie.Videos != null)
            {
                foreach (Video vid in _movie.Videos.Results)
                {
                    if (vid.Type == "Trailer")
                    {
                        TrailerSource = "https://www.youtube.com/embed/" + vid.Key + "?controls=1";
                        break;
                    }
                }
            }
        }

        public MovieModel(int movieID)
        {
            new MovieModel(TmdbApi.Instance.GetMovieByID(movieID));
        }

        public static MovieModel GetModelByID(int movieID)
        {
            return new MovieModel(TmdbApi.Instance.GetMovieByID(movieID));
        }


    }
}