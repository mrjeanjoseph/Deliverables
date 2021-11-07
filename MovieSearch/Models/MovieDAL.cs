using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MovieSearch.Models
{
    public class MovieDAL
    {
        public string key = "93974bd3";
        public string JsonMovieData(string movieTitle)
        {

            string url = @$"http://www.omdbapi.com/?apikey={key}&t={movieTitle}";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();
            return JSON;
        }

        public MovieModel ConvertMovieData(string movieTitle)
        {
            string rawJsonData = JsonMovieData(movieTitle);
            MovieModel dataConverted = JsonConvert.DeserializeObject<MovieModel>(rawJsonData);
            return dataConverted;
        }
        public List<MovieModel> ConvertListOfMovieData(List<string> searchAnyMovies)
        {// Initiating a list of movies now, then add to it in the loop
            List<MovieModel> movieList = new List<MovieModel>();

            foreach (string sm in searchAnyMovies)
            {
                string url = $@"http://www.omdbapi.com/?apikey={key}&t={sm}";
                HttpWebRequest request = WebRequest.CreateHttp(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                string JSON = reader.ReadToEnd();

                MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(JSON);
                movieList.Add(movie);
            }
            return movieList;
        }
    }
}
