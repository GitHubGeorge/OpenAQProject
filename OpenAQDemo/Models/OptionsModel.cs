using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAQDemo.ViewModels.Options;
using Newtonsoft.Json;

namespace OpenAQDemo.Models
{
    public class OptionsModel
    {
        // Get options
        public static OptionsViewModel GetOptions()
        {
            OptionsViewModel model = new OptionsViewModel();

            model.Options = OpenAQDemo.Startup.openAQHelper.GetOptions();

            return model;
        }

        // Get all cities
        public static CitiesViewModel GetCities()
        {
            CitiesViewModel model = new CitiesViewModel();

            model.Cities = Startup.openAQHelper.GetCities();

            return model;
        }

        // Get all countries
        public static CountriesViewModel GetCountries()
        {
            CountriesViewModel model = new CountriesViewModel();

            model.Countries = Startup.openAQHelper.GetCountries();

            return model;
        }

        // Get the measurements for a certain
        public static CountryMeasurementsViewModel GetCountryMeasurements(string countryCode)
        {
            CountryMeasurementsViewModel model = new CountryMeasurementsViewModel();

            model.Measurements = Startup.openAQHelper.GetCountryMeasurements(countryCode);

            return model;
        }
    }
}
