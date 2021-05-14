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
        public string CreateNewDeck()
        {
            string url = @$"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            return JSON;
        }

        public string DrawCardsJson(string drawFive, string deckId)
        {

            string url = $@"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={drawFive}";
            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            return JSON; // getting raw json
        }

        public CardDeckModel ConvertJsonCardDeckModel()
        {
            string data = CreateNewDeck();

            CardDeckModel cardDeckModel = JsonConvert.DeserializeObject<CardDeckModel>(data);

            return cardDeckModel;
        }

        public CardDeckModel ConvertDrawCardsJson(string drawFive, string deckId)
        {
            string data = DrawCardsJson(drawFive, deckId);

            CardDeckModel cardDraw = JsonConvert.DeserializeObject<CardDeckModel>(data);

            return cardDraw;
        }
    }
}
