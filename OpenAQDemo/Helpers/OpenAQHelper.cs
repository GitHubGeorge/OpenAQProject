using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace OpenAQDemo.Helpers
{
    public class OpenAQHelper
    {
        const string openAQBaseURL = "https://api.openaq.org/v1/";

        // Get data from web
        private string GetData(string dataQuery)
        {
            string str = string.Empty;

            try
            {
                WebRequest request = WebRequest.Create(openAQBaseURL + dataQuery);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();              
            }
            catch (Exception e)
            {
                throw new Exception("Error:", e.InnerException);
            }
            return str;
        }

        // Setup list with options
        public List<KeyValuePair<int, string>> GetOptions()
        {
            List<KeyValuePair<int, string>> options = new List<KeyValuePair<int, string>>();
            options.Add(new KeyValuePair<int, string>(1, "Cities"));
            options.Add(new KeyValuePair<int, string>(2, "Countries"));
            return options;
        }

        public List<Models.OpenAQ_City.Result> GetCities()
        {
            // Get data
            string jsonData = GetData("cities");

            // Extract the data
            var jsonObject = JsonConvert.DeserializeObject<Models.OpenAQ_City>(jsonData);

            // Return the list order by name using Linq because the ?order_by=name parameter doesn't always work
            return jsonObject.results.OrderBy(x => x.name).ToList();
        }

        public List<Models.OpenAQ_Country.Result> GetCountries()
        {
            // Get data
            string jsonData = GetData("countries");

            // Extract the data
            var jsonObject = JsonConvert.DeserializeObject<Models.OpenAQ_Country>(jsonData);

            // Return the list order by name using Linq because the ?order_by=name parameter doesn't always work
            return jsonObject.results.OrderBy(x => x.name).ToList();
        }

        public List<Models.CountryMeasurementsModel> GetCountryMeasurements(string countryCode)
        {            
            // Get the cities
            List<Models.OpenAQ_City.Result> cities = GetCities();

            // Setup list with results
            List<Models.CountryMeasurementsModel> result = new List<Models.CountryMeasurementsModel>();

            // Collect the measurements from cities where the country code agrees
            foreach(var item in cities.Where(x => x.country == countryCode).ToList())
            {
                result.Add(new Models.CountryMeasurementsModel() { count = item.count, name = item.name });                
            }

            return result;
        }



    }
}
