
using System.Net.Http;
using System.Threading.Tasks;
using CoolBreeze.Models;

namespace CoolBreeze.Helpers
{
    public class WeatherHelper
    {
        public async static Task<WeatherInformation> GetCurrentConditionsAsync(string cityName, string countryCode)
        {
            string url = $"http://traininglabservices.azurewebsites.net/api/weather/current/city?cityName={cityName}&countryCode={countryCode}&registrationCode={App.RegistrationCode}";
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(url);
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherInformation>(response);
            return result;
        }
    }
}
