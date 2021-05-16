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

        //public List<string> JsonListMovieData(List<string> moveTitle)
        //{
        //    string key = "93974bd3";
        //    string url = @$"http://www.omdbapi.com/?apikey={key}&t={moveTitle}";

        //    HttpWebRequest request = WebRequest.CreateHttp(url);

        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        //    StreamReader reader = new StreamReader(response.GetResponseStream());

        //    string JSON = reader.ReadToEnd();

        //    return JSON;
        //}

        public List<MovieModel> ConvertListOfMovieData(string movieTitles)
        {
            string rawJsonData = JsonMovieData(movieTitles);

            List<MovieModel> dataConverted = JsonConvert.DeserializeObject<List<MovieModel>>(rawJsonData);

            return dataConverted;
        }


        

        // let's pass in all of our search terms. Somewhere else in our program, we can collect those search terms,
        // store them in a List (of strings) and then pass them in to this method below as a parameter.
        public List<MovieModel> MovieList(List<string> searchMovies)
        {
            List<MovieModel> movieList = new List<MovieModel>();  // let's init a list of movies now, and then add to it in our loop

            foreach (string sm in searchMovies)
            {
                // make web request to api
                string url = $@"http://www.omdbapi.com/?apikey={key}&t={sm}";
                HttpWebRequest request = WebRequest.CreateHttp(url);

                // store response
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // convert response into a string of raw JSON
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string JSON = reader.ReadToEnd();

                // convert string into an object
                MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(JSON);

                // add the object to the list
                movieList.Add(movie);
            }
            return movieList;
        }
    }
}
