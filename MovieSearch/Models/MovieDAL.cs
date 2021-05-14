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
        public string JsonMovieData(string moveTitle)
        {
            string key = "93974bd3";
            string url = @$"http://www.omdbapi.com/?apikey={key}&t={moveTitle}";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            return JSON;
        }

        public MovieModel ConvertMovieData(string moveTitle)
        {
            string rawJsonData = JsonMovieData(moveTitle);

            MovieModel dataConverted = JsonConvert.DeserializeObject<MovieModel>(rawJsonData);

            return dataConverted;
        }
    }
}
