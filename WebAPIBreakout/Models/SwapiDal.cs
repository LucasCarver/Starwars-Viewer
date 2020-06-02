using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebAPIBreakout.Models
{
    public class SwapiDal
    {
        public string GetApiJson(string endpoint, int Id)
        {
            string url = $"https://swapi.dev/api/{endpoint}/{Id}/";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string output = rd.ReadToEnd();
            return output;
        }
        public Person GetPerson(string endpoint, int Id)
        {
            string personData = GetApiJson(endpoint, Id);
            Person p = JsonConvert.DeserializeObject<Person>(personData);
            return p;
        }
        public Starship GetStarship(string endpoint, int Id)
        {
            string starshipData = GetApiJson(endpoint, Id);
            Starship s = JsonConvert.DeserializeObject<Starship>(starshipData);
            return s;
        }
        public Planet GetPlanet(string endpoint, int Id)
        {
            string planetData = GetApiJson(endpoint, Id);
            Planet p = JsonConvert.DeserializeObject<Planet>(planetData);
            return p;
        }
    }
}
