using CoronaInfo.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaInfo.Services
{
    public class DataService
    {
        public static CoronaData ReadCoronaGlobalData(string url)
        {
            string contents;
            using (var wc = new System.Net.WebClient())
                contents = wc.DownloadString(url);
                dynamic json = JObject.Parse(contents);

                return new CoronaData(json.cases.Value, json.deaths.Value, json.recovered.Value);
        }

        public static CoronaCountryData ReadCoronaCountryData(string url)
        {
            string contents;
            using (var wc = new System.Net.WebClient())
                contents = wc.DownloadString(url);
            dynamic json = JObject.Parse(contents);
            return new CoronaCountryData(json.cases.Value, json.deaths.Value, json.recovered.Value, json.todayCases.Value, json.todayDeaths.Value, json.active.Value, json.critical.Value, json.totalTests.Value);
        }
    }
}
