using CoolBreeze.Common;
using CoolBreeze.Helpers;
using CoolBreeze.Models;

namespace CoolBreeze.ViewModels
{
    public class MainViewModel : ObservableBase
    {
        private string _cityName;

        private string _countryCode;

        private WeatherInformation _currentConditions;

        private bool _isBusy;

        private LocationType _locationType;

        private bool _needsRefresh;

        private string _postalCode;

        public MainViewModel()
        {
            IsBusy = true;
            NeedsRefresh = true;
            LocationType = LocationType.City;
            CityName = "Amsterdam";
            CountryCode = "HL";
            CurrentConditions = new WeatherInformation();
        }

        public LocationType LocationType
        {
            get { return _locationType; }
            set { SetProperty(ref _locationType, value); }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { SetProperty(ref _postalCode, value); }
        }

        public string CityName
        {
            get { return _cityName; }
            set { SetProperty(ref _cityName, value); }
        }

        public string CountryCode
        {
            get { return _countryCode; }
            set { SetProperty(ref _countryCode, value); }
        }

        public WeatherInformation CurrentConditions
        {
            get { return _currentConditions; }
            set { SetProperty(ref _currentConditions, value); }
        }

        public bool NeedsRefresh
        {
            get { return _needsRefresh || string.IsNullOrEmpty(_currentConditions.Conditions); }
            set { SetProperty(ref _needsRefresh, value); }
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        public async void RefreshCurrentConditionsAsync()
        {
            IsBusy = true;
            NeedsRefresh = false;

            var results = await WeatherHelper.GetCurrentConditionsAsync(CityName, CountryCode);

            CurrentConditions.Conditions = results.Conditions;
            CurrentConditions.Description = results.Description;
            CurrentConditions.DisplayName = results.DisplayName;
            CurrentConditions.Icon = results.Icon;
            CurrentConditions.Id = results.Id;
            CurrentConditions.MaxTemperature = results.MaxTemperature;
            CurrentConditions.MinTemperature = results.MinTemperature;
            CurrentConditions.Temperature = results.Temperature;
            CurrentConditions.Humidity = results.Humidity;
            CurrentConditions.TimeStamp = results.TimeStamp.ToLocalTime();

            IsBusy = false;
        }
    }
}