# OpenAQ demo

This demo shows it's possible to retrieve data from OpenAQ found in [OpenAQ](https://docs.openaq.org/). The demo is an ASP.NET Core Web application with only a few controllers and some models. There is no particular visualisation other than a dropdown select and some tables. 

## How to use

Once you run the demo, you'll see one dropdown with two options: Cities and Countries, each one of which simply makes a call to the example URL in the API to retrieve a list of cities and the air quality measurements taken in a city, as well the countries and the total measurements taken from all the cities in a country. 

When you select Cities you will be presented with a table, nothing exciting is shown here other than raw data coming back from the API.

When you select Countries you will see a list of countries and the total air quality masurements in each one, but you will notice each measurement is a link. If you click it you'll see the individual cities in that country displayed in a separate table where the measurements came from (*zoom out for the results to fit*). Due to a restrictive set of data this option works best with:

 - Australia
 - Austria
 - Bosnia and Herzegovina

For some countries, clicking on a measurement will show nothing because the city data haven't populated from the API call (there is a page limit, so it has be traversed but the demo doesn't accommodate for that).

Also some Countries have (null) for a name, only because in the raw data that value is not populated. 
 
Cities and countries are listed alphabetically, this is done through C# and not through the API. Even though the API supports this option and I have tried it out, I think it's not always working as expected.
