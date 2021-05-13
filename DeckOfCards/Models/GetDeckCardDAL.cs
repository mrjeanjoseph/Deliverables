using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{
    public class GetDeckCardDAL
    {
        public string GetData() // the parameter allows them to use a city of choice
        {
            string url = @$"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            return JSON;
        }

        public CardDeckModel ConvertJsonRedditModel()
        {
            string data = GetData();

            CardDeckModel cardDeckModel = JsonConvert.DeserializeObject<CardDeckModel>(data);

            return cardDeckModel;
        }

    }
}
