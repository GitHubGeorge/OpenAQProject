using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAQDemo.ViewModels.Options;
using OpenAQDemo.Models;
using Newtonsoft.Json;

namespace OpenAQDemo.Controllers
{
    public class OptionsController : Controller
    {
       
        // Populate dropdown with options
        [HttpPost]
        public string GetOptions()
        {
            var options = OptionsModel.GetOptions();
            return JsonConvert.SerializeObject(options);
        }

        // User selected cities
        [HttpPost]
        public string GetCities()
        {
            var citiesResults = OptionsModel.GetCities();
            return JsonConvert.SerializeObject(citiesResults);
        }

        // User selected countries
        [HttpPost]
        public string GetCountries()
        {
            var countriesResults = OptionsModel.GetCountries();
            return JsonConvert.SerializeObject(countriesResults);
        }

        // User clicked on a country measurement
        [HttpPost]
        public string ShowCountryMeasurements(string countryCode)
        {
            var measurementResults = OptionsModel.GetCountryMeasurements(countryCode);
            return JsonConvert.SerializeObject(measurementResults);
        }
    }
}
