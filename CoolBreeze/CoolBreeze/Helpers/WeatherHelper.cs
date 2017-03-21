using System.Net.Http;
using System.Threading.Tasks;
using CoolBreeze.Models;
using Newtonsoft.Json;

namespace CoolBreeze.Helpers
{
    public class WeatherHelper
    {
        public static async Task<WeatherInformation> GetCurrentConditionsAsync(string cityName, string countryCode)
        {
            string url =
                $"http://traininglabservices.azurewebsites.net/api/weather/current/city?cityName={cityName}&countryCode={countryCode}&registrationCode={App.RegistrationCode}";
            var client = new HttpClient();
            var response = await client.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<WeatherInformation>(response);
            return result;
        }
    }
}