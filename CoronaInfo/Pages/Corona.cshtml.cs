using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoronaInfo.Models;
using CoronaInfo.Services;

namespace CoronaInfo.Pages
{
    public class CoronaModel : PageModel
    {
        public void OnGet()
        {
            globalData = DataService.ReadCoronaGlobalData("https://coronavirus-19-api.herokuapp.com/all");
            countryData = DataService.ReadCoronaCountryData("https://coronavirus-19-api.herokuapp.com/countries/croatia");
        }

        public CoronaData globalData;
        public CoronaCountryData countryData;
    }
}
